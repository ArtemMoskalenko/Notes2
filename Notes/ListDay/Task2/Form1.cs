using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notes.ListDay.Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListDay.Form2 form2 = new ListDay.Form2();
            form2.Show();
        }
        private void Clear()
        {
            textBoxTask.Text = " ";
            textBoxDaraAndTime.Text = " ";

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            textBoxDaraAndTime.MaxLength = 20;

            string _Task = textBoxTask.Text;
            string _DataAndTime = textBoxDaraAndTime.Text;


            string qerystring = $"Insert Into  Task2(Task, DataAndTime ) values('{_Task}','{_DataAndTime}')";
            SqlCommand Command = new SqlCommand(qerystring, dataBase.GetConnection());
            dataBase.OpenConnection();


            if (Command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные успешно добавлены!");

                //Операция перехода на форму вывода данных, после доюавления данных
                {
                    this.Hide();
                    ListDay.Task2.Form2 form2 = new Form2();
                    form2.Show();
                }
            }
            else
            {
                MessageBox.Show("Операция не выполнена попробуйте еще раз!");
            }



            dataBase.CloseConnection();
            Clear();
        }

        private void ButtonListToDay_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListDay.Form2 form2 = new ListDay.Form2();
            form2.Show();
        }
    }
}
