using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Start_form : Form
    {
        public Start_form()
        {
            InitializeComponent();
            form2 = new Test_Form();
        }
        Test_Form form2;
        private void Start_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
