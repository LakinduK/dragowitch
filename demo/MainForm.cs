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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

// show/hide Menu Tabs Panel
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2TabControl1.TabMenuVisible ==true)
            {
                guna2TabControl1.TabMenuVisible = false;
                guna2Panel1.BackColor = Color.White;
                label1.ForeColor = Color.FromArgb(33, 42, 57);
            }
            else
            {
                guna2TabControl1.TabMenuVisible = true;
                guna2Panel1.BackColor = Color.FromArgb(33, 42, 57);
                label1.ForeColor = Color.White;
            }
                
        }

// Notifications number function
        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //UiChanges UiClass = new UiChanges();
            guna2NotificationPaint1.Text = guna2NumericUpDown1.Value.ToString();

            if (guna2NumericUpDown1.Value == 0)
            {
                guna2NotificationPaint1.Visible = false;
            }
            else if (guna2NumericUpDown1.Value < 5)
            {
                guna2NotificationPaint1.Visible = true;
                guna2NotificationPaint1.FillColor = Color.Orange;
            }
            else if (guna2NumericUpDown1.Value >= 5)
            {
                guna2NotificationPaint1.Visible = true;
                guna2NotificationPaint1.FillColor = Color.Red;
            }
        }
//  Show/Hide User Panel in Home
        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2TabControl1.SelectedIndex == 1)
            {
                guna2ContainerUserPanel.Visible = false;
            }
            else
            {
                guna2ContainerUserPanel.Visible = true;
            }
            
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    guna2CirclePictureBox1.ImageLocation = imageLocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
