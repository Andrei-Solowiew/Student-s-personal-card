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
    public partial class AddRegistrationForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public AddRegistrationForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void AddRegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Место_регистрации_студента". При необходимости она может быть перемещена или удалена.
            this.место_регистрации_студентаTableAdapter.Fill(this.бД3DataSet.Место_регистрации_студента);

        }

        private void AddRegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int kod_registration = Convert.ToInt32(textBoxKodRegistration.Text);
            string city = textBoxSity.Text;
            string street = textBoxStreet.Text;
            string house = textBoxHouse.Text;
            string flat = textBoxFlat.Text;
            int kod_student = Convert.ToInt32(textBoxKodStudent.Text);
            string query = "INSERT INTO [Место регистрации студента] ([Код регистрации], [Населенный пункт регистрации], Улица, Дом, Квартира, [Код студента]) VALUES(" + kod_registration + ",'" + city + "','" + street + "','" + house + "','" + flat + "','" + kod_student + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
            this.место_регистрации_студентаTableAdapter.Fill(this.бД3DataSet.Место_регистрации_студента);
        }
    }
}
