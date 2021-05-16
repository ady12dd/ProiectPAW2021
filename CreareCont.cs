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
        public FormCreareCont()
        {
            InitializeComponent();
        }

        private void FormCreareCont_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btnSalvareInFisier_Click(object sender, EventArgs e)
        {

            Database dataBaseObject = new Database();
            //inserare in baza de date
            using (dataBaseObject.myConnection)
            {
                string query = "INSERT INTO Utilizatori (Nume,Parola)"+ "values (@Nume,@Parola); ";
                SQLiteCommand myCommand = new SQLiteCommand(query, dataBaseObject.myConnection);
                dataBaseObject.myConnection.Open();
                if (tbUSerNamePass.Text.Length < 3 || tbUserNameCreate.Text.Length < 3)
                {
                    MessageBox.Show("Utilizatorul sau/si parola trebuie sa aiba minim 3 caractere","Error");
                }
                else
                {
                    myCommand.Parameters.AddWithValue("@Nume", tbUserNameCreate.Text);
                    myCommand.Parameters.AddWithValue("@Parola", tbUSerNamePass.Text);
                    var result = myCommand.ExecuteNonQuery();
                }
                dataBaseObject.myConnection.Close();

            }

            
        }
    }
}
