using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaborare_orarii_profesori.Clase
{
    class Sala
    {
        private int numar;
        private int etaj;
        private string numeSala;

        public int Numar { get => numar; set => numar = value; }
        public int Etaj { get => etaj; set => etaj = value; }
        public string Nume { get => numeSala; set => numeSala = value; }

        public Sala(int numar, int etaj, string nume)
        {
            this.numar = numar;
            this.etaj = etaj;
            this.numeSala = nume;
        }

        public Sala()
        {
        }

        public override string ToString()
        {
            return $"Sala cu numele {numeSala} este la etajul {etaj} si are numarul {numar}";
        }
    }
}
