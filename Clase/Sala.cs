using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaborare_orarii_profesori.Clase
{
    class Sala
    {
        private string numar;
        private string numeSala;

        public string Numar { get => numar; set => numar = value; }
       
        public string Nume { get => numeSala; set => numeSala = value; }

        public Sala(String numar, int etaj, string nume)
        {
            this.numar = numar;
            
            this.numeSala = nume;
        }

        public Sala()
        {
        }

        public override string ToString()
        {
            return $"Sala cu numele {numeSala}  are numarul {numar}";
        }
    }
}
