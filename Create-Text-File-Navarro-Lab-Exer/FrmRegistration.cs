using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Text_File_Navarro_Lab_Exer
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNumber.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string middleInitial = txtM.Text.Trim();
            string age = txtAge.Text.Trim();
            string gender = txtGender.Text.Trim();
            string course = txtProgram.Text.Trim();
            string contact = txtContactNo.Text.Trim();
            string birthdate = BirthdayPicking.Text.Trim();
            

            string fileName = studentNo + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
