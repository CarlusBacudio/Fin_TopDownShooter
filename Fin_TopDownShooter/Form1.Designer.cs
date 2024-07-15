﻿namespace Fin_TopDownShooter
{
    partial class Shooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shooter));
            this.Quit = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Black;
            this.Quit.BackgroundImage = global::Fin_TopDownShooter.Properties.Resources.Button_Zombie_Pressed;
            this.Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Quit.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.SystemColors.Info;
            this.Quit.Location = new System.Drawing.Point(319, 380);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(250, 70);
            this.Quit.TabIndex = 4;
            this.Quit.Text = "QUIT";
            this.Quit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.Black;
            this.Setting.BackgroundImage = global::Fin_TopDownShooter.Properties.Resources.Button_Zombie;
            this.Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Setting.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting.ForeColor = System.Drawing.SystemColors.Info;
            this.Setting.Location = new System.Drawing.Point(319, 256);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(250, 70);
            this.Setting.TabIndex = 3;
            this.Setting.Text = "SETTING";
            this.Setting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Setting.UseVisualStyleBackColor = false;
            this.Setting.Click += new System.EventHandler(this.button1_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Black;
            this.Play.BackgroundImage = global::Fin_TopDownShooter.Properties.Resources.Button_Flesh_Pressed;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play.Font = new System.Drawing.Font("MingLiU-ExtB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.SystemColors.Info;
            this.Play.Location = new System.Drawing.Point(319, 144);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(250, 70);
            this.Play.TabIndex = 2;
            this.Play.Text = "PLAY";
            this.Play.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2, 415);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // Shooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Fin_TopDownShooter.Properties.Resources.vecteezy_vector_scene_illustration_of_beautiful_night_landscape_7633602;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 666);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.Play);
            this.Name = "Shooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shooter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shooter_FormClosing);
            this.Load += new System.EventHandler(this.Shooter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Setting;
        private System.Windows.Forms.Button Quit;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
