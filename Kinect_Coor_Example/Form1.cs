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
        /*List<String> XTextBoxes = null;
        List<String> YTextBoxes = null;
        List<String> ZTextBoxes = null;*/

        public DataCollector() {
            InitializeComponent();
            InitializeKinect();
        }

        public void InitializeKinect() {
            kS = KinectSensor.GetDefault();
            bFR = kS.BodyFrameSource.OpenReader();
            FilePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + ".csv";
            csv = new StringBuilder();
            /*XTextBoxes = GetTextBoxes("_X");
            YTextBoxes = GetTextBoxes("_Y");
            ZTextBoxes = GetTextBoxes("_Z");
            Console.WriteLine(FilePath);
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
                bFR.FrameArrived += Reader_FrameArrived;
            }
        }

        /*private void FrameArrived(object sender, ColorFrameArrivedEventArgs args){
            using (var frame = args.FrameReference.AcquireFrame()){
                double fps = 1.0 / frame.ColorCameraSettings.FrameInterval.TotalSeconds;
                Console.WriteLine(fps);
            }
        }

        public List<String> GetTextBoxes(String S){
            List<String> temp = new List<String>();
            foreach (Control X in this.Controls){
                if (X is TextBox && X.Name.Contains(S)){
                    temp.Add(X.Name);
                }
            }
            temp.Sort();
            return temp;
        }*/

        private void Reader_FrameArrived(object sender, BodyFrameArrivedEventArgs e)
        {
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
                            /*TextBox temp1 = this.Controls.Find(XTextBoxes[i].ToString(), true).FirstOrDefault() as TextBox;
                            TextBox temp2 = this.Controls.Find(YTextBoxes[i].ToString(), true).FirstOrDefault() as TextBox;
                            TextBox temp3 = this.Controls.Find(ZTextBoxes[i].ToString(), true).FirstOrDefault() as TextBox;
                            temp1.Text = jointData[i].Position.X.ToString("#.###");
                            temp2.Text = jointData[i].Position.Y.ToString("#.###");
                            temp3.Text = jointData[i].Position.Z.ToString("#.###");*/
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
    }
}
