using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaborare_orarii_profesori.Clase
{
    class Disciplina
    {
        private string numeDisciplina;
        private string arieDisciplina;
        private string tipEvaluare;

        public string NumeDisciplina { get => numeDisciplina; set => numeDisciplina = value; }
        public string ArieDisciplina { get => arieDisciplina; set => arieDisciplina = value; }
        public string TipEvaluare { get => tipEvaluare; set => tipEvaluare = value; }

        public Disciplina(string numeDisciplina, string arieDisciplina, string tipEvaluare)
        {
            this.numeDisciplina = numeDisciplina;
            this.arieDisciplina = arieDisciplina;
            this.tipEvaluare = tipEvaluare;
        }

        public Disciplina()
        {
        }

        public override string ToString()
        {
            return $"Disciplina cu numele{numeDisciplina} face parte din aria {arieDisciplina} si are ca tip de evaluare{tipEvaluare}";
        }
    }
}
