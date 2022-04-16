using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes.ListDay.Task2
{
    public partial class Form2 : Form
    {
        DataBase dataBase = new DataBase();
        public Form2()
        {
            InitializeComponent();
            LoadData();
        }
        void QuerySQL(string str)
        {
            SqlConnection SQLconnection = new SqlConnection(@"Data Source=ARTEM-PC\SQLEXPRESS; Initial Catalog= ListToDataEveyDay; Integrated Security=True");
            dataBase.OpenConnection();

            SqlCommand Command = new SqlCommand(str, dataBase.GetConnection());
            SqlDataReader reader = Command.ExecuteReader();
            dataBase.CloseConnection();
        }

        private void LoadData()
        {
            SqlConnection SQLconnection = new SqlConnection(@"Data Source=ARTEM-PC\SQLEXPRESS; Initial Catalog= ListToDataEveyDay; Integrated Security=True");
            dataBase.OpenConnection();


            string qery = "Select * From Task2 Order by ID";
            SqlCommand command = new SqlCommand(qery, dataBase.GetConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();


            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

            }
            reader.Close();
            dataBase.CloseConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void ButtonDell_Click(object sender, EventArgs e)
        {
            string qerystring = "TRUNCATE TABLE Task2";
            QuerySQL(qerystring);
        }
    }
}
