﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Freeplay fp = new Freeplay();
            fp.Show();
        }

        private void Randomness_Click(object sender, EventArgs e)
        {
            Randomness randomness = new Randomness();
            randomness.Show();
        }

        private void Song1_Click(object sender, EventArgs e)
        {
            Song1 song1 = new Song1();
            song1.Show();
        }

        private void Song2_Click(object sender, EventArgs e)
        {
            Song2 song2 = new Song2();
            song2.Show();
        }

        private void Song3_Click(object sender, EventArgs e)
        {
            Song3 song3 = new Song3();
            song3.Show();
        }

        private void Song4_Click(object sender, EventArgs e)
        {
            Song4 song4 = new Song4();
            song4.Show();
        }
    }
}
