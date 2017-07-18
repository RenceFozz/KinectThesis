using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;

namespace Kinect_Coor_Example
{
    public partial class DataCollector : Form
    {
        //Head = 0,
        //ShoulderLeft = 1,
        //ShoulderRight = 2,
        //ShoulderCenter = 3, 
        //KneeLeft = 4,
        //KneeRight = 5,
        //ElbowLeft = 6,
        //ElbowRight = 7,
        //SpineMid = 8,
        //HandLeft = 9,
        //HandRight = 10,
        //FootLeft = 11,
        //FootRight = 12

        KinectSensor kS = null;
        BodyFrameReader bFR = null;
        Body[] bodies = null;
        String FilePath = null;
        StringBuilder csv = null;
        JointType[] jointENum = {JointType.Head, JointType.ShoulderLeft, JointType.ShoulderRight, JointType.SpineShoulder,
            JointType.KneeLeft, JointType.KneeRight, JointType.ElbowLeft,
            JointType.ElbowRight, JointType.SpineMid, JointType.HandLeft,
            JointType.HandRight, JointType.FootLeft, JointType.FootRight};

        public DataCollector() {
            InitializeComponent();
            InitializeVar();
        }

        public void InitializeVar() {
            btn_Stop.Enabled = false;
            kS = KinectSensor.GetDefault();
            bFR = kS.BodyFrameSource.OpenReader();
            csv = new StringBuilder();
        }

        public void InitializeKinect() {
            lbl_Status.Text = "INITIALIZING...";
            FilePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + ".csv";
            /*Console.WriteLine(FilePath);
            ColorFrameReader reader = kS.ColorFrameSource.OpenReader();
            reader.FrameArrived += FrameArrived;*/

            String top = ("HeadX, HeadY, HeadZ, "+
                "ShoulderLeftX, ShoulderLeftY, ShoulderLeftZ, " +
                "ShoulderRightX, ShoulderRightY, ShoulderRightZ, " +
                "ShoulderCenterX, ShoulderCenterY, ShoulderCenterZ, " +
                "KneeLeftX, KneeLeftY, KneeLeftZ, " +
                "KneeRightX, KneeRightY, KneeRightZ, " +
                "ElbowLeftX, ElbowLeftY, ElbowLeftZ, " +
                "ElbowRightX, ElbowRightY, ElbowRightZ, " +
                "SpineX, SpineY, SpineZ, " +
                "LeftHandX, LeftHandY, LeftHandZ, " +
                "RightHandX, RightHandY, RightHandZ, " +
                "LeftFootX, LeftFootY, LeftFootZ, " +
                "RightFootX, RightFootY, RightFootZ");

            csv.AppendLine(top);
            if (kS != null) {
                kS.Open();
            }

            if (bFR != null) {
                lbl_Status.Text = "RECORDING...";
                bFR.FrameArrived += Reader_FrameArrived;
            }
        }

        /*private void FrameArrived(object sender, ColorFrameArrivedEventArgs args){
            using (var frame = args.FrameReference.AcquireFrame()){
                double fps = 1.0 / frame.ColorCameraSettings.FrameInterval.TotalSeconds;
                Console.WriteLine(fps);
            }
        }*/

        private void Reader_FrameArrived(object sender, BodyFrameArrivedEventArgs e){
            bool dataReceived = false;
            using (BodyFrame bodyFrame = e.FrameReference.AcquireFrame())
            {
                if (bodyFrame != null) {
                    if (bodies == null) {
                        bodies = new Body[bodyFrame.BodyCount];
                    }
                    bodyFrame.GetAndRefreshBodyData(bodies);
                    dataReceived = true;
                }
            }

            if (dataReceived) {
                foreach (Body body in bodies) {
                    if (body.IsTracked) {
                        IReadOnlyDictionary<JointType, Joint> joints = body.Joints;
                        Dictionary<JointType, Point> jointPoints = new Dictionary<JointType, Point>();
                        Joint[] jointData = new Joint[jointENum.Length];
                        String newLine, temp = "";

                        for (int a = 0; a < jointData.Length; a++) {
                            jointData[a] = joints[ jointENum[a] ];
                        }

                        for (int i = 0; i < jointData.Length; i++) {
                            switch (i < (jointData.Length - 1) ) {
                                case true: temp = "{0},{1},{2},";  break;
                                case false: temp = "{0},{1},{2}"; break;
                            }
                            newLine = string.Format(temp, 
                                jointData[i].Position.X.ToString(), 
                                jointData[i].Position.Y.ToString(), 
                                jointData[i].Position.Z.ToString());
                            csv.Append(newLine);
                        }
                        csv.Append("\n");
                    }
                }
                File.WriteAllText(FilePath, csv.ToString());
            }
        }

        private void btn_Start_Click(object sender, EventArgs e) {
            btn_Start.Enabled = false;
            InitializeKinect();
            btn_Stop.Enabled = true;
        }

        private void btn_Stop_Click(object sender, EventArgs e) {
            btn_Stop.Enabled = false;
            kS.Close();
            InitializeVar();
            btn_Start.Enabled = true;
        }
    }
}
