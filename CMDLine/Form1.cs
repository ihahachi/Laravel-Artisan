using System;
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


        private void button1_Click(object sender, EventArgs e)
        {
            
            artisan("serve");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c composer global require ''laravel / installer''");
        }

        private void button3_Click(object sender, EventArgs e)
        {
                System.Diagnostics.Process.Start("cmd", "/c composer create-project --prefer-dist laravel/laravel " + NewText.Text);        
        }
        private void utton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c composer create-project --prefer-dist laravel/laravel  " + CurrentText.Text+ " ''" + Version .Text + "''");
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
          
        }

 

        private void button9_Click(object sender, EventArgs e)
        {
            artisan("make:job");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            artisan("make:model " + NameObj.Text);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            artisan("make:class " + NameObj.Text);
        }
    }
}
