using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Notes.ListDay
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        public Form1()
        {
            
            InitializeComponent();
        }

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


            string qerystring = $"Insert Into  Task1(Task, DataAndTime ) values('{_Task}','{_DataAndTime}')";
            SqlCommand Command = new SqlCommand(qerystring, dataBase.GetConnection());
            dataBase.OpenConnection();


            if (Command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные успешно добавлены!");

                //Операция перехода на форму вывода данных, после доюавления данных
                {
                    this.Hide();
                    ListDay.Form1DataOutput form1DataOutput = new Form1DataOutput();
                    form1DataOutput.Show();
                }
            }
            else
            {
                MessageBox.Show("Операция не выполнена попробуйте еще раз!");
            }
            


            dataBase.CloseConnection();
            Clear();
            
        }

        


       

          
    }
    
}

        
