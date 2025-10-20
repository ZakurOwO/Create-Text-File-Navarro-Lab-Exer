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
    public partial class NewRegistration : Form
    {
        public NewRegistration()
        {
            InitializeComponent();
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

            string[] info =
            {
                "Student Number: " + studentNo,
                "Last Name: " + lastName,
                "First Name: " + firstName,
                "Middle Initial: " + middleInitial,
                "Age: " + age,
                "Gender: " + gender,
                "Course: " + course,
                "Contact Number: " + contact,
                "Birthdate: " + birthdate
            };

            string relativePath = @"..\..\Navarro_John_Daniel_LabStream";
            string docPath = Path.GetFullPath(relativePath);

            if (!Directory.Exists(docPath))
                Directory.CreateDirectory(docPath);

            string filePath = Path.Combine(docPath, studentNo + ".txt");

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (string line in info)
                    outputFile.WriteLine(line);
            }

            MessageBox.Show("File Created Successfully!\n" + filePath, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmStudentRecord frm = new FrmStudentRecord();
            frm.LoadStudentRecord(filePath);
            frm.Show();
            this.Hide();
        }





        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void BirthdayPicking_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NewRegistration_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRecord_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frm2 = new FrmStudentRecord();
            frm2.Show();
            this.Hide();
        }

        private void txtProgram_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProgram_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
