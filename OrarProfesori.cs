using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
            else
            {
                ListViewItem selectedItem = lvProfesori.SelectedItems[0];
                Profesor p = (Profesor)selectedItem.Tag;

                AdaugareOreProfesoriForm adaugareOreProfesoriForm = new AdaugareOreProfesoriForm(p);
                adaugareOreProfesoriForm.ShowDialog();
            }
        }

        private void afiseazaOrarProfesor(Profesor p)
        {
            lvOrar.Items.Clear();
            foreach (ZiSaptamana zi in p.ZileSaptamana)
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

        //de terminat
        private void editeazaProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvProfesori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati un profesor!!!");
            }
            else
            {
                ListViewItem selectedItem = lvProfesori.SelectedItems[0];
                Profesor p = (Profesor)selectedItem.Tag;

                tbNume.Text = p.Nume;
                tbGrad.Text = p.Grad;
                tbSex.Text = p.Sex;
                tbVarsta.Text = p.Varsta.ToString();


            }
        }

        private void serializeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = File.Create("serializare.bin"))
            {
                formatter.Serialize(fileStream, listaProfesori);
            }
        }

        private void deserializeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = File.OpenRead("serializare.bin"))
            {
                listaProfesori = (List<Profesor>)formatter.Deserialize(fileStream);
            }

            lvProfesori.Items.Clear();
            afiseazaProfesori();
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV | *.csv";
            saveFileDialog.Title = "Salvare ca";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    streamWriter.WriteLine("Nume Profesor,Grad,Varsta,Sex");
                    foreach (Profesor p in listaProfesori)
                    {
                        streamWriter.WriteLine($"{p.Nume},{p.Grad},{p.Varsta.ToString()},{p.Sex}");
                        streamWriter.WriteLine("Zi,NumeSala,NrSala,Disciplina,TipExamen,IntervalOrar,");
                        foreach (ZiSaptamana zi in p.ZileSaptamana)
                        {
                            streamWriter.WriteLine($"{zi.Nume},{zi.Sala.Nume},{zi.Sala.Numar.ToString()},{zi.Disciplina.NumeDisciplina},{zi.Disciplina.TipEvaluare},{zi.IntervalOrar}");
                        }
                    }
                }

            }

        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvProfesori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati un profesor!!!");
            }
            else
            {
                if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti inregistrarea?", "Stergere",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem selectedItem = lvProfesori.SelectedItems[0];
                    Profesor p = (Profesor)selectedItem.Tag;

                    listaProfesori.Remove(p);
                    afiseazaProfesori();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {

            ListViewItem selectedItem = lvProfesori.SelectedItems[0];
            Profesor p = (Profesor)selectedItem.Tag;
            p.Nume = tbNume.Text;
            p.Grad = tbGrad.Text;
            p.Sex = tbSex.Text;
            p.Varsta = int.Parse(tbVarsta.Text.ToString());
            afiseazaProfesori();

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Cooper", 12);
            
            int axaYProf = printDocument.DefaultPageSettings.Margins.Top;
            
            while (indexCurentProf < listaProfesori.Count)
            {
                //imprimare
                Profesor profesor = listaProfesori[indexCurentProf];
                e.Graphics.DrawString($"{profesor.Nume}  {profesor.Varsta}  {profesor.Grad } {profesor.Sex}", font,
                    Brushes.Blue, printDocument.DefaultPageSettings.Margins.Left, axaYProf);
             
                axaYProf += 20;
                //ca sa putem trece pe mai multe pagini
                if (axaYProf > e.MarginBounds.Height) {
                    e.HasMorePages = true;
                    break;
                }
                //incrementare indexCurent
                indexCurentProf++;
            }
        }
        int indexCurentProf = 0;
       
        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            indexCurentProf = 0;
            
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK) {
                printDocument.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvProfesori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati un profesor!!!");
            }
            else {
                ListViewItem selectedItem = lvProfesori.SelectedItems[0];
                Profesor p = (Profesor)selectedItem.Tag;
                string textComplet = $"{p.Nume},{p.Grad},{p.Varsta},{p.Sex} ";
                foreach (ZiSaptamana zi in p.ZileSaptamana) {
                    string textSapatamana = "";
                    textSapatamana = zi.Disciplina.ToString() + " "+zi.Sala.ToString() +" "+ zi.Nume +" "+ zi.IntervalOrar;
                    textComplet+= textSapatamana;
                }

                Clipboard.SetText(textComplet);
                
            }
        }
    }
}
