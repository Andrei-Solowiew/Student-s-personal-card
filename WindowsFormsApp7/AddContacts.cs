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
    public partial class AddContactsForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public AddContactsForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void AddContacts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Контактные_данные_студента". При необходимости она может быть перемещена или удалена.
            this.контактные_данные_студентаTableAdapter1.Fill(this.бД3DataSet.Контактные_данные_студента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Контактные_данные_студента". При необходимости она может быть перемещена или удалена.
            this.контактные_данные_студентаTableAdapter.Fill(this._СР_5_ОПБД_Соловьев_Андрей_П9021DataSet.Контактные_данные_студента);

        }

        private void AddContactsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            double phone = Convert.ToDouble(textBoxPhone.Text);
            string mail = textBoxMail.Text;
            int kod_student = Convert.ToInt32(textBoxKodStudent.Text);
            string query = "INSERT INTO [Контактные данные студента] ([Телефон], [Код студента], [Имейл]) VALUES(" + phone + ",'" + kod_student + "','" +  mail + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
            this.контактные_данные_студентаTableAdapter1.Fill(this.бД3DataSet.Контактные_данные_студента);
        }
    }
}
