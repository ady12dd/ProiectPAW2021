using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elaborare_orarii_profesori.Clase;
using System.Data.SQLite;

namespace Elaborare_orarii_profesori
{
    public partial class FormCreareCont : Form
    {

        private const string ConnectionString = "Data Source=database.db";
        public FormCreareCont()
        {
            InitializeComponent();
        }

      

        private void btnSalvareInBazaDate_Click(object sender, EventArgs e)
        {   
            //inserare in baza de date
            using (SQLiteConnection myConnection = new SQLiteConnection(ConnectionString))
            {
                myConnection.Open();
                string query = "INSERT INTO Utilizatori (Nume,Parola)"+ "values (@Nume,@Parola); ";
                SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
                
                if (tbUSerNamePass.Text.Length < 3 || tbUserNameCreate.Text.Length < 3)
                {
                    MessageBox.Show("Utilizatorul sau/si parola trebuie sa aiba minim 3 caractere","Error");
                }
                else
                {
                    myCommand.Parameters.AddWithValue("@Nume", tbUserNameCreate.Text);
                    myCommand.Parameters.AddWithValue("@Parola", tbUSerNamePass.Text);
                    myCommand.ExecuteNonQuery();
                    

                }

                myConnection.Close();
                this.Close();
                
            }

        }

        private void tbUserNameCreate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Intoiduceti un nume de utilizator!!!";
        }

        private void tbUserNameCreate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void tbUSerNamePass_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Introduceti o parola pentru securizarea contului!!!";
        }

        private void tbUSerNamePass_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnSalvareInFisier_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Salvati contul in baza de date!!!";
        }

        private void btnSalvareInFisier_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void FormCreareCont_Load(object sender, EventArgs e)
        {
            tbUserNameCreate.Select();
        }
    }
}
