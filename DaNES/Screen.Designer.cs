﻿namespace DanTup.DaNES
{
	partial class Screen
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
			this.pbScreen = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
			this.SuspendLayout();
			// 
			// pbScreen
			// 
			this.pbScreen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbScreen.Location = new System.Drawing.Point(0, 0);
			this.pbScreen.Name = "pbScreen";
			this.pbScreen.Size = new System.Drawing.Size(528, 519);
			this.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbScreen.TabIndex = 0;
			this.pbScreen.TabStop = false;
			// 
			// Screen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 519);
			this.Controls.Add(this.pbScreen);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Screen";
			this.Text = "DaNES";
			((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbScreen;
	}
}

