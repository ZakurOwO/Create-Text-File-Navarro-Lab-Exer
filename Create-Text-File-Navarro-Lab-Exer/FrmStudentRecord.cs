using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Create_Text_File_Navarro_Lab_Exer
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Upload Successful!", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvShowText1.Items.Clear();
        }

        private void btnRegisterFind_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Find Student Text File";
            openFileDialog1.DefaultExt = "txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                lvShowText1.Items.Clear();

                using (System.IO.StreamReader streamReader = System.IO.File.OpenText(path))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        lvShowText1.Items.Add(new ListViewItem(line));
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration frm = new FrmRegistration();
            frm.Show();
            this.Hide();
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {
            lvShowText1.View = View.Details;
            lvShowText1.Columns.Clear();
            lvShowText1.Columns.Add("Student Records", 400);
        }
    }
}
