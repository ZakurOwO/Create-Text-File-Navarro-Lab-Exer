using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Text_File_Navarro_Lab_Exer
{
    public partial class Form2 : Form
    {
        public static string SetFileName;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt";

            this.Close();
        }
    }
}
