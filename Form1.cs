using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.CompilerServices.RuntimeHelpers;
namespace oyutnii_burtgel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            clbSubjects.SetItemChecked(0, true);
            clbSubjects.SetItemChecked(1, true);
            treeDepartments.Nodes.Clear();

            TreeNode computer = treeDepartments.Nodes.Add("Компьютерийн ухаан");
            computer.Nodes.Add("Мэдээллийн технологи");
            computer.Nodes.Add("Програм хангамж");

            TreeNode natural = treeDepartments.Nodes.Add("Байгалийн ухааны сургууль");
            natural.Nodes.Add("Математик");
            natural.Nodes.Add("Физик");

            treeDepartments.ExpandAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Оюутны код
            string code = txtCode.Text;

            // Утас
            string phone = txtPhone.Text;

            // Нас
            int age = (int)numAge.Value;

            // Тэнхим
            string department = cmbDepartment.Text;

            // Төрсөн өдөр
            string birthDate = dtpBirth.Value.ToString("yyyy-MM-dd");

            // Сургалт
            string studyType;

            if (rdoDay.Checked)
                studyType = "Өдрийн";
            else
                studyType = "Оройн";

            // Тэтгэлэг
            string scholarship;

            if (chkScholarship.Checked)
                scholarship = "Тийм";
            else
                scholarship = "Үгүй";

            // Хэл
            string language = "";

            if (lstLanguage.SelectedItem != null)
                language = lstLanguage.SelectedItem.ToString();

            // Хичээл
            string subjects = "";

            foreach (var item in clbSubjects.CheckedItems)
            {
                if (subjects != "")
                    subjects += ", ";

                subjects += item.ToString();
            }

            // ОЮУТНЫ БҮРТГЭЛ
            lblStudentInfo.Text =
                "ОЮУТНЫ БҮРТГЭЛ\r\n\r\n" +
                "Код: " + code + "\r\n" +
                "Утас: " + phone + "\r\n" +
                "Нас: " + age + "\r\n" +
                "Төрсөн өдөр: " + birthDate + "\r\n" +
                "Сургалт: " + studyType + "\r\n" +
                "Тэнхим: " + department + "\r\n" +
                "Тэтгэлэг: " + scholarship + "\r\n" +
                "Хичээл: " + subjects + "\r\n" +
                "Хэл: " + language;
            dgvStudents.Rows.Add(code, phone, age);
            lblTotal.Text = "Нийт: " + (dgvStudents.Rows.Count - 1);
        }

        private void clbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbSubjects_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void treeDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    } 
}
