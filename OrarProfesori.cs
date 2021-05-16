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

        }
    }
}
