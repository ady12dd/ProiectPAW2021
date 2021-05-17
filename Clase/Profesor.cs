using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaborare_orarii_profesori.Clase
{
  public  class Profesor
    {
        private string numeProfesor;
        private string grad;
        private int varsta;
        private string sex;
        private List<ZiSaptamana> zileSaptamana;


        public Profesor()
        {
        }

        public Profesor(string nume, string grad, int varsta, string sex)
        {
            this.Nume = nume;
            this.Grad = grad;
            this.Varsta = varsta;
            this.Sex = sex;
            this.ZileSaptamana = new List<ZiSaptamana>();
        }

        public string Nume { get => numeProfesor; set => numeProfesor = value; }
        public string Grad { get => grad; set => grad = value; }
        public int Varsta { get => varsta; set => varsta = value; }
        public string Sex { get => sex; set => sex = value; }
        internal List<ZiSaptamana> ZileSaptamana { get => zileSaptamana; set => zileSaptamana = value; }

        public override string ToString()
        {
            return $"Profesorul cu numele {numeProfesor} are gradul {grad} are varsta de {varsta} si este de sex {sex}";
        }
    }
}
