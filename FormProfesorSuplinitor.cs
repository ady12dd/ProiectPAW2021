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
    public partial class FormProfesorSuplinitor : Form
    {
        Profesor suplinitor;
        public FormProfesorSuplinitor(Profesor suplinitor)
        {
            InitializeComponent();
            this.suplinitor = suplinitor;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            suplinitor.Nume = tbNumeSup.Text;
            suplinitor.Grad = tbGradSup.Text;
            int varsta = 0;
            int.TryParse(tbVarstaSup.Text,out int varstsa);
            suplinitor.Varsta = varsta;
            suplinitor.Disciplina = new Disciplina(tbDisciplinaSup.Text, "");

        }
    }
}
