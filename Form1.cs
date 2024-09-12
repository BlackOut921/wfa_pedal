using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace wfa_pedal
{
	public partial class Form1 : Form
	{
		private int selectedTrack = 1; //1 -> 4
		private readonly PictureBox[] trackLEDs = null;
		private bool[] trackMute = new bool[4] { false, false, false, false };

		private enum PedalMode { Record, Play };
		private PedalMode pedalMode = PedalMode.Record;

		private enum PedalState { None, Record, Overdub, Play, Stop };
		private PedalState pedalState = PedalState.None;

		private readonly Color ledColorRed = Color.Red;
		private readonly Color ledColorOrange = Color.Orange;
		private readonly Color ledColorGreen = Color.Green;
		private readonly Color ledColorBlue = Color.Blue;

		private DateTime tStart = DateTime.Now; //Loop start time
		private DateTime tEnd = DateTime.Now; //Loop end time
		private const int ms = 60000; //60k ms per minute
		private const int barDivision = 4; //4=Crotchets; 8=Quavers
		private int bpm = 120;
		private int barCount = 1;
		private int currentBeat = 1;
		private int currentBar = 1;

		//1000 ticks = 1 second
		//60,000ms / 120bpm = 500 = 1x 1/4 beat every 500ms??
		//60,000ms / 500ms = 120bpm

		/* To calculate the number of milliseconds per beat (ms/b) based on beats per minute (BPM), 
		 * you can divide the BPM by 60,000 milliseconds per minute. 
		 * 
		 * The one-minute units cancel each other out, leaving a value in milliseconds per beat. 
		 * 
		 * For example, a tempo of 80 BPM results in 750 milliseconds per beat*/

		public Form1()
		{
			InitializeComponent();

			//Collect all LEDs
			trackLEDs = new PictureBox[4] { ledTrackOne, ledTrackTwo, ledTrackThree, ledTrackFour };

			Clear();
		}

		private void PedalTimer_Tick(object sender, EventArgs e)
		{
			if (loopProgressBar.Value == loopProgressBar.Maximum)
				loopProgressBar.Value = 1;
			loopProgressBar.PerformStep();

			currentBeat++;
			if (currentBeat > barDivision)
			{
				currentBeat = 1;

				if (pedalState == PedalState.Record)
					barCount++;

				currentBar++;
				if (currentBar > barCount)
					currentBar = 1;
			}

			PrintDebugText();
		}

		private void PrintDebugText()
		{
			string debugString = string.Format("{0} | {1} | {2}", currentBeat, currentBar, barCount);
			lblBeatBarCount.Text = debugString;
		}

		private void UpdateUI()
		{
			//Update trackLEDs
			for (int i = 0; i < 4; i++)
			{
				switch (pedalMode)
				{
					case PedalMode.Record:
						trackLEDs[i].BackColor = selectedTrack - 1 == i ? ledColorRed : Color.Transparent;
						break;

					case PedalMode.Play:
						trackLEDs[i].BackColor = trackMute[i] ? Color.Transparent : ledColorGreen;
						break;

					default:
						trackLEDs[i].BackColor = Color.Transparent;
						break;
				}
			}

			//Update stateLED
			switch (pedalState)
			{
				case PedalState.None:
					ledRec.BackColor = Color.Transparent;
					break;

				case PedalState.Record:
					ledRec.BackColor = ledColorRed;
					break;

				case PedalState.Overdub:
					ledRec.BackColor = ledColorOrange;
					break;

				case PedalState.Play:
					ledRec.BackColor = ledColorGreen;
					break;

				default:
					ledRec.BackColor = Color.Transparent;
					break;
			}

			//Update stopLED
			ledStop.BackColor = pedalState == PedalState.Stop ? ledColorBlue : Color.Transparent;
		}

		private void Stop()
		{
			if (pedalState == PedalState.None)
				return;

			PedalTimer.Stop();
			PedalTimer.Enabled = false;
			currentBeat = 1;
			currentBar = 1;

			pedalState = PedalState.Stop;
			PrintDebugText();
			UpdateUI();
		}

		private void SelectTrack(int i = 1)
		{
			if (pedalMode == PedalMode.Play)
				return;

			selectedTrack = i;
			UpdateUI();
		}

		private void MuteTrack(int i = 1)
		{
			if (pedalMode == PedalMode.Record)
				return;

			trackMute[i - 1] = !trackMute[i - 1];
			UpdateUI();
		}

		private void Clear()
		{
			Stop();
			pedalMode = PedalMode.Record;
			pedalState = PedalState.None;
			SelectTrack(1);

			//Set any muted tracks (true) to false
			for (int i = 0; i < 4; i++)
				if (trackMute[i]) trackMute[i] = false;

			//Reset values to default
			loopProgressBar.Value = 0;
			PedalTimer.Interval = 500;
			bpm = 120;
			currentBeat = 1;
			currentBar = 1;
			barCount = 1;

			lblBPM.Text = bpm.ToString();
			lblBeatBarCount.Text = "BEAT | BAR | COUNT";
			lblOutput.Text = "OUTPUT";

			UpdateUI();
		}

		private void NextState()
		{
			switch (pedalState)
			{
				case PedalState.None:
					pedalState = PedalState.Record;
					tStart = DateTime.Now;
					PedalTimer.Enabled = true;
					PedalTimer.Start();
					currentBeat = 1;
					currentBar = 1;
					loopProgressBar.Value = currentBeat;
					PrintDebugText();
					break;

				case PedalState.Record:
					pedalState = PedalState.Overdub;
					tEnd = DateTime.Now;
					//Round barCount down if beat < barDivision
					if (currentBeat < barDivision && barCount > 1) { barCount--; }
					//Calculate bpm
					double length = tEnd.Subtract(tStart).TotalMilliseconds;
					bpm = (int)(ms / Math.Round(length, 0)) * barDivision * barCount;
					//Set timer interval
					PedalTimer.Interval = ms / bpm;
					//Start counts
					currentBeat = 1;
					currentBar = 1;
					//Set progress bar
					loopProgressBar.Maximum = barCount * barDivision;
					loopProgressBar.Value = currentBeat;
					//Update UI text
					lblBPM.Text = string.Format("{0}bpm", bpm);
					PrintDebugText();
					break;

				case PedalState.Overdub:
					pedalState = PedalState.Play;
					break;

				case PedalState.Play:
					pedalState = PedalState.Overdub;
					break;

				case PedalState.Stop:
					pedalState = PedalState.Play;
					PedalTimer.Start();
					break;

				default:
					pedalState = PedalState.None;
					break;
			}

			UpdateUI();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void BtnRec_Click(object sender, EventArgs e)
		{
			NextState();
		}

		private void BtnStop_Click(object sender, EventArgs e)
		{
			Stop();
		}

		private void BtnMode_Click(object sender, EventArgs e)
		{
			//Switch between RECORD (red) and PLAY (green)
			pedalMode = pedalMode == PedalMode.Record ? PedalMode.Play : PedalMode.Record;
			UpdateUI();
		}

		private void BtnTrackOne_Click(object sender, EventArgs e)
		{
			if (pedalMode == PedalMode.Record)
			{
				SelectTrack(1);
			}
			else
			{
				MuteTrack(1);
			}
		}

		private void BtnTrackTwo_Click(object sender, EventArgs e)
		{
			if (pedalMode == PedalMode.Record)
			{
				SelectTrack(2);
			}
			else
			{
				MuteTrack(2);
			}
		}

		private void BtnTrackThree_Click(object sender, EventArgs e)
		{
			if (pedalMode == PedalMode.Record)
			{
				SelectTrack(3);
			}
			else
			{
				MuteTrack(3);
			}
		}

		private void BtnTrackFour_Click(object sender, EventArgs e)
		{
			if (pedalMode == PedalMode.Record)
			{
				SelectTrack(4);
			}
			else
			{
				MuteTrack(4);
			}
		}
	}
}
