using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kinect_Coor_Example
{
    partial class DataCollector
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.picBox_MainCam = new System.Windows.Forms.PictureBox();
            this.lbl_FrameRate = new System.Windows.Forms.Label();
            this.lbl_StatusHolder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_MainCam)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(153, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(121, 45);
            this.btn_Start.TabIndex = 73;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Location = new System.Drawing.Point(725, 12);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(105, 45);
            this.btn_Stop.TabIndex = 74;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(471, 19);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(196, 32);
            this.lbl_Status.TabIndex = 75;
            this.lbl_Status.Text = "Not Recording";
            // 
            // picBox_MainCam
            // 
            this.picBox_MainCam.Location = new System.Drawing.Point(98, 63);
            this.picBox_MainCam.Name = "picBox_MainCam";
            this.picBox_MainCam.Size = new System.Drawing.Size(800, 450);
            this.picBox_MainCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_MainCam.TabIndex = 76;
            this.picBox_MainCam.TabStop = false;
            // 
            // lbl_FrameRate
            // 
            this.lbl_FrameRate.AutoSize = true;
            this.lbl_FrameRate.Location = new System.Drawing.Point(109, 520);
            this.lbl_FrameRate.Name = "lbl_FrameRate";
            this.lbl_FrameRate.Size = new System.Drawing.Size(133, 17);
            this.lbl_FrameRate.TabIndex = 77;
            this.lbl_FrameRate.Text = "Frame Rate: 0.0 fps";
            // 
            // lbl_StatusHolder
            // 
            this.lbl_StatusHolder.AutoSize = true;
            this.lbl_StatusHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusHolder.Location = new System.Drawing.Point(328, 19);
            this.lbl_StatusHolder.Name = "lbl_StatusHolder";
            this.lbl_StatusHolder.Size = new System.Drawing.Size(149, 32);
            this.lbl_StatusHolder.TabIndex = 78;
            this.lbl_StatusHolder.Text = "STATUS: ";
            // 
            // DataCollector
            // 
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lbl_StatusHolder);
            this.Controls.Add(this.lbl_FrameRate);
            this.Controls.Add(this.picBox_MainCam);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Name = "DataCollector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DataCollector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_MainCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Buttons
        private Button btn_Start;
        private Button btn_Stop;
        private Label lbl_Status;
        private PictureBox picBox_MainCam;
        private Label lbl_FrameRate;
        private Label lbl_StatusHolder;
    }
}

