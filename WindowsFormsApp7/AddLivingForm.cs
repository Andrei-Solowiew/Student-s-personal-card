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
    public partial class AddLivingForm : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public AddLivingForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void AddLivingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Место_проживания_студента". При необходимости она может быть перемещена или удалена.
            this.место_проживания_студентаTableAdapter.Fill(this.бД3DataSet.Место_проживания_студента);

        }

        private void AddLivingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int kod_living = Convert.ToInt32(textBoxKodLiving.Text);
            string city = textBoxSity.Text;
            string street = textBoxStreet.Text;
            string house = textBoxHouse.Text;
            string flat = textBoxFlat.Text;
            int kod_student = Convert.ToInt32(textBoxKodStudent.Text);
            string query = "INSERT INTO [Место проживания студента] ([Код проживания], [Населенный пункт проживания], Улица, Дом, Квартира, [Код студента]) VALUES(" + kod_living + ",'" + city + "','" + street + "','" + house + "','" + flat + "','" + kod_student + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
            this.место_проживания_студентаTableAdapter.Fill(this.бД3DataSet.Место_проживания_студента);
        }
    }
}
