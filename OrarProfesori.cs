using Elaborare_orarii_profesori.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Elaborare_orarii_profesori
{
    public partial class OrarProfesoriForm : Form

    {
        private List<Profesor> listaProfesori;
        private List<Profesor> suplinitori;
        private List<Profesor> suplinitoriSortatCriteriu;

        private const string ConnectionString2 = "Data Source=database2.db";
        public OrarProfesoriForm()
        {
            InitializeComponent();
            this.listaProfesori = new List<Profesor>();
            suplinitori = new List<Profesor>();
            suplinitoriSortatCriteriu = new List<Profesor>();

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
            tbNume.Clear();
            tbGrad.Clear();
            tbSex.Clear();
            tbVarsta.Clear();
            listaProfesori.Add(profesor);
            afiseazaProfesori();

        }

        private void afiseazaProfSuplinitori()
        {

            lvProfDisciplina.Items.Clear();
            foreach (Profesor p in suplinitori)
            {
                ListViewItem listViewItem = new ListViewItem(p.Id.ToString());
                listViewItem.SubItems.Add(p.Nume);
                listViewItem.SubItems.Add(p.Disciplina.NumeDisciplina);
                listViewItem.Tag = p;
                lvProfDisciplina.Items.Add(listViewItem);
            }

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
            incarcaListaProfesoriSuplinitori();
            afiseazaProfSuplinitori();

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
            if (lvProfesori.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvProfesori.SelectedItems[0];
                Profesor p = (Profesor)selectedItem.Tag;
                p.Nume = tbNume.Text;
                p.Grad = tbGrad.Text;
                p.Sex = tbSex.Text;
                p.Varsta = int.Parse(tbVarsta.Text.ToString());
                afiseazaProfesori();
                tbNume.Clear();
                tbGrad.Clear();
                tbSex.Clear();
                tbVarsta.Clear();
            }
            else {
                MessageBox.Show("Selectati un profesor pentru a modifica");
            }

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
                if (axaYProf > e.MarginBounds.Height)
                {
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
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void btClipboard_Click(object sender, EventArgs e)
        {
            if (lvProfesori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati un profesor!!!");
            }
            else
            {
                ListViewItem selectedItem = lvProfesori.SelectedItems[0];
                Profesor p = (Profesor)selectedItem.Tag;
                string textComplet = $"{p.Nume},{p.Grad},{p.Varsta},{p.Sex} ";
                foreach (ZiSaptamana zi in p.ZileSaptamana)
                {
                    string textSapatamana = "";
                    textSapatamana = zi.Disciplina.ToString() + " " + zi.Sala.ToString() + " " + zi.Nume + " " + zi.IntervalOrar;
                    textComplet += textSapatamana;
                }

                Clipboard.SetText(textComplet);

            }
        }

        private void btPremiu_Click(object sender, EventArgs e)
        {
            listaProfesori.Sort(new ProfesorVarstaComparer());
            Profesor p = listaProfesori.Last();
            tbDragAndDrop.Text = p.ToString();

        }

        private void tbDragAndDrop_MouseDown(object sender, MouseEventArgs e)
        {
            tbDragAndDrop.DoDragDrop(tbDragAndDrop.Text, DragDropEffects.Copy);
        }



        private void stergereProfesorSuplinitor(Profesor profesor)
        {

            const string query = "DELETE FROM Profesori WHERE Id=@Id";
            using (SQLiteConnection connnection = new SQLiteConnection(ConnectionString2))
            {
                connnection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connnection);
                command.Parameters.AddWithValue("@Id", profesor.Id);
                command.ExecuteNonQuery();
                suplinitori.Remove(profesor);
            }

        }

        private void incarcaListaProfesoriSuplinitori()
        {
            string query = "SELECT * FROM Profesori";
            using (SQLiteConnection connnection = new SQLiteConnection(ConnectionString2))
            {
                connnection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connnection);
                SQLiteDataReader sqlDataReader = command.ExecuteReader();
                try
                {
                    while (sqlDataReader.Read())
                    {

                        Profesor profesor = new Profesor(
                           (long)sqlDataReader["Id"],
                            sqlDataReader["Nume"].ToString(),
                            sqlDataReader["Grad"].ToString(),
                            int.Parse(sqlDataReader["Varsta"].ToString()),
                            new Disciplina(sqlDataReader["Disciplina"].ToString(), "")
                            );
                        suplinitori.Add(profesor);
                    }
                }
                finally
                {
                    sqlDataReader.Close();

                }
            }

        }

        private void adaugareProfesorSuplinitor(Profesor profesor)
        {
            string query = "INSERT INTO Profesori(Nume,Grad,Varsta,Disciplina)" +
                              " VALUES(@Nume,@Grad,@Varsta,@Disciplina);" + "SELECT last_insert_rowid()";
            using (SQLiteConnection connnection = new SQLiteConnection(ConnectionString2))
            {
                connnection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connnection);
                command.Parameters.AddWithValue("@Nume", profesor.Nume);
                command.Parameters.AddWithValue("@Grad", profesor.Grad);
                command.Parameters.AddWithValue("@Varsta", profesor.Varsta);
                command.Parameters.AddWithValue("@Disciplina", profesor.Disciplina.NumeDisciplina);

                profesor.Id = (long)command.ExecuteScalar();

                suplinitori.Add(profesor);
            }
        }

        private void adaugareSuplinitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesor suplinitor = new Profesor();
            FormProfesorSuplinitor form = new FormProfesorSuplinitor(suplinitor);
            if (form.ShowDialog() == DialogResult.OK)
            {

                adaugareProfesorSuplinitor(suplinitor);
                afiseazaProfSuplinitori();

            }

        }

        private void stergeSuplinitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvProfDisciplina.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alegeti un profesor suplinitor din lista");
                return;
            }
            else
            {
                ListViewItem suplinitorSelectat = lvProfDisciplina.SelectedItems[0];
                Profesor suplinitor = (Profesor)suplinitorSelectat.Tag;
                if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti profesorul suplinitor " + suplinitor.Nume, "Stergeti profesor suplinitor", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    stergereProfesorSuplinitor(suplinitor);
                    afiseazaProfSuplinitori();


                }
            }
        }

        private void modificaSuplinitorToolStripMenuItem_Click(object sender, EventArgs e)//de lucrat la el
        {
            if (lvProfDisciplina.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alegeti un profesor suplinitor din lista");
                return;
            }
            else
            {
                ListViewItem suplinitorSelectat = lvProfDisciplina.SelectedItems[0];
                Profesor suplinitor = (Profesor)suplinitorSelectat.Tag;
                FormProfesorSuplinitor form2 = new FormProfesorSuplinitor(suplinitor);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString2))
                    {
                        connection.Open();
                        string query = "UPDATE Profesori SET Nume=@Nume,Disciplina=@Disciplina WHERE Id = @Id";
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        command.Parameters.AddWithValue("@Id", suplinitor.Id);
                        command.Parameters.AddWithValue("@Nume", suplinitor.Nume);
                        command.Parameters.AddWithValue("@Disciplina", suplinitor.Disciplina.NumeDisciplina);
                        command.ExecuteNonQuery();

                        afiseazaProfSuplinitori();
                    }
                }


            }
        }

        private void sortarePeMaterieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Profesori WHERE Disciplina=@Disciplina";
            using (SQLiteConnection connnection = new SQLiteConnection(ConnectionString2))
            {
                connnection.Open();
               
                if (tbCriteriu.Text.ToString().Length > 3)
                {
                    SQLiteCommand command = new SQLiteCommand(query, connnection);
                    command.Parameters.AddWithValue("@Disciplina", tbCriteriu.Text.ToString());
                    SQLiteDataReader sqlDataReader = command.ExecuteReader();
                    try
                    {
                        while (sqlDataReader.Read())
                        {

                            Profesor profesor = new Profesor(
                               (long)sqlDataReader["Id"],
                                sqlDataReader["Nume"].ToString(),
                                sqlDataReader["Grad"].ToString(),
                                int.Parse(sqlDataReader["Varsta"].ToString()),
                                new Disciplina(sqlDataReader["Disciplina"].ToString(), "")
                                );
                            suplinitoriSortatCriteriu.Add(profesor);
                        }
                    }
                    finally
                    {
                        sqlDataReader.Close();

                    }

                    afiseazaProfSuplinitoriSortat();
                }
                else {
                    
                   
                    MessageBox.Show("Introduceti un criteriu");
                    
                }
            }
        }

        private void afiseazaProfSuplinitoriSortat()
        {
            lvProfDisciplina.Items.Clear();
            foreach (Profesor p in suplinitoriSortatCriteriu)
            {
                ListViewItem listViewItem = new ListViewItem(p.Id.ToString());
                listViewItem.SubItems.Add(p.Nume);
                listViewItem.SubItems.Add(p.Disciplina.NumeDisciplina);
                listViewItem.Tag = p;
                lvProfDisciplina.Items.Add(listViewItem);
            }
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            tbCriteriu.Clear();
            afiseazaProfSuplinitori();
        }
    }
}
