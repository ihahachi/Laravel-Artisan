using System;
using System.IO;
using System.Windows.Forms;


namespace CMDLine
{
    
    public partial class Form1 : Form
    {
        public void artisan(string cmd)
        {
            System.Diagnostics.Process.Start("cmd", "/c php artisan " + cmd);
        }

        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c composer global require ''laravel / installer''");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string PathLocal = textPath.Text;
            PathLocal = PathLocal .Replace (@"\","/");
             System.Diagnostics.Process.Start("cmd", "/c composer create-project --prefer-dist laravel/laravel " + PathLocal);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string PathLocal = textPath.Text;
            PathLocal = PathLocal.Replace(@"\", "/");
            System.Diagnostics.Process.Start("cmd", "/c composer create-project --prefer-dist laravel/laravel  " + PathLocal + " ''" + Version .Text + "''");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://127.0.0.1:8000";
            System.Diagnostics.Process.Start(url);         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            artisan("down");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            artisan("up");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            artisan("make:controller " + NameObj.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textPath.Text = Properties.Settings.Default.path;
        }


        private void button9_Click(object sender, EventArgs e)
        {
            artisan("make:job");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            artisan("make:model " + NameObj.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string PathLocal = textPath.Text;
            PathLocal = PathLocal.Replace(@"\", "/");
            System.Diagnostics.Process.Start("cmd", "cd " + PathLocal);
            //artisan("serve");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabTools;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSetting;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabHome;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabHome;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabNew;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabHome;
        }

        private void browser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textPath.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.path = textPath.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
