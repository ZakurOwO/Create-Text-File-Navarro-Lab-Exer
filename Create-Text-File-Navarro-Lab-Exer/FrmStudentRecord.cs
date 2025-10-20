using System;
using System.IO;
using System.Windows.Forms;

namespace Create_Text_File_Navarro_Lab_Exer
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {
            lvShowText1.View = View.Details;
            lvShowText1.Columns.Clear();
            lvShowText1.Columns.Add("Student Records", 400);
        }

        public void LoadStudentRecord(string filePath)
        {
            lvShowText1.Items.Clear();

            if (File.Exists(filePath))
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                        lvShowText1.Items.Add(new ListViewItem(line));
                }
            }
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
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                LoadStudentRecord(openFileDialog1.FileName);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            NewRegistration frm = new NewRegistration();
            frm.Show();
            this.Hide();
        }
    }
}
