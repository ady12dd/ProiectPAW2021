using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Elaborare_orarii_profesori.Clase;

namespace Elaborare_orarii_profesori
{
    public partial class FormLog : Form
    {
        private const string ConnectionString = "Data Source=database.db";
        public FormLog()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCreareCont creareForm = new FormCreareCont();
            creareForm.Show();

        }

        private void btnAcces_Click(object sender, EventArgs e)
        {
            if (tbUserNameLog.Text.Trim() == "" || tbPasswordLog.Text.Trim() == "")
            {
                MessageBox.Show("Campuri goale, va rugam sa reluati procesul", "Error");
            }
            else
            {

                using (SQLiteConnection myConnection = new SQLiteConnection(ConnectionString))
                {
                    myConnection.Open();
                    string query = "SELECT * FROM Utilizatori WHERE Nume=@Nume AND Parola=@Parola";

                    SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
                    myCommand.Parameters.AddWithValue("@Nume", tbUserNameLog.Text);
                    myCommand.Parameters.AddWithValue("@Parola", tbPasswordLog.Text);
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(myCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        OrarProfesori orarProfesori = new OrarProfesori();
                        orarProfesori.Show();
                      

                    }
                    else
                    {
                        MessageBox.Show("Logare esuata!!!", "Error");

                    }
                    
                }
            }
        }
    }
}
