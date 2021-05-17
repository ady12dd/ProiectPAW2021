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

namespace Elaborare_orarii_profesori
{
    public partial class OrarProfesoriForm : Form
        
    {
        private List<Profesor> listaProfesori;
        public OrarProfesoriForm()
        {
            InitializeComponent();
            this.listaProfesori = new List<Profesor>();
        }

        private void btnAdProf_Click(object sender, EventArgs e)
        {
            string nume = tbNume.Text.Trim();
            string grad = tbGrad.Text.Trim();
            int varsta = Int32.Parse(tbVarsta.Text.Trim());
            string sex = tbSex.Text.Trim();
            Profesor profesor = new Profesor(nume, grad, varsta, sex);
            listaProfesori.Add(profesor);
            afiseazaProfesori();

        }

        private void afiseazaProfesori() {
            lvProfesori.Items.Clear();
            foreach (Profesor profesor in listaProfesori) {
                ListViewItem listViewItem = new ListViewItem(profesor.Nume);
                listViewItem.SubItems.Add(profesor.Grad);
                listViewItem.SubItems.Add(profesor.Varsta.ToString());
                listViewItem.SubItems.Add(profesor.Sex);
                lvProfesori.Items.Add(listViewItem);
            }
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            string name = tbNume.Text.Trim();
            if (name.Length < 3) {
                errorProvider.SetError(tbNume, "Numele trebuie sa aiba mai mult de 3 litere");
                e.Cancel = true;
            }
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbNume, null);

        }

        private void tbVarsta_Validating(object sender, CancelEventArgs e)
        {
            int varsta = 0;
            int.TryParse(tbVarsta.Text,out varsta);
                if (varsta < 20)
                {
                    errorProvider.SetError(tbVarsta, "Varsta trebuie sa fie mai mare decat 20 de ani");
                    e.Cancel = true;
                }
            
            

        }

        private void tbVarsta_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbVarsta, null);
        }
    }
}
