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
    public partial class LocatieControl : UserControl
    {
        public LocatieControl()
        {
            InitializeComponent();
        }

        public Facultate selectedFaculty
        {
            get {
                return (Facultate)comboLocatie.SelectedItem;
            }
        }
        private void LocatieControl_Load(object sender, EventArgs e)
        {
            List<Facultate> listaFacultati = new List<Facultate>();
            //setam valueMember si DisplayMember of comboBox
            listaFacultati.Add(new Facultate() { Nume = "ASE", Zona = "Bucuresti" });
            listaFacultati.Add(new Facultate() { Nume = "CarolDavila", Zona = "Bucuresti" });
            listaFacultati.Add(new Facultate() { Nume = "IonMincu", Zona = "Iasi" });
            listaFacultati.Add(new Facultate() { Nume = "FacultateaDePetrolSiGaze", Zona = "Prahova" });
            listaFacultati.Add(new Facultate() { Nume = "FacultateaDeConstructii", Zona = "Craiova" });
            listaFacultati.Add(new Facultate() { Nume = "Conservator", Zona = "Timisoara" });
            comboLocatie.DataSource = listaFacultati;
            comboLocatie.ValueMember = "Zona";
            comboLocatie.DisplayMember = "Nume";
        }
    }
}
