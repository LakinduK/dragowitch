using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demo
{
    public partial class Notification : Form
    {
       
        public Notification()
        {
            InitializeComponent();


        }

        private void Notification_Load(object sender, EventArgs e)
        {
            notifArray();
        }

        public void notifArray()
        {
            for(int i=2; i<10; i++)
            {
                Guna2Chip newChip = new Guna2Chip();
                newChip.Size = new Size (585,47);
                newChip.Text = " Notification text here. ("+ i.ToString()+")";
                
                newChip.TextAlign = (HorizontalAlignment)LeftRightAlignment.Left;
                newChip.FillColor = Color.CornflowerBlue;
                flowLayoutPanel1.Controls.Add(newChip);
            }
        }
    }
}
