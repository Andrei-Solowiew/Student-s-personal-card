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
    public partial class AddFamilyForm : Form
    {

        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public AddFamilyForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void AddFamilyForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Семья". При необходимости она может быть перемещена или удалена.
            this.семьяTableAdapter.Fill(this.бД3DataSet.Семья);

        }

        private void AddFamilyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int kod_family = Convert.ToInt32(textBoxKodFamily.Text);
            string completeness = textBoxCompleteness.Text;
            string reason = textBoxReason.Text;
            int children = Convert.ToInt32(textBoxChildren.Text);
            string data_children = textBoxDataChildren.Text;
            string place = textBoxPlace.Text;
            string today = textBoxToday.Text;
            int kod_student = Convert.ToInt32(textBoxKodStudenta.Text);
            string query = "INSERT INTO Семья ([Код семьи], [Полная ли семья], [Причина неполноты семьи], [Количество детей], [Дата рождения каждого], [Где живут(дом, квартира)], [Сегодняшняя дата] , [Код студента]) VALUES(" + kod_family + ",'" + completeness + "','" + reason + "','" + children + "','" + data_children + "','" + place + "','" + today + "','" + kod_student + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
            this.семьяTableAdapter.Fill(this.бД3DataSet.Семья);
        }

        
    }
}
