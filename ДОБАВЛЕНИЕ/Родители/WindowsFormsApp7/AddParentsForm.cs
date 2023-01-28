using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace WindowsFormsApp7
{
    public partial class AddParentsForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public AddParentsForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void AddParentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Родители". При необходимости она может быть перемещена или удалена.
            this.родителиTableAdapter.Fill(this.бД3DataSet.Родители);

        }

        private void AddParentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int kod_parents = Convert.ToInt32(textBoxKodParents.Text);
            string mom_surname = textBoxMomSurname.Text;
            string mom_name = textBoxMomName.Text;
            string mom_fathername = textBoxMomFathername.Text;
            string mom_work = textBoxMomWork.Text;
            string mom_post = textBoxMomPost.Text;
            string papa_surname = textBoxPapaSurname.Text;
            string papa_name = textBoxPapaName.Text;
            string papa_fathername = textBoxPapaFathername.Text;
            string papa_work = textBoxPapaWork.Text;
            string papa_post = textBoxPapaPost.Text;
            string mom_phone = textBoxMomPhone.Text;
            string papa_phone = textBoxPapaPhone.Text;
            string parents_mail = textBoxParentsMail.Text;
            string zp_surname = textBoxZpSurname.Text;
            string zp_name = textBoxZpName.Text;
            string zp_fathername = textBoxZpFathername.Text;
            string zp_phone = textBoxZpPhone.Text;
            string zp_work = textBoxZpWork.Text;
            string zp_post = textBoxZpPost.Text;
            string zp_mail = textBoxZpMail.Text;
            int kod_student = Convert.ToInt32(textBoxKodStudent.Text);
            string query = "INSERT INTO Родители ([Код родителей], [Фамилия матери], [Имя матери], [Отчество матери], [Место работы матери], [Должность матери] , [Фамилия отца] , [Имя отца] , [Отчество отца] , [Место работы отца] , [Должность отца] , [Телефон матери] , [Телефон отца] , [Почта родителей] , [Фамилия законного представителя(ЗП)] , [Имя зп] , [Отчество зп] , [Телефон зп] , [Место работы зп] , [Должность зп] , [Имейл зп] , [Код студента]) VALUES(" + kod_parents + ",'" + mom_surname + "','" + mom_name + "','" + mom_fathername + "','" + mom_work + "','" + mom_post + "','" + papa_surname + "','" + papa_name + "','" + papa_fathername + "','" + papa_work + "','" + papa_post + "','" + mom_phone + "','" + papa_phone + "','" + parents_mail + "','" + zp_surname + "','" + zp_name + "','" + zp_fathername + "','" + zp_phone + "','"  + zp_work + "','" + zp_post + "','" + zp_mail + "','" + kod_student + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
            this.родителиTableAdapter.Fill(this.бД3DataSet.Родители);
        }
    }
}
