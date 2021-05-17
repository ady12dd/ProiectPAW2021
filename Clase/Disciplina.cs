using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaborare_orarii_profesori.Clase
{
    [Serializable]
    class Disciplina
    {
        private string numeDisciplina;
        private string tipEvaluare;

        public string NumeDisciplina { get => numeDisciplina; set => numeDisciplina = value; }

        public string TipEvaluare { get => tipEvaluare; set => tipEvaluare = value; }

        public Disciplina(string numeDisciplina, string tipEvaluare)
        {
            this.numeDisciplina = numeDisciplina;
            this.tipEvaluare = tipEvaluare;
        }

        public override string ToString()
        {
            return $"Disciplina cu numele{numeDisciplina} are ca tip de evaluare{tipEvaluare}";
        }
    }
}
