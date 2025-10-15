using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Text_File_Navarro_Lab_Exer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();

            string getInput = txtinput.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, Form2.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);

                MessageBox.Show("File Created Successfully!" + docPath);
            }
        }
    }
}
