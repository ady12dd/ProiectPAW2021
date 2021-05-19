using System;
using System.Collections.Generic;

namespace Elaborare_orarii_profesori.Clase
{
    [Serializable]
    public class Profesor : IComparable<Profesor>
    {
        private string numeProfesor;
        private string grad;
        private int varsta;
        private string sex;
        private Disciplina disciplina;
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

        public Profesor(string numeProfesor, string grad, int varsta, Disciplina disciplina)
        {
            this.numeProfesor = numeProfesor;
            this.grad = grad;
            this.varsta = varsta;
            this.disciplina = disciplina;
        }

        public string Nume { get => numeProfesor; set => numeProfesor = value; }
        public string Grad { get => grad; set => grad = value; }
        public int Varsta { get => varsta; set => varsta = value; }
        public string Sex { get => sex; set => sex = value; }
        internal List<ZiSaptamana> ZileSaptamana { get => zileSaptamana; set => zileSaptamana = value; }
        internal Disciplina Disciplina { get => disciplina; set => disciplina = value; }

        public int CompareTo(Profesor other)
        {
            return Varsta.CompareTo(other.Varsta);
        }

        public override string ToString()
        {
            return $"Profesorul cu numele {numeProfesor} are gradul {grad} are varsta de {varsta} si este de sex {sex}";
        }
    }

    class ProfesorVarstaComparer : IComparer<Profesor>
    {
        public int Compare(Profesor x, Profesor y)
        {
            return x.Varsta.CompareTo(y.Varsta);
        }
    }
}
