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
            int varsta = 0;
            int.TryParse(tbVarsta.Text, out varsta);
            string sex = tbSex.Text.Trim();

            bool formValid = true;
            string name = tbNume.Text.Trim();
            if (name.Length < 3)
            {
                errorProvider.SetError(tbNume, "Numele trebuie sa aiba mai mult de 3 litere");
                formValid = false;
            }

            string grad1 = tbGrad.Text.Trim();
            if (grad1.Length < 3)
            {
                errorProvider.SetError(tbGrad, "Gradul trebuie sa aiba mai mult de 3 litere");
                formValid = false;
            }

            int varsta1 = 0;
            int.TryParse(tbVarsta.Text, out varsta1);
            if (varsta < 20)
            {
                errorProvider.SetError(tbVarsta, "Varsta trebuie sa fie mai mare decat 20 de ani");
                formValid = false;
            }

            string sex1 = tbSex.Text.Trim();
            if (sex1.Length < 3)
            {
                errorProvider.SetError(tbNume, "Sexul trebuie sa aiba mai mult de 3 litere");
                formValid = false;
            }

            if (!formValid)
            {
                MessageBox.Show("Formularul contine erori!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Profesor profesor = new Profesor(nume, grad, varsta, sex);
            listaProfesori.Add(profesor);
            afiseazaProfesori();

        }

        private void afiseazaProfesori()
        {
            lvProfesori.Items.Clear();
            foreach (Profesor profesor in listaProfesori)
            {
                ListViewItem listViewItem = new ListViewItem(profesor.Nume);
                listViewItem.SubItems.Add(profesor.Grad);
                listViewItem.SubItems.Add(profesor.Varsta.ToString());
                listViewItem.SubItems.Add(profesor.Sex);
                listViewItem.Tag = profesor;
                lvProfesori.Items.Add(listViewItem);
            }
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            string name = tbNume.Text.Trim();
            if (name.Length < 3)
            {
                errorProvider.SetError(tbNume, "Numele trebuie sa aiba mai mult de 3 litere");
               
            }
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbNume, null);

        }

        private void tbVarsta_Validating(object sender, CancelEventArgs e)
        {
            int varsta = 0;
            int.TryParse(tbVarsta.Text, out varsta);
            if (varsta < 20)
            {
                errorProvider.SetError(tbVarsta, "Varsta trebuie sa fie mai mare decat 20 de ani");
                
            }

        }

        private void tbVarsta_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbVarsta, null);
        }

        private void tbGrad_Validating(object sender, CancelEventArgs e)
        {
            string grad = tbGrad.Text.Trim();
            if (grad.Length < 3)
            {
                errorProvider.SetError(tbGrad, "Gradul trebuie sa aiba mai mult de 3 litere");

            }
        }

        private void tbGrad_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbGrad, null);
        }

        private void tbSex_Validating(object sender, CancelEventArgs e)
        {
            string sex = tbSex.Text.Trim();
            if (sex.Length < 3)
            {
                errorProvider.SetError(tbSex, "Sexul trebuie sa aiba mai mult de 3 litere");

            }
        }

        private void tbSex_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbSex, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrarProfesoriForm_Load(object sender, EventArgs e)
        {
            tbNume.Select();
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvProfesori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati un profesor!!!");
            }
            else {
                ListViewItem selectedItem = lvProfesori.SelectedItems[0];
                Profesor p = (Profesor)selectedItem.Tag;

                AdaugareOreProfesoriForm adaugareOreProfesoriForm = new AdaugareOreProfesoriForm(p);
                adaugareOreProfesoriForm.ShowDialog();
            }
        }

        private void afiseazaOrarProfesor(Profesor p)
        {
            lvOrar.Items.Clear();
            foreach (ZiSaptamana zi in p.ZileSaptamana )
            {
                ListViewItem listViewItem = new ListViewItem(zi.Sala.Nume);
                listViewItem.SubItems.Add(zi.Nume);
                listViewItem.SubItems.Add(zi.Disciplina.NumeDisciplina);
                listViewItem.SubItems.Add(zi.IntervalOrar);
                lvOrar.Items.Add(listViewItem);
            }
        }

        private void afiseazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvProfesori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati un profesor!!!");
            }
            else
            {
                ListViewItem selectedItem = lvProfesori.SelectedItems[0];
                Profesor p = (Profesor)selectedItem.Tag;
                afiseazaOrarProfesor(p);
            }
        }
    }
}
