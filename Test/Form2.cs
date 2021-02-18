using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Test_Form : Form
    {
        public Test_Form()
        {
            InitializeComponent();
        }
        int score = 0;
        int quastion = 0;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Yes_bt_Click(object sender, EventArgs e)
        {
            score++;
            quastion++;
            string Path = @"D:\Test_result.txt";
            StreamWriter sw = new StreamWriter(Path, false, System.Text.Encoding.Default);

            if (quastion == 1)
            {
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = false;
            }
            else if (quastion == 2)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
            }
            else if (quastion == 3)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                if (score == 1 || score == 0)
                {
                    FileStream fs = null;
                    label6.Visible = true;
                    StreamWriter writer = new StreamWriter(fs);
                    string text_result = "Huu...A oy Figovo";
                    writer.Write(text_result, false);
                }
                else if (score == 2)
                {
                    FileStream fs = null;
                    label7.Visible = true;
                    StreamWriter writer = new StreamWriter(fs);
                    string text_result = "Ok";
                    writer.Write(text_result, false);
                }
                else if (score == 3)
                {
                    FileStream fs = null;
                    label8.Visible = true;
                    StreamWriter writer = new StreamWriter(fs);
                    string text_result = "Ouuu My";
                    writer.Write(text_result, false);
                }
                Yes_bt.Visible = false;
                No_bt.Visible = false;
            }
            else if (quastion == 0)
            {
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
            }
        }

        private void No_bt_Click(object sender, EventArgs e)
        {
            quastion++;
            if (quastion == 1)
            {
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = false;
            }
            else if (quastion == 2)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
            }
            else if (quastion == 3)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                if (score == 1 || score == 0)
                {
                    FileStream fs = null;
                    label6.Visible = true;
                    StreamWriter writer = new StreamWriter(fs);
                    string text_result = "Huu...A oy Figovo";
                    writer.Write(text_result, false);
                }
                else if (score == 2)
                {
                    FileStream fs = null;
                    label7.Visible = true;
                    StreamWriter writer = new StreamWriter(fs);
                    string text_result = "Ok";
                    writer.Write(text_result, false);
                }
                else if (score == 3)
                {
                    FileStream fs = null;
                    label8.Visible = true;
                    StreamWriter writer = new StreamWriter(fs);
                    string text_result = "Ouuuu My";
                    writer.Write(text_result, false);
                }
                Yes_bt.Visible = false;
                No_bt.Visible = false;
            }
            else if (quastion == 0)
            {
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
