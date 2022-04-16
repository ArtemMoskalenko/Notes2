using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notes.ListDay
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            QuerySQL();
        }
        DataBase dataBase = new DataBase();
        public void QuerySQL()
        {

            string query = "select 1 from Task1 where id = 1 ";
            string query1 = "select 1 from Task2 where id = 1 ";
            string query2 = "select 1 from Task3 where id = 1 ";


            SqlConnection SQLconnection = new SqlConnection(@"Data Source=ARTEM-PC\SQLEXPRESS; Initial Catalog= ListToDataEveyDay; Integrated Security=True");
            dataBase.OpenConnection();

            SqlCommand Command = new SqlCommand(query, dataBase.GetConnection());
            SqlDataReader _reader = Command.ExecuteReader();
            if (_reader.HasRows == true)
            {
                label13.Text = "Статус: Эсть задача";
            }
            else if (_reader.HasRows == false)
            {
                label13.Text = "Статус: Нет задачи";
            }
            dataBase.CloseConnection();
            dataBase.OpenConnection();
            SqlCommand _Command = new SqlCommand(query1, dataBase.GetConnection());
            SqlDataReader sqlDataReader = _Command.ExecuteReader();
            if (sqlDataReader.HasRows == true)
            {
                label4.Text = "Статус: Эсть задача";
            }
            else
            {
                label4.Text = "Статус: Нет задачи";
            }
            dataBase.CloseConnection();
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand(query2, dataBase.GetConnection());
            SqlDataReader sqlDataReader1 = command.ExecuteReader();
            if (sqlDataReader1.HasRows == true)
            {
                label5.Text = "Статус: Эсть задача";
            }
            else
            {
                label5.Text = "Статус: Нет задачи";
            }


            dataBase.CloseConnection();

        }
        private void ButtonListToDay_Click(object sender, EventArgs e)
        {

            // Переход на форму "Заметки".
            {
                this.Hide();
                NotesDay.NotesForm notesForm = new NotesDay.NotesForm();
                notesForm.Show();

            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            ListDay.Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListDay.Task2.Form1 form1 = new Task2.Form1();
            form1.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListDay.Task3.Form1 form1 = new Task3.Form1();
            form1.Show();
        }
    }
}
