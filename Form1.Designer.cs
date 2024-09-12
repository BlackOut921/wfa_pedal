namespace wfa_pedal
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.BtnRec = new System.Windows.Forms.Button();
			this.BtnStop = new System.Windows.Forms.Button();
			this.BtnMode = new System.Windows.Forms.Button();
			this.BtnTrackOne = new System.Windows.Forms.Button();
			this.BtnTrackTwo = new System.Windows.Forms.Button();
			this.BtnTrackThree = new System.Windows.Forms.Button();
			this.BtnTrackFour = new System.Windows.Forms.Button();
			this.BtnClear = new System.Windows.Forms.Button();
			this.ledRec = new System.Windows.Forms.PictureBox();
			this.ledStop = new System.Windows.Forms.PictureBox();
			this.ledTrackOne = new System.Windows.Forms.PictureBox();
			this.ledTrackTwo = new System.Windows.Forms.PictureBox();
			this.ledTrackThree = new System.Windows.Forms.PictureBox();
			this.ledTrackFour = new System.Windows.Forms.PictureBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.loopProgressBar = new System.Windows.Forms.ProgressBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblBeatBarCount = new System.Windows.Forms.Label();
			this.lblBPM = new System.Windows.Forms.Label();
			this.PedalTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ledRec)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ledStop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ledTrackOne)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ledTrackTwo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ledTrackThree)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ledTrackFour)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnRec
			// 
			this.BtnRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnRec.ForeColor = System.Drawing.Color.Black;
			this.BtnRec.Location = new System.Drawing.Point(14, 345);
			this.BtnRec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnRec.Name = "BtnRec";
			this.BtnRec.Size = new System.Drawing.Size(117, 173);
			this.BtnRec.TabIndex = 0;
			this.BtnRec.Text = "REC";
			this.BtnRec.UseVisualStyleBackColor = false;
			this.BtnRec.Click += new System.EventHandler(this.BtnRec_Click);
			// 
			// BtnStop
			// 
			this.BtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnStop.ForeColor = System.Drawing.Color.Black;
			this.BtnStop.Location = new System.Drawing.Point(138, 345);
			this.BtnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnStop.Name = "BtnStop";
			this.BtnStop.Size = new System.Drawing.Size(117, 173);
			this.BtnStop.TabIndex = 1;
			this.BtnStop.Text = "STOP";
			this.BtnStop.UseVisualStyleBackColor = false;
			this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
			// 
			// BtnMode
			// 
			this.BtnMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnMode.ForeColor = System.Drawing.Color.Black;
			this.BtnMode.Location = new System.Drawing.Point(261, 345);
			this.BtnMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnMode.Name = "BtnMode";
			this.BtnMode.Size = new System.Drawing.Size(117, 173);
			this.BtnMode.TabIndex = 2;
			this.BtnMode.Text = "MODE";
			this.BtnMode.UseVisualStyleBackColor = false;
			this.BtnMode.Click += new System.EventHandler(this.BtnMode_Click);
			// 
			// BtnTrackOne
			// 
			this.BtnTrackOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.BtnTrackOne.ForeColor = System.Drawing.Color.Black;
			this.BtnTrackOne.Location = new System.Drawing.Point(530, 345);
			this.BtnTrackOne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnTrackOne.Name = "BtnTrackOne";
			this.BtnTrackOne.Size = new System.Drawing.Size(117, 173);
			this.BtnTrackOne.TabIndex = 3;
			this.BtnTrackOne.Text = "1";
			this.BtnTrackOne.UseVisualStyleBackColor = false;
			this.BtnTrackOne.Click += new System.EventHandler(this.BtnTrackOne_Click);
			// 
			// BtnTrackTwo
			// 
			this.BtnTrackTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.BtnTrackTwo.ForeColor = System.Drawing.Color.Black;
			this.BtnTrackTwo.Location = new System.Drawing.Point(653, 345);
			this.BtnTrackTwo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnTrackTwo.Name = "BtnTrackTwo";
			this.BtnTrackTwo.Size = new System.Drawing.Size(117, 173);
			this.BtnTrackTwo.TabIndex = 4;
			this.BtnTrackTwo.Text = "2";
			this.BtnTrackTwo.UseVisualStyleBackColor = false;
			this.BtnTrackTwo.Click += new System.EventHandler(this.BtnTrackTwo_Click);
			// 
			// BtnTrackThree
			// 
			this.BtnTrackThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.BtnTrackThree.ForeColor = System.Drawing.Color.Black;
			this.BtnTrackThree.Location = new System.Drawing.Point(777, 345);
			this.BtnTrackThree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnTrackThree.Name = "BtnTrackThree";
			this.BtnTrackThree.Size = new System.Drawing.Size(117, 173);
			this.BtnTrackThree.TabIndex = 5;
			this.BtnTrackThree.Text = "3";
			this.BtnTrackThree.UseVisualStyleBackColor = false;
			this.BtnTrackThree.Click += new System.EventHandler(this.BtnTrackThree_Click);
			// 
			// BtnTrackFour
			// 
			this.BtnTrackFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.BtnTrackFour.ForeColor = System.Drawing.Color.Black;
			this.BtnTrackFour.Location = new System.Drawing.Point(901, 345);
			this.BtnTrackFour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnTrackFour.Name = "BtnTrackFour";
			this.BtnTrackFour.Size = new System.Drawing.Size(117, 173);
			this.BtnTrackFour.TabIndex = 6;
			this.BtnTrackFour.Text = "4";
			this.BtnTrackFour.UseVisualStyleBackColor = false;
			this.BtnTrackFour.Click += new System.EventHandler(this.BtnTrackFour_Click);
			// 
			// BtnClear
			// 
			this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnClear.ForeColor = System.Drawing.Color.Black;
			this.BtnClear.Location = new System.Drawing.Point(261, 47);
			this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(117, 173);
			this.BtnClear.TabIndex = 7;
			this.BtnClear.Text = "CLEAR";
			this.BtnClear.UseVisualStyleBackColor = false;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// ledRec
			// 
			this.ledRec.BackColor = System.Drawing.Color.White;
			this.ledRec.Location = new System.Drawing.Point(14, 309);
			this.ledRec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ledRec.Name = "ledRec";
			this.ledRec.Size = new System.Drawing.Size(117, 29);
			this.ledRec.TabIndex = 8;
			this.ledRec.TabStop = false;
			// 
			// ledStop
			// 
			this.ledStop.BackColor = System.Drawing.Color.White;
			this.ledStop.Location = new System.Drawing.Point(138, 309);
			this.ledStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ledStop.Name = "ledStop";
			this.ledStop.Size = new System.Drawing.Size(117, 29);
			this.ledStop.TabIndex = 9;
			this.ledStop.TabStop = false;
			// 
			// ledTrackOne
			// 
			this.ledTrackOne.BackColor = System.Drawing.Color.White;
			this.ledTrackOne.Location = new System.Drawing.Point(530, 309);
			this.ledTrackOne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ledTrackOne.Name = "ledTrackOne";
			this.ledTrackOne.Size = new System.Drawing.Size(117, 29);
			this.ledTrackOne.TabIndex = 10;
			this.ledTrackOne.TabStop = false;
			// 
			// ledTrackTwo
			// 
			this.ledTrackTwo.BackColor = System.Drawing.Color.White;
			this.ledTrackTwo.Location = new System.Drawing.Point(653, 309);
			this.ledTrackTwo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ledTrackTwo.Name = "ledTrackTwo";
			this.ledTrackTwo.Size = new System.Drawing.Size(117, 29);
			this.ledTrackTwo.TabIndex = 11;
			this.ledTrackTwo.TabStop = false;
			// 
			// ledTrackThree
			// 
			this.ledTrackThree.BackColor = System.Drawing.Color.White;
			this.ledTrackThree.Location = new System.Drawing.Point(777, 309);
			this.ledTrackThree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ledTrackThree.Name = "ledTrackThree";
			this.ledTrackThree.Size = new System.Drawing.Size(117, 29);
			this.ledTrackThree.TabIndex = 12;
			this.ledTrackThree.TabStop = false;
			// 
			// ledTrackFour
			// 
			this.ledTrackFour.BackColor = System.Drawing.Color.White;
			this.ledTrackFour.Location = new System.Drawing.Point(901, 309);
			this.ledTrackFour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ledTrackFour.Name = "ledTrackFour";
			this.ledTrackFour.Size = new System.Drawing.Size(117, 29);
			this.ledTrackFour.TabIndex = 13;
			this.ledTrackFour.TabStop = false;
			// 
			// lblOutput
			// 
			this.lblOutput.AutoSize = true;
			this.lblOutput.BackColor = System.Drawing.Color.Transparent;
			this.lblOutput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOutput.ForeColor = System.Drawing.Color.White;
			this.lblOutput.Location = new System.Drawing.Point(4, 102);
			this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(56, 15);
			this.lblOutput.TabIndex = 14;
			this.lblOutput.Text = "OUTPUT";
			this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// loopProgressBar
			// 
			this.loopProgressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
			this.loopProgressBar.Location = new System.Drawing.Point(14, 276);
			this.loopProgressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.loopProgressBar.Maximum = 4;
			this.loopProgressBar.Name = "loopProgressBar";
			this.loopProgressBar.Size = new System.Drawing.Size(117, 27);
			this.loopProgressBar.Step = 1;
			this.loopProgressBar.TabIndex = 15;
			this.loopProgressBar.Value = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lblBeatBarCount);
			this.panel1.Controls.Add(this.lblBPM);
			this.panel1.Controls.Add(this.lblOutput);
			this.panel1.Location = new System.Drawing.Point(530, 47);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(487, 221);
			this.panel1.TabIndex = 16;
			// 
			// lblBeatBarCount
			// 
			this.lblBeatBarCount.AutoSize = true;
			this.lblBeatBarCount.BackColor = System.Drawing.Color.Transparent;
			this.lblBeatBarCount.ForeColor = System.Drawing.Color.White;
			this.lblBeatBarCount.Location = new System.Drawing.Point(119, 20);
			this.lblBeatBarCount.Name = "lblBeatBarCount";
			this.lblBeatBarCount.Size = new System.Drawing.Size(121, 15);
			this.lblBeatBarCount.TabIndex = 16;
			this.lblBeatBarCount.Text = "BEAT | BAR | COUNT";
			this.lblBeatBarCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBPM
			// 
			this.lblBPM.AutoSize = true;
			this.lblBPM.BackColor = System.Drawing.Color.Transparent;
			this.lblBPM.ForeColor = System.Drawing.Color.White;
			this.lblBPM.Location = new System.Drawing.Point(3, 20);
			this.lblBPM.Name = "lblBPM";
			this.lblBPM.Size = new System.Drawing.Size(32, 15);
			this.lblBPM.TabIndex = 15;
			this.lblBPM.Text = "BPM";
			this.lblBPM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PedalTimer
			// 
			this.PedalTimer.Interval = 500;
			this.PedalTimer.Tick += new System.EventHandler(this.PedalTimer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.ClientSize = new System.Drawing.Size(1031, 532);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.loopProgressBar);
			this.Controls.Add(this.ledTrackFour);
			this.Controls.Add(this.ledTrackThree);
			this.Controls.Add(this.ledTrackTwo);
			this.Controls.Add(this.ledTrackOne);
			this.Controls.Add(this.ledStop);
			this.Controls.Add(this.ledRec);
			this.Controls.Add(this.BtnClear);
			this.Controls.Add(this.BtnTrackFour);
			this.Controls.Add(this.BtnTrackThree);
			this.Controls.Add(this.BtnTrackTwo);
			this.Controls.Add(this.BtnTrackOne);
			this.Controls.Add(this.BtnMode);
			this.Controls.Add(this.BtnStop);
			this.Controls.Add(this.BtnRec);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.ledRec)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ledStop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ledTrackOne)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ledTrackTwo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ledTrackThree)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ledTrackFour)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnRec;
		private System.Windows.Forms.Button BtnStop;
		private System.Windows.Forms.Button BtnMode;
		private System.Windows.Forms.Button BtnTrackOne;
		private System.Windows.Forms.Button BtnTrackTwo;
		private System.Windows.Forms.Button BtnTrackThree;
		private System.Windows.Forms.Button BtnTrackFour;
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.PictureBox ledRec;
		private System.Windows.Forms.PictureBox ledStop;
		private System.Windows.Forms.PictureBox ledTrackOne;
		private System.Windows.Forms.PictureBox ledTrackTwo;
		private System.Windows.Forms.PictureBox ledTrackThree;
		private System.Windows.Forms.PictureBox ledTrackFour;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.ProgressBar loopProgressBar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer PedalTimer;
		private System.Windows.Forms.Label lblBPM;
		private System.Windows.Forms.Label lblBeatBarCount;
	}
}

