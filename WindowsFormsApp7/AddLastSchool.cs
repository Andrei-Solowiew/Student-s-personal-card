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
    public partial class AddLastSchool : Form
    {
        public static string connectsString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=БД3.mdb";
        private OleDbConnection myConnection;
        public AddLastSchool()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectsString);
            myConnection.Open();
        }

        private void AddLastSchool_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД3DataSet.Данные_о_прошлом_УЗ". При необходимости она может быть перемещена или удалена.
            this.данные_о_прошлом_УЗTableAdapter.Fill(this.бД3DataSet.Данные_о_прошлом_УЗ);

        }

        private void AddLastSchool_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            e.Cancel = true;
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int kod_last = Convert.ToInt32(textBoxKodLast.Text);
            string level = textBoxEdLevel.Text;
            string uz = textBoxUZ.Text;
            string year = textBoxYear.Text;
            int kod_student = Convert.ToInt32(textBoxKodStudent.Text);
            string query = "INSERT INTO [Данные о прошлом УЗ] ([Код контактных данных о прошлом УЗ], [Уровень образования], [Учебное заведение(УЗ)], [Год окончания УЗ], [Код студента]) VALUES(" + kod_last + ",'" + level + "','" + uz + "','" + year + "','" + kod_student + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлены");
            this.данные_о_прошлом_УЗTableAdapter.Fill(this.бД3DataSet.Данные_о_прошлом_УЗ);
        }
    }
}
