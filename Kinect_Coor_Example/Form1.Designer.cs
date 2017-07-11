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
            this.lbl_SpineX = new System.Windows.Forms.Label();
            this.lbl_SpineY = new System.Windows.Forms.Label();
            this.lbl_SpineZ = new System.Windows.Forms.Label();
            this.txt_08_Spine_X = new System.Windows.Forms.TextBox();
            this.txt_08_Spine_Y = new System.Windows.Forms.TextBox();
            this.txt_08_Spine_Z = new System.Windows.Forms.TextBox();
            this.lbl_LHandX = new System.Windows.Forms.Label();
            this.lbl_LHandZ = new System.Windows.Forms.Label();
            this.lbl_LHandY = new System.Windows.Forms.Label();
            this.txt_09_LHand_X = new System.Windows.Forms.TextBox();
            this.txt_09_LHand_Y = new System.Windows.Forms.TextBox();
            this.txt_09_LHand_Z = new System.Windows.Forms.TextBox();
            this.txt_10_RHand_X = new System.Windows.Forms.TextBox();
            this.txt_10_RHand_Y = new System.Windows.Forms.TextBox();
            this.txt_10_RHand_Z = new System.Windows.Forms.TextBox();
            this.lbl_RHandY = new System.Windows.Forms.Label();
            this.lbl_RHandZ = new System.Windows.Forms.Label();
            this.lbl_RHandX = new System.Windows.Forms.Label();
            this.txt_01_Head_X = new System.Windows.Forms.TextBox();
            this.txt_01_Head_Y = new System.Windows.Forms.TextBox();
            this.txt_01_Head_Z = new System.Windows.Forms.TextBox();
            this.lbl_HeadY = new System.Windows.Forms.Label();
            this.lbl_HeadZ = new System.Windows.Forms.Label();
            this.lbl_HeadX = new System.Windows.Forms.Label();
            this.lbl_LShoulderX = new System.Windows.Forms.Label();
            this.txt_02_LShoulder_X = new System.Windows.Forms.TextBox();
            this.txt_02_LShoulder_Y = new System.Windows.Forms.TextBox();
            this.lbl_LShoulderY = new System.Windows.Forms.Label();
            this.lbl_LShoulderZ = new System.Windows.Forms.Label();
            this.txt_03_RShoulder_Z = new System.Windows.Forms.TextBox();
            this.lbl_RShoulderZ = new System.Windows.Forms.Label();
            this.txt_03_RShoulder_Y = new System.Windows.Forms.TextBox();
            this.lbl_RShoulderY = new System.Windows.Forms.Label();
            this.txt_03_RShoulder_X = new System.Windows.Forms.TextBox();
            this.lbl_RShoulderX = new System.Windows.Forms.Label();
            this.txt_04_LKnee_Z = new System.Windows.Forms.TextBox();
            this.lbl_LKneeZ = new System.Windows.Forms.Label();
            this.txt_04_LKnee_Y = new System.Windows.Forms.TextBox();
            this.lbl_LKneeY = new System.Windows.Forms.Label();
            this.txt_04_LKnee_X = new System.Windows.Forms.TextBox();
            this.lbl_LKneeX = new System.Windows.Forms.Label();
            this.txt_05_RKnee_Z = new System.Windows.Forms.TextBox();
            this.lbl_RKneeZ = new System.Windows.Forms.Label();
            this.txt_05_RKnee_Y = new System.Windows.Forms.TextBox();
            this.lbl_RKneeY = new System.Windows.Forms.Label();
            this.txt_05_RKnee_X = new System.Windows.Forms.TextBox();
            this.lbl_RKneeX = new System.Windows.Forms.Label();
            this.txt_06_LElbow_Z = new System.Windows.Forms.TextBox();
            this.lbl_LElbowZ = new System.Windows.Forms.Label();
            this.txt_06_LElbow_Y = new System.Windows.Forms.TextBox();
            this.lbl_LElbowY = new System.Windows.Forms.Label();
            this.txt_06_LElbow_X = new System.Windows.Forms.TextBox();
            this.lbl_LElbowX = new System.Windows.Forms.Label();
            this.txt_07_RElbow_Z = new System.Windows.Forms.TextBox();
            this.lbl_RElbowZ = new System.Windows.Forms.Label();
            this.txt_07_RElbow_Y = new System.Windows.Forms.TextBox();
            this.lbl_RElbowY = new System.Windows.Forms.Label();
            this.txt_07_RElbow_X = new System.Windows.Forms.TextBox();
            this.lbl_RElbowX = new System.Windows.Forms.Label();
            this.txt_02_LShoulder_Z = new System.Windows.Forms.TextBox();
            this.txt_11_LFoot_X = new System.Windows.Forms.TextBox();
            this.txt_11_LFoot_Y = new System.Windows.Forms.TextBox();
            this.txt_11_LFoot_Z = new System.Windows.Forms.TextBox();
            this.lbl_LFootY = new System.Windows.Forms.Label();
            this.lbl_LFootZ = new System.Windows.Forms.Label();
            this.lbl_LFootX = new System.Windows.Forms.Label();
            this.txt_12_RFoot_X = new System.Windows.Forms.TextBox();
            this.txt_12_RFoot_Y = new System.Windows.Forms.TextBox();
            this.txt_12_RFoot_Z = new System.Windows.Forms.TextBox();
            this.lbl_RFootY = new System.Windows.Forms.Label();
            this.lbl_RFootZ = new System.Windows.Forms.Label();
            this.lbl_RFootX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_SpineX
            // 
            this.lbl_SpineX.AutoSize = true;
            this.lbl_SpineX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SpineX.Location = new System.Drawing.Point(12, 339);
            this.lbl_SpineX.Name = "lbl_SpineX";
            this.lbl_SpineX.Size = new System.Drawing.Size(93, 29);
            this.lbl_SpineX.TabIndex = 43;
            this.lbl_SpineX.Text = "SpineX";
            // 
            // lbl_SpineY
            // 
            this.lbl_SpineY.AutoSize = true;
            this.lbl_SpineY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SpineY.Location = new System.Drawing.Point(406, 339);
            this.lbl_SpineY.Name = "lbl_SpineY";
            this.lbl_SpineY.Size = new System.Drawing.Size(92, 29);
            this.lbl_SpineY.TabIndex = 45;
            this.lbl_SpineY.Text = "SpineY";
            // 
            // lbl_SpineZ
            // 
            this.lbl_SpineZ.AutoSize = true;
            this.lbl_SpineZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SpineZ.Location = new System.Drawing.Point(799, 339);
            this.lbl_SpineZ.Name = "lbl_SpineZ";
            this.lbl_SpineZ.Size = new System.Drawing.Size(90, 29);
            this.lbl_SpineZ.TabIndex = 47;
            this.lbl_SpineZ.Text = "SpineZ";
            // 
            // txt_08_Spine_X
            // 
            this.txt_08_Spine_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_08_Spine_X.Location = new System.Drawing.Point(204, 339);
            this.txt_08_Spine_X.Name = "txt_08_Spine_X";
            this.txt_08_Spine_X.Size = new System.Drawing.Size(175, 34);
            this.txt_08_Spine_X.TabIndex = 44;
            // 
            // txt_08_Spine_Y
            // 
            this.txt_08_Spine_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_08_Spine_Y.Location = new System.Drawing.Point(598, 336);
            this.txt_08_Spine_Y.Name = "txt_08_Spine_Y";
            this.txt_08_Spine_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_08_Spine_Y.TabIndex = 46;
            // 
            // txt_08_Spine_Z
            // 
            this.txt_08_Spine_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_08_Spine_Z.Location = new System.Drawing.Point(990, 336);
            this.txt_08_Spine_Z.Name = "txt_08_Spine_Z";
            this.txt_08_Spine_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_08_Spine_Z.TabIndex = 48;
            // 
            // lbl_LHandX
            // 
            this.lbl_LHandX.AutoSize = true;
            this.lbl_LHandX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LHandX.Location = new System.Drawing.Point(12, 386);
            this.lbl_LHandX.Name = "lbl_LHandX";
            this.lbl_LHandX.Size = new System.Drawing.Size(126, 29);
            this.lbl_LHandX.TabIndex = 49;
            this.lbl_LHandX.Text = "LeftHandX";
            // 
            // lbl_LHandZ
            // 
            this.lbl_LHandZ.AutoSize = true;
            this.lbl_LHandZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LHandZ.Location = new System.Drawing.Point(799, 386);
            this.lbl_LHandZ.Name = "lbl_LHandZ";
            this.lbl_LHandZ.Size = new System.Drawing.Size(123, 29);
            this.lbl_LHandZ.TabIndex = 53;
            this.lbl_LHandZ.Text = "LeftHandZ";
            // 
            // lbl_LHandY
            // 
            this.lbl_LHandY.AutoSize = true;
            this.lbl_LHandY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LHandY.Location = new System.Drawing.Point(406, 386);
            this.lbl_LHandY.Name = "lbl_LHandY";
            this.lbl_LHandY.Size = new System.Drawing.Size(125, 29);
            this.lbl_LHandY.TabIndex = 51;
            this.lbl_LHandY.Text = "LeftHandY";
            // 
            // txt_09_LHand_X
            // 
            this.txt_09_LHand_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_09_LHand_X.Location = new System.Drawing.Point(204, 386);
            this.txt_09_LHand_X.Name = "txt_09_LHand_X";
            this.txt_09_LHand_X.Size = new System.Drawing.Size(175, 34);
            this.txt_09_LHand_X.TabIndex = 50;
            // 
            // txt_09_LHand_Y
            // 
            this.txt_09_LHand_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_09_LHand_Y.Location = new System.Drawing.Point(598, 383);
            this.txt_09_LHand_Y.Name = "txt_09_LHand_Y";
            this.txt_09_LHand_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_09_LHand_Y.TabIndex = 52;
            // 
            // txt_09_LHand_Z
            // 
            this.txt_09_LHand_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_09_LHand_Z.Location = new System.Drawing.Point(990, 386);
            this.txt_09_LHand_Z.Name = "txt_09_LHand_Z";
            this.txt_09_LHand_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_09_LHand_Z.TabIndex = 54;
            // 
            // txt_10_RHand_X
            // 
            this.txt_10_RHand_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_10_RHand_X.Location = new System.Drawing.Point(204, 434);
            this.txt_10_RHand_X.Name = "txt_10_RHand_X";
            this.txt_10_RHand_X.Size = new System.Drawing.Size(175, 34);
            this.txt_10_RHand_X.TabIndex = 56;
            // 
            // txt_10_RHand_Y
            // 
            this.txt_10_RHand_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_10_RHand_Y.Location = new System.Drawing.Point(598, 434);
            this.txt_10_RHand_Y.Name = "txt_10_RHand_Y";
            this.txt_10_RHand_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_10_RHand_Y.TabIndex = 58;
            // 
            // txt_10_RHand_Z
            // 
            this.txt_10_RHand_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_10_RHand_Z.Location = new System.Drawing.Point(990, 434);
            this.txt_10_RHand_Z.Name = "txt_10_RHand_Z";
            this.txt_10_RHand_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_10_RHand_Z.TabIndex = 60;
            // 
            // lbl_RHandY
            // 
            this.lbl_RHandY.AutoSize = true;
            this.lbl_RHandY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RHandY.Location = new System.Drawing.Point(406, 437);
            this.lbl_RHandY.Name = "lbl_RHandY";
            this.lbl_RHandY.Size = new System.Drawing.Size(142, 29);
            this.lbl_RHandY.TabIndex = 57;
            this.lbl_RHandY.Text = "RightHandY";
            // 
            // lbl_RHandZ
            // 
            this.lbl_RHandZ.AutoSize = true;
            this.lbl_RHandZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RHandZ.Location = new System.Drawing.Point(799, 437);
            this.lbl_RHandZ.Name = "lbl_RHandZ";
            this.lbl_RHandZ.Size = new System.Drawing.Size(140, 29);
            this.lbl_RHandZ.TabIndex = 54;
            this.lbl_RHandZ.Text = "RightHandZ";
            // 
            // lbl_RHandX
            // 
            this.lbl_RHandX.AutoSize = true;
            this.lbl_RHandX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RHandX.Location = new System.Drawing.Point(12, 437);
            this.lbl_RHandX.Name = "lbl_RHandX";
            this.lbl_RHandX.Size = new System.Drawing.Size(143, 29);
            this.lbl_RHandX.TabIndex = 55;
            this.lbl_RHandX.Text = "RightHandX";
            // 
            // txt_01_Head_X
            // 
            this.txt_01_Head_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_01_Head_X.Location = new System.Drawing.Point(204, 6);
            this.txt_01_Head_X.Name = "txt_01_Head_X";
            this.txt_01_Head_X.Size = new System.Drawing.Size(175, 34);
            this.txt_01_Head_X.TabIndex = 2;
            // 
            // txt_01_Head_Y
            // 
            this.txt_01_Head_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_01_Head_Y.Location = new System.Drawing.Point(598, 6);
            this.txt_01_Head_Y.Name = "txt_01_Head_Y";
            this.txt_01_Head_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_01_Head_Y.TabIndex = 4;
            // 
            // txt_01_Head_Z
            // 
            this.txt_01_Head_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_01_Head_Z.Location = new System.Drawing.Point(990, 6);
            this.txt_01_Head_Z.Name = "txt_01_Head_Z";
            this.txt_01_Head_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_01_Head_Z.TabIndex = 6;
            // 
            // lbl_HeadY
            // 
            this.lbl_HeadY.AutoSize = true;
            this.lbl_HeadY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadY.Location = new System.Drawing.Point(406, 9);
            this.lbl_HeadY.Name = "lbl_HeadY";
            this.lbl_HeadY.Size = new System.Drawing.Size(87, 29);
            this.lbl_HeadY.TabIndex = 3;
            this.lbl_HeadY.Text = "HeadY";
            // 
            // lbl_HeadZ
            // 
            this.lbl_HeadZ.AutoSize = true;
            this.lbl_HeadZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadZ.Location = new System.Drawing.Point(799, 9);
            this.lbl_HeadZ.Name = "lbl_HeadZ";
            this.lbl_HeadZ.Size = new System.Drawing.Size(85, 29);
            this.lbl_HeadZ.TabIndex = 5;
            this.lbl_HeadZ.Text = "HeadZ";
            // 
            // lbl_HeadX
            // 
            this.lbl_HeadX.AutoSize = true;
            this.lbl_HeadX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadX.Location = new System.Drawing.Point(13, 9);
            this.lbl_HeadX.Name = "lbl_HeadX";
            this.lbl_HeadX.Size = new System.Drawing.Size(88, 29);
            this.lbl_HeadX.TabIndex = 1;
            this.lbl_HeadX.Text = "HeadX";
            // 
            // lbl_LShoulderX
            // 
            this.lbl_LShoulderX.AutoSize = true;
            this.lbl_LShoulderX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LShoulderX.Location = new System.Drawing.Point(12, 55);
            this.lbl_LShoulderX.Name = "lbl_LShoulderX";
            this.lbl_LShoulderX.Size = new System.Drawing.Size(167, 29);
            this.lbl_LShoulderX.TabIndex = 7;
            this.lbl_LShoulderX.Text = "ShoulderLeftX";
            // 
            // txt_02_LShoulder_X
            // 
            this.txt_02_LShoulder_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_02_LShoulder_X.Location = new System.Drawing.Point(204, 52);
            this.txt_02_LShoulder_X.Name = "txt_02_LShoulder_X";
            this.txt_02_LShoulder_X.Size = new System.Drawing.Size(175, 34);
            this.txt_02_LShoulder_X.TabIndex = 8;
            // 
            // txt_02_LShoulder_Y
            // 
            this.txt_02_LShoulder_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_02_LShoulder_Y.Location = new System.Drawing.Point(598, 52);
            this.txt_02_LShoulder_Y.Name = "txt_02_LShoulder_Y";
            this.txt_02_LShoulder_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_02_LShoulder_Y.TabIndex = 10;
            // 
            // lbl_LShoulderY
            // 
            this.lbl_LShoulderY.AutoSize = true;
            this.lbl_LShoulderY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LShoulderY.Location = new System.Drawing.Point(406, 55);
            this.lbl_LShoulderY.Name = "lbl_LShoulderY";
            this.lbl_LShoulderY.Size = new System.Drawing.Size(166, 29);
            this.lbl_LShoulderY.TabIndex = 9;
            this.lbl_LShoulderY.Text = "ShoulderLeftY";
            // 
            // lbl_LShoulderZ
            // 
            this.lbl_LShoulderZ.AutoSize = true;
            this.lbl_LShoulderZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LShoulderZ.Location = new System.Drawing.Point(799, 55);
            this.lbl_LShoulderZ.Name = "lbl_LShoulderZ";
            this.lbl_LShoulderZ.Size = new System.Drawing.Size(164, 29);
            this.lbl_LShoulderZ.TabIndex = 11;
            this.lbl_LShoulderZ.Text = "ShoulderLeftZ";
            // 
            // txt_03_RShoulder_Z
            // 
            this.txt_03_RShoulder_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_03_RShoulder_Z.Location = new System.Drawing.Point(990, 99);
            this.txt_03_RShoulder_Z.Name = "txt_03_RShoulder_Z";
            this.txt_03_RShoulder_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_03_RShoulder_Z.TabIndex = 18;
            // 
            // lbl_RShoulderZ
            // 
            this.lbl_RShoulderZ.AutoSize = true;
            this.lbl_RShoulderZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RShoulderZ.Location = new System.Drawing.Point(799, 102);
            this.lbl_RShoulderZ.Name = "lbl_RShoulderZ";
            this.lbl_RShoulderZ.Size = new System.Drawing.Size(181, 29);
            this.lbl_RShoulderZ.TabIndex = 17;
            this.lbl_RShoulderZ.Text = "ShoulderRightZ";
            // 
            // txt_03_RShoulder_Y
            // 
            this.txt_03_RShoulder_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_03_RShoulder_Y.Location = new System.Drawing.Point(598, 99);
            this.txt_03_RShoulder_Y.Name = "txt_03_RShoulder_Y";
            this.txt_03_RShoulder_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_03_RShoulder_Y.TabIndex = 16;
            // 
            // lbl_RShoulderY
            // 
            this.lbl_RShoulderY.AutoSize = true;
            this.lbl_RShoulderY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RShoulderY.Location = new System.Drawing.Point(406, 102);
            this.lbl_RShoulderY.Name = "lbl_RShoulderY";
            this.lbl_RShoulderY.Size = new System.Drawing.Size(183, 29);
            this.lbl_RShoulderY.TabIndex = 15;
            this.lbl_RShoulderY.Text = "ShoulderRightY";
            // 
            // txt_03_RShoulder_X
            // 
            this.txt_03_RShoulder_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_03_RShoulder_X.Location = new System.Drawing.Point(204, 99);
            this.txt_03_RShoulder_X.Name = "txt_03_RShoulder_X";
            this.txt_03_RShoulder_X.Size = new System.Drawing.Size(175, 34);
            this.txt_03_RShoulder_X.TabIndex = 14;
            // 
            // lbl_RShoulderX
            // 
            this.lbl_RShoulderX.AutoSize = true;
            this.lbl_RShoulderX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RShoulderX.Location = new System.Drawing.Point(12, 102);
            this.lbl_RShoulderX.Name = "lbl_RShoulderX";
            this.lbl_RShoulderX.Size = new System.Drawing.Size(184, 29);
            this.lbl_RShoulderX.TabIndex = 13;
            this.lbl_RShoulderX.Text = "ShoulderRightX";
            // 
            // txt_04_LKnee_Z
            // 
            this.txt_04_LKnee_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_04_LKnee_Z.Location = new System.Drawing.Point(990, 147);
            this.txt_04_LKnee_Z.Name = "txt_04_LKnee_Z";
            this.txt_04_LKnee_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_04_LKnee_Z.TabIndex = 24;
            // 
            // lbl_LKneeZ
            // 
            this.lbl_LKneeZ.AutoSize = true;
            this.lbl_LKneeZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LKneeZ.Location = new System.Drawing.Point(799, 150);
            this.lbl_LKneeZ.Name = "lbl_LKneeZ";
            this.lbl_LKneeZ.Size = new System.Drawing.Size(123, 29);
            this.lbl_LKneeZ.TabIndex = 23;
            this.lbl_LKneeZ.Text = "KneeLeftZ";
            // 
            // txt_04_LKnee_Y
            // 
            this.txt_04_LKnee_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_04_LKnee_Y.Location = new System.Drawing.Point(598, 147);
            this.txt_04_LKnee_Y.Name = "txt_04_LKnee_Y";
            this.txt_04_LKnee_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_04_LKnee_Y.TabIndex = 22;
            // 
            // lbl_LKneeY
            // 
            this.lbl_LKneeY.AutoSize = true;
            this.lbl_LKneeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LKneeY.Location = new System.Drawing.Point(406, 150);
            this.lbl_LKneeY.Name = "lbl_LKneeY";
            this.lbl_LKneeY.Size = new System.Drawing.Size(125, 29);
            this.lbl_LKneeY.TabIndex = 21;
            this.lbl_LKneeY.Text = "KneeLeftY";
            // 
            // txt_04_LKnee_X
            // 
            this.txt_04_LKnee_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_04_LKnee_X.Location = new System.Drawing.Point(204, 147);
            this.txt_04_LKnee_X.Name = "txt_04_LKnee_X";
            this.txt_04_LKnee_X.Size = new System.Drawing.Size(175, 34);
            this.txt_04_LKnee_X.TabIndex = 20;
            // 
            // lbl_LKneeX
            // 
            this.lbl_LKneeX.AutoSize = true;
            this.lbl_LKneeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LKneeX.Location = new System.Drawing.Point(12, 150);
            this.lbl_LKneeX.Name = "lbl_LKneeX";
            this.lbl_LKneeX.Size = new System.Drawing.Size(126, 29);
            this.lbl_LKneeX.TabIndex = 19;
            this.lbl_LKneeX.Text = "KneeLeftX";
            // 
            // txt_05_RKnee_Z
            // 
            this.txt_05_RKnee_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_05_RKnee_Z.Location = new System.Drawing.Point(990, 195);
            this.txt_05_RKnee_Z.Name = "txt_05_RKnee_Z";
            this.txt_05_RKnee_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_05_RKnee_Z.TabIndex = 30;
            // 
            // lbl_RKneeZ
            // 
            this.lbl_RKneeZ.AutoSize = true;
            this.lbl_RKneeZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RKneeZ.Location = new System.Drawing.Point(799, 198);
            this.lbl_RKneeZ.Name = "lbl_RKneeZ";
            this.lbl_RKneeZ.Size = new System.Drawing.Size(140, 29);
            this.lbl_RKneeZ.TabIndex = 29;
            this.lbl_RKneeZ.Text = "KneeRightZ";
            // 
            // txt_05_RKnee_Y
            // 
            this.txt_05_RKnee_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_05_RKnee_Y.Location = new System.Drawing.Point(598, 195);
            this.txt_05_RKnee_Y.Name = "txt_05_RKnee_Y";
            this.txt_05_RKnee_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_05_RKnee_Y.TabIndex = 28;
            // 
            // lbl_RKneeY
            // 
            this.lbl_RKneeY.AutoSize = true;
            this.lbl_RKneeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RKneeY.Location = new System.Drawing.Point(406, 198);
            this.lbl_RKneeY.Name = "lbl_RKneeY";
            this.lbl_RKneeY.Size = new System.Drawing.Size(142, 29);
            this.lbl_RKneeY.TabIndex = 27;
            this.lbl_RKneeY.Text = "KneeRightY";
            // 
            // txt_05_RKnee_X
            // 
            this.txt_05_RKnee_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_05_RKnee_X.Location = new System.Drawing.Point(204, 195);
            this.txt_05_RKnee_X.Name = "txt_05_RKnee_X";
            this.txt_05_RKnee_X.Size = new System.Drawing.Size(175, 34);
            this.txt_05_RKnee_X.TabIndex = 26;
            // 
            // lbl_RKneeX
            // 
            this.lbl_RKneeX.AutoSize = true;
            this.lbl_RKneeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RKneeX.Location = new System.Drawing.Point(12, 198);
            this.lbl_RKneeX.Name = "lbl_RKneeX";
            this.lbl_RKneeX.Size = new System.Drawing.Size(143, 29);
            this.lbl_RKneeX.TabIndex = 25;
            this.lbl_RKneeX.Text = "KneeRightX";
            // 
            // txt_06_LElbow_Z
            // 
            this.txt_06_LElbow_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_06_LElbow_Z.Location = new System.Drawing.Point(990, 243);
            this.txt_06_LElbow_Z.Name = "txt_06_LElbow_Z";
            this.txt_06_LElbow_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_06_LElbow_Z.TabIndex = 36;
            // 
            // lbl_LElbowZ
            // 
            this.lbl_LElbowZ.AutoSize = true;
            this.lbl_LElbowZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LElbowZ.Location = new System.Drawing.Point(799, 246);
            this.lbl_LElbowZ.Name = "lbl_LElbowZ";
            this.lbl_LElbowZ.Size = new System.Drawing.Size(134, 29);
            this.lbl_LElbowZ.TabIndex = 35;
            this.lbl_LElbowZ.Text = "ElbowLeftZ";
            // 
            // txt_06_LElbow_Y
            // 
            this.txt_06_LElbow_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_06_LElbow_Y.Location = new System.Drawing.Point(598, 243);
            this.txt_06_LElbow_Y.Name = "txt_06_LElbow_Y";
            this.txt_06_LElbow_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_06_LElbow_Y.TabIndex = 34;
            // 
            // lbl_LElbowY
            // 
            this.lbl_LElbowY.AutoSize = true;
            this.lbl_LElbowY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LElbowY.Location = new System.Drawing.Point(406, 246);
            this.lbl_LElbowY.Name = "lbl_LElbowY";
            this.lbl_LElbowY.Size = new System.Drawing.Size(136, 29);
            this.lbl_LElbowY.TabIndex = 33;
            this.lbl_LElbowY.Text = "ElbowLeftY";
            // 
            // txt_06_LElbow_X
            // 
            this.txt_06_LElbow_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_06_LElbow_X.Location = new System.Drawing.Point(204, 243);
            this.txt_06_LElbow_X.Name = "txt_06_LElbow_X";
            this.txt_06_LElbow_X.Size = new System.Drawing.Size(175, 34);
            this.txt_06_LElbow_X.TabIndex = 32;
            // 
            // lbl_LElbowX
            // 
            this.lbl_LElbowX.AutoSize = true;
            this.lbl_LElbowX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LElbowX.Location = new System.Drawing.Point(12, 246);
            this.lbl_LElbowX.Name = "lbl_LElbowX";
            this.lbl_LElbowX.Size = new System.Drawing.Size(137, 29);
            this.lbl_LElbowX.TabIndex = 31;
            this.lbl_LElbowX.Text = "ElbowLeftX";
            // 
            // txt_07_RElbow_Z
            // 
            this.txt_07_RElbow_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_07_RElbow_Z.Location = new System.Drawing.Point(990, 291);
            this.txt_07_RElbow_Z.Name = "txt_07_RElbow_Z";
            this.txt_07_RElbow_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_07_RElbow_Z.TabIndex = 42;
            // 
            // lbl_RElbowZ
            // 
            this.lbl_RElbowZ.AutoSize = true;
            this.lbl_RElbowZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RElbowZ.Location = new System.Drawing.Point(799, 294);
            this.lbl_RElbowZ.Name = "lbl_RElbowZ";
            this.lbl_RElbowZ.Size = new System.Drawing.Size(151, 29);
            this.lbl_RElbowZ.TabIndex = 41;
            this.lbl_RElbowZ.Text = "ElbowRightZ";
            // 
            // txt_07_RElbow_Y
            // 
            this.txt_07_RElbow_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_07_RElbow_Y.Location = new System.Drawing.Point(598, 291);
            this.txt_07_RElbow_Y.Name = "txt_07_RElbow_Y";
            this.txt_07_RElbow_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_07_RElbow_Y.TabIndex = 40;
            // 
            // lbl_RElbowY
            // 
            this.lbl_RElbowY.AutoSize = true;
            this.lbl_RElbowY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RElbowY.Location = new System.Drawing.Point(406, 294);
            this.lbl_RElbowY.Name = "lbl_RElbowY";
            this.lbl_RElbowY.Size = new System.Drawing.Size(153, 29);
            this.lbl_RElbowY.TabIndex = 39;
            this.lbl_RElbowY.Text = "ElbowRightY";
            // 
            // txt_07_RElbow_X
            // 
            this.txt_07_RElbow_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_07_RElbow_X.Location = new System.Drawing.Point(204, 291);
            this.txt_07_RElbow_X.Name = "txt_07_RElbow_X";
            this.txt_07_RElbow_X.Size = new System.Drawing.Size(175, 34);
            this.txt_07_RElbow_X.TabIndex = 38;
            // 
            // lbl_RElbowX
            // 
            this.lbl_RElbowX.AutoSize = true;
            this.lbl_RElbowX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RElbowX.Location = new System.Drawing.Point(12, 294);
            this.lbl_RElbowX.Name = "lbl_RElbowX";
            this.lbl_RElbowX.Size = new System.Drawing.Size(154, 29);
            this.lbl_RElbowX.TabIndex = 37;
            this.lbl_RElbowX.Text = "ElbowRightX";
            // 
            // txt_02_LShoulder_Z
            // 
            this.txt_02_LShoulder_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_02_LShoulder_Z.Location = new System.Drawing.Point(990, 52);
            this.txt_02_LShoulder_Z.Name = "txt_02_LShoulder_Z";
            this.txt_02_LShoulder_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_02_LShoulder_Z.TabIndex = 12;
            // 
            // txt_11_LFoot_X
            // 
            this.txt_11_LFoot_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_11_LFoot_X.Location = new System.Drawing.Point(205, 480);
            this.txt_11_LFoot_X.Name = "txt_11_LFoot_X";
            this.txt_11_LFoot_X.Size = new System.Drawing.Size(175, 34);
            this.txt_11_LFoot_X.TabIndex = 62;
            // 
            // txt_11_LFoot_Y
            // 
            this.txt_11_LFoot_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_11_LFoot_Y.Location = new System.Drawing.Point(599, 480);
            this.txt_11_LFoot_Y.Name = "txt_11_LFoot_Y";
            this.txt_11_LFoot_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_11_LFoot_Y.TabIndex = 64;
            // 
            // txt_11_LFoot_Z
            // 
            this.txt_11_LFoot_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_11_LFoot_Z.Location = new System.Drawing.Point(991, 480);
            this.txt_11_LFoot_Z.Name = "txt_11_LFoot_Z";
            this.txt_11_LFoot_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_11_LFoot_Z.TabIndex = 66;
            // 
            // lbl_LFootY
            // 
            this.lbl_LFootY.AutoSize = true;
            this.lbl_LFootY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LFootY.Location = new System.Drawing.Point(407, 483);
            this.lbl_LFootY.Name = "lbl_LFootY";
            this.lbl_LFootY.Size = new System.Drawing.Size(117, 29);
            this.lbl_LFootY.TabIndex = 63;
            this.lbl_LFootY.Text = "LeftFootY";
            // 
            // lbl_LFootZ
            // 
            this.lbl_LFootZ.AutoSize = true;
            this.lbl_LFootZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LFootZ.Location = new System.Drawing.Point(800, 483);
            this.lbl_LFootZ.Name = "lbl_LFootZ";
            this.lbl_LFootZ.Size = new System.Drawing.Size(115, 29);
            this.lbl_LFootZ.TabIndex = 65;
            this.lbl_LFootZ.Text = "LeftFootZ";
            // 
            // lbl_LFootX
            // 
            this.lbl_LFootX.AutoSize = true;
            this.lbl_LFootX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LFootX.Location = new System.Drawing.Point(13, 483);
            this.lbl_LFootX.Name = "lbl_LFootX";
            this.lbl_LFootX.Size = new System.Drawing.Size(118, 29);
            this.lbl_LFootX.TabIndex = 61;
            this.lbl_LFootX.Text = "LeftFootX";
            // 
            // txt_12_RFoot_X
            // 
            this.txt_12_RFoot_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_12_RFoot_X.Location = new System.Drawing.Point(205, 525);
            this.txt_12_RFoot_X.Name = "txt_12_RFoot_X";
            this.txt_12_RFoot_X.Size = new System.Drawing.Size(175, 34);
            this.txt_12_RFoot_X.TabIndex = 69;
            // 
            // txt_12_RFoot_Y
            // 
            this.txt_12_RFoot_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_12_RFoot_Y.Location = new System.Drawing.Point(599, 525);
            this.txt_12_RFoot_Y.Name = "txt_12_RFoot_Y";
            this.txt_12_RFoot_Y.Size = new System.Drawing.Size(175, 34);
            this.txt_12_RFoot_Y.TabIndex = 71;
            // 
            // txt_12_RFoot_Z
            // 
            this.txt_12_RFoot_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_12_RFoot_Z.Location = new System.Drawing.Point(991, 525);
            this.txt_12_RFoot_Z.Name = "txt_12_RFoot_Z";
            this.txt_12_RFoot_Z.Size = new System.Drawing.Size(175, 34);
            this.txt_12_RFoot_Z.TabIndex = 72;
            // 
            // lbl_RFootY
            // 
            this.lbl_RFootY.AutoSize = true;
            this.lbl_RFootY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RFootY.Location = new System.Drawing.Point(407, 528);
            this.lbl_RFootY.Name = "lbl_RFootY";
            this.lbl_RFootY.Size = new System.Drawing.Size(134, 29);
            this.lbl_RFootY.TabIndex = 70;
            this.lbl_RFootY.Text = "RightFootY";
            // 
            // lbl_RFootZ
            // 
            this.lbl_RFootZ.AutoSize = true;
            this.lbl_RFootZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RFootZ.Location = new System.Drawing.Point(800, 528);
            this.lbl_RFootZ.Name = "lbl_RFootZ";
            this.lbl_RFootZ.Size = new System.Drawing.Size(132, 29);
            this.lbl_RFootZ.TabIndex = 67;
            this.lbl_RFootZ.Text = "RightFootZ";
            // 
            // lbl_RFootX
            // 
            this.lbl_RFootX.AutoSize = true;
            this.lbl_RFootX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RFootX.Location = new System.Drawing.Point(13, 528);
            this.lbl_RFootX.Name = "lbl_RFootX";
            this.lbl_RFootX.Size = new System.Drawing.Size(135, 29);
            this.lbl_RFootX.TabIndex = 68;
            this.lbl_RFootX.Text = "RightFootX";
            // 
            // DataCollector
            // 
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.txt_12_RFoot_X);
            this.Controls.Add(this.txt_12_RFoot_Y);
            this.Controls.Add(this.txt_12_RFoot_Z);
            this.Controls.Add(this.lbl_RFootY);
            this.Controls.Add(this.lbl_RFootZ);
            this.Controls.Add(this.lbl_RFootX);
            this.Controls.Add(this.txt_11_LFoot_X);
            this.Controls.Add(this.txt_11_LFoot_Y);
            this.Controls.Add(this.txt_11_LFoot_Z);
            this.Controls.Add(this.lbl_LFootY);
            this.Controls.Add(this.lbl_LFootZ);
            this.Controls.Add(this.lbl_LFootX);
            this.Controls.Add(this.txt_07_RElbow_Z);
            this.Controls.Add(this.lbl_RElbowZ);
            this.Controls.Add(this.txt_07_RElbow_Y);
            this.Controls.Add(this.lbl_RElbowY);
            this.Controls.Add(this.txt_07_RElbow_X);
            this.Controls.Add(this.lbl_RElbowX);
            this.Controls.Add(this.txt_06_LElbow_Z);
            this.Controls.Add(this.lbl_LElbowZ);
            this.Controls.Add(this.txt_06_LElbow_Y);
            this.Controls.Add(this.lbl_LElbowY);
            this.Controls.Add(this.txt_06_LElbow_X);
            this.Controls.Add(this.lbl_LElbowX);
            this.Controls.Add(this.txt_05_RKnee_Z);
            this.Controls.Add(this.lbl_RKneeZ);
            this.Controls.Add(this.txt_05_RKnee_Y);
            this.Controls.Add(this.lbl_RKneeY);
            this.Controls.Add(this.txt_05_RKnee_X);
            this.Controls.Add(this.lbl_RKneeX);
            this.Controls.Add(this.txt_04_LKnee_Z);
            this.Controls.Add(this.lbl_LKneeZ);
            this.Controls.Add(this.txt_04_LKnee_Y);
            this.Controls.Add(this.lbl_LKneeY);
            this.Controls.Add(this.txt_04_LKnee_X);
            this.Controls.Add(this.lbl_LKneeX);
            this.Controls.Add(this.txt_03_RShoulder_Z);
            this.Controls.Add(this.lbl_RShoulderZ);
            this.Controls.Add(this.txt_03_RShoulder_Y);
            this.Controls.Add(this.lbl_RShoulderY);
            this.Controls.Add(this.txt_03_RShoulder_X);
            this.Controls.Add(this.lbl_RShoulderX);
            this.Controls.Add(this.txt_02_LShoulder_Z);
            this.Controls.Add(this.lbl_LShoulderZ);
            this.Controls.Add(this.txt_02_LShoulder_Y);
            this.Controls.Add(this.lbl_LShoulderY);
            this.Controls.Add(this.txt_02_LShoulder_X);
            this.Controls.Add(this.lbl_LShoulderX);
            this.Controls.Add(this.txt_01_Head_X);
            this.Controls.Add(this.txt_01_Head_Y);
            this.Controls.Add(this.txt_01_Head_Z);
            this.Controls.Add(this.lbl_HeadY);
            this.Controls.Add(this.lbl_HeadZ);
            this.Controls.Add(this.lbl_HeadX);
            this.Controls.Add(this.txt_10_RHand_X);
            this.Controls.Add(this.txt_10_RHand_Y);
            this.Controls.Add(this.txt_10_RHand_Z);
            this.Controls.Add(this.lbl_RHandY);
            this.Controls.Add(this.lbl_RHandZ);
            this.Controls.Add(this.lbl_RHandX);
            this.Controls.Add(this.txt_09_LHand_Z);
            this.Controls.Add(this.txt_09_LHand_Y);
            this.Controls.Add(this.txt_09_LHand_X);
            this.Controls.Add(this.lbl_LHandY);
            this.Controls.Add(this.lbl_LHandZ);
            this.Controls.Add(this.lbl_LHandX);
            this.Controls.Add(this.txt_08_Spine_Z);
            this.Controls.Add(this.txt_08_Spine_Y);
            this.Controls.Add(this.txt_08_Spine_X);
            this.Controls.Add(this.lbl_SpineZ);
            this.Controls.Add(this.lbl_SpineY);
            this.Controls.Add(this.lbl_SpineX);
            this.Name = "DataCollector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_HeadX; // Head
        private Label lbl_HeadY;
        private Label lbl_HeadZ;
        private Label lbl_LShoulderX; // Left Shoulder
        private Label lbl_LShoulderY;
        private Label lbl_LShoulderZ;
        private Label lbl_RShoulderX; // Right Shoulder
        private Label lbl_RShoulderY;
        private Label lbl_RShoulderZ;
        private Label lbl_LKneeX; // Left Knee
        private Label lbl_LKneeY;
        private Label lbl_LKneeZ;
        private Label lbl_RKneeX; // Right Knee
        private Label lbl_RKneeY;
        private Label lbl_RKneeZ;
        private Label lbl_LElbowX; // Left Elbow
        private Label lbl_LElbowY;
        private Label lbl_LElbowZ;
        private Label lbl_RElbowX; // Right Elbow
        private Label lbl_RElbowY;
        private Label lbl_RElbowZ;
        private Label lbl_SpineX; // Spine
        private Label lbl_SpineY;
        private Label lbl_SpineZ;
        private Label lbl_LHandX; // Left Hand
        private Label lbl_LHandY;
        private Label lbl_LHandZ;
        private Label lbl_RHandX; // Right Hand
        private Label lbl_RHandY;
        private Label lbl_RHandZ;
        private Label lbl_LFootX; // Left Foot
        private Label lbl_LFootY;
        private Label lbl_LFootZ;
        private Label lbl_RFootX; // Right Foot
        private Label lbl_RFootY;
        private Label lbl_RFootZ;

        private TextBox txt_01_Head_X; // Head
        private TextBox txt_01_Head_Y;
        private TextBox txt_01_Head_Z;
        private TextBox txt_02_LShoulder_X; // Left Shoulder
        private TextBox txt_02_LShoulder_Y;
        private TextBox txt_02_LShoulder_Z;
        private TextBox txt_03_RShoulder_X; // Right Shoulder
        private TextBox txt_03_RShoulder_Y;
        private TextBox txt_03_RShoulder_Z;
        private TextBox txt_04_LKnee_X; // Left Knee
        private TextBox txt_04_LKnee_Y;
        private TextBox txt_04_LKnee_Z;
        private TextBox txt_05_RKnee_X; // Right Knee
        private TextBox txt_05_RKnee_Y;
        private TextBox txt_05_RKnee_Z;
        private TextBox txt_06_LElbow_X; // Left Elbow
        private TextBox txt_06_LElbow_Y;
        private TextBox txt_06_LElbow_Z;
        private TextBox txt_07_RElbow_X; // Right Elbow
        private TextBox txt_07_RElbow_Y;
        private TextBox txt_07_RElbow_Z;
        private TextBox txt_08_Spine_X; // Spine
        private TextBox txt_08_Spine_Y;
        private TextBox txt_08_Spine_Z;
        private TextBox txt_09_LHand_X; // Left Hand
        private TextBox txt_09_LHand_Y;
        private TextBox txt_09_LHand_Z;
        private TextBox txt_10_RHand_X; // Right Hand
        private TextBox txt_10_RHand_Y;
        private TextBox txt_10_RHand_Z;
        private TextBox txt_11_LFoot_X; // Left Foot
        private TextBox txt_11_LFoot_Y;
        private TextBox txt_11_LFoot_Z;
        private TextBox txt_12_RFoot_X; // Right Foot
        private TextBox txt_12_RFoot_Y;
        private TextBox txt_12_RFoot_Z;
    }
}

