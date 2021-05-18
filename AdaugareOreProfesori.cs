using Elaborare_orarii_profesori.Clase;
using System;
using System.Windows.Forms;

namespace Elaborare_orarii_profesori
{
    public partial class AdaugareOreProfesoriForm : Form
    {
        private Profesor profesor;
        public AdaugareOreProfesoriForm(Profesor profesorPreluat)
        {
            InitializeComponent();
            this.profesor = profesorPreluat;
        }

        private void comboZiSaptamana_SelectedIndexChanged(object sender, EventArgs e)
        {
            selItem.Text = comboZiSaptamana.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sala sala = new Sala(tbNrSala.Text, comboNumeSala.Text);
                Disciplina disciplina = new Disciplina(tbNumeDisciplina.Text, tbEvaluare.Text);
                ZiSaptamana zi = new ZiSaptamana(comboZiSaptamana.Text, sala, disciplina, comboBox1.Text);
                profesor.ZileSaptamana.Add(zi);
            }
            catch
            {

                Console.WriteLine("Erroare la salvare orar");
            }
        }
    }
}
