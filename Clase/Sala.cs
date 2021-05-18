using System;

namespace Elaborare_orarii_profesori.Clase
{
    [Serializable]
    class Sala
    {
        private string numar;
        private string numeSala;

        public string Numar { get => numar; set => numar = value; }

        public string Nume { get => numeSala; set => numeSala = value; }

        public Sala(String numar, string nume)
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
