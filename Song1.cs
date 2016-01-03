using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;


using System.IO;
using Microsoft.Win32;

using Microsoft.Kinect;

namespace WindowsFormsApplication1
{
    /*Song based on the kick_snare_hithat1 file*/
    public partial class Song1 : Form
    {

        String rightHand = "Right Hand";
        String leftHand = "Left Hand";
        String kick = "Kick";
        int score = 0;
        int chancesLeft = 20;
        bool moved = true;
        int number = 0;

        public Song1()
        {
            InitializeComponent();
            DiscoverKinectSensor();
            this._Detector = new GestureDetector();
            this._Detector.GestureDetected += GesturHandler;
            beforeStart.Start();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (moved == false && chancesLeft != 0)
                chancesLeft--;
            if (chancesLeft == 0)
            {
                this.Close();
            }
            else
            {
                moved = false;
                if (number == 0)
                    whatMove.Text = rightHand;
                if (number == 1)
                    whatMove.Text = leftHand;
                if (number == 2)
                {
                    whatMove.Text = kick;
                    number = 0;
                }
                scoreLabel.Text = "Score: " + score;
                chancesLabel.Text = "Chances Left: " + chancesLeft;
                number++;
                timer2.Start();

            }
        }


        private void Song1_Load(object sender, EventArgs e)
        {

        }




        
        private KinectSensor _Sensor;
        private GestureDetector _Detector;


        #region Properties
        public KinectSensor Sensor
        {
            get { return this._Sensor; }
            set
            {
                if (this._Sensor != value && this._Sensor != null)
                {
                    uninitializeKinectSensor();
                    this._Sensor = null;
                }
                this._Sensor = value;
                initializeKinectSensor();
            }
        }
        #endregion Properties

        #region Methods
        private void DiscoverKinectSensor()
        {
            KinectSensor.KinectSensors.StatusChanged += KinectSensor_StatusChanged;
            foreach (var potentialSensor in KinectSensor.KinectSensors)
            {
                if (potentialSensor.Status == KinectStatus.Connected)
                {
                    this.Sensor = potentialSensor;
                    break;
                }
            }
            initializeKinectSensor();
        }
        private void initializeKinectSensor()
        {
            if (this.Sensor != null)
            {
                // Turn on the skeleton stream to receive skeleton frames
                this.Sensor.SkeletonStream.Enable();

                // Add an event handler to be called whenever there is new color frame data
                this.Sensor.SkeletonFrameReady += KinectSensor_SkeletonFrameReady;

                // Start the sensor!
                try
                {
                    this.Sensor.Start();
                }
                catch (IOException)
                {
                    this.Sensor = null;
                }
            }
        }
        private void uninitializeKinectSensor()
        {
            this.Sensor.Stop();
            this.Sensor.SkeletonFrameReady -= KinectSensor_SkeletonFrameReady;
            this.Sensor.SkeletonStream.Disable();
        }
        #endregion Methods

        #region UI Event Handlers
        private void button_Run_Click(object sender, System.EventArgs e)
        {
            DiscoverKinectSensor();
            this._Detector = new GestureDetector();
            this._Detector.GestureDetected += GesturHandler;

            // Setup a gesture detector and set its event handler

        }
        #endregion UIEvent Handlers

        #region Event Handlers
        private void KinectSensor_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            switch (e.Status)
            {
                case KinectStatus.Connected:
                    if (this.Sensor == null)
                    {
                        this.Sensor = e.Sensor;
                    }
                    break;

                case KinectStatus.Disconnected:
                    if (this.Sensor == e.Sensor)
                    {
                        this.Sensor = null;
                        this.Sensor = KinectSensor.KinectSensors.FirstOrDefault(x => x.Status == KinectStatus.Connected);
                    }
                    break;
            }
        }
        private void KinectSensor_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            Skeleton[] skeletons = new Skeleton[0];
            long timestamp = new long();

            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    skeletonFrame.CopySkeletonDataTo(skeletons);
                    timestamp = skeletonFrame.Timestamp;
                }
            }
            this._Detector.Update(skeletons, timestamp);
        }

        private void GesturHandler(object sender, EventArgs e)
        {
            switch (this._Detector.Gesture)
            {

                case 0:
                    break;
                case 1:
                    //"Left Hand Waved!"
                    break;
                case 2:
                    //"Right Hand Waved!"
                    break;
                case 3:
                    //"Left Hand Swiped!"
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = "snare1.wav";
                    player.Play();
                    moved = true;
                    if (whatMove.Text.Equals(leftHand))
                        score++;
                    else
                        chancesLeft--;

                    break;
                case 4:
                    //"Right Hand Swiped!"
                    System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
                    player2.SoundLocation = "hihat1.wav";
                    player2.Play();
                    moved = true;
                    if (whatMove.Text.Equals(rightHand))
                        score++;
                    else
                        chancesLeft--;

                    break;
                case 5:
                    //"Turn down Volume!"
                    break;
                case 6:
                    //"Turn up Volume!"
                    break;
                case 7:
                    //"Left Hand Punched!"
                    break;
                case 8:
                    //"Right Hand Punched!"
                    break;
                case 9:
                    //"Left Leg Kicked!"
                    System.Media.SoundPlayer player3 = new System.Media.SoundPlayer();
                    player3.SoundLocation = "kick1.wav";
                    player3.Play();
                    moved = true;
                    if (whatMove.Text.Equals(kick))
                        score++;
                    else
                        chancesLeft--;

                    break;
                case 10:
                    //"Right Leg Kicked!"
                    System.Media.SoundPlayer player4 = new System.Media.SoundPlayer();
                    player4.SoundLocation = "kick1.wav";
                    player4.Play();
                    moved = true;
                    if (whatMove.Text.Equals(kick))
                        score++;
                    else
                        chancesLeft--;

                    break;
                case 11:
                    //"Stop!"
                    break;
            }
        }
        #endregion Event Handlers

        private void beforeStart_Tick(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void chancesLabel_Click(object sender, EventArgs e)
        {

        }



    }
}
