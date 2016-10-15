﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospSys
{
    public partial class Examinations : Form
    {
        public Examinations()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.FontAwesome_f060_0__256;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.FontAwesome_f060_0__2561;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PanelWindow child = new PanelWindow();
            ActiveForm.Hide();
            child.Show();
        }

        private void pBInsert_MouseMove(object sender, MouseEventArgs e)
        {
            pBInsert.Size = new Size(135, 115);
            pBInsert.Location = new Point(73, 4);
        }

        private void pBInsert_MouseLeave(object sender, EventArgs e)
        {
            pBInsert.Size = new Size(127, 107);
            pBInsert.Location = new Point(75, 6);
        }

        private void pBViewPatients_MouseMove(object sender, MouseEventArgs e)
        {
            pBViewPatients.Size = new Size(135, 115);
            pBViewPatients.Location = new Point(73, 4);
        }

        private void pBViewPatients_MouseLeave(object sender, EventArgs e)
        {
            pBViewPatients.Size = new Size(127, 107);
            pBViewPatients.Location = new Point(75, 6);
        }
    }
}
