using System;

namespace Elaborare_orarii_profesori.Clase
{
    [Serializable]
    class ZiSaptamana
    {
        private String nume;
        private Sala sala;
        private Disciplina disciplina;
        private String intervalOrar;

        public Sala Sala { get => sala; set => sala = value; }
        public Disciplina Disciplina { get => disciplina; set => disciplina = value; }
        public string IntervalOrar { get => intervalOrar; set => intervalOrar = value; }
        public string Nume { get => nume; set => nume = value; }

        public ZiSaptamana(string nume, Sala sala, Disciplina disciplina, string intervalOrar)
        {
            Sala = sala;
            Disciplina = disciplina;
            IntervalOrar = intervalOrar;
            this.nume = nume;
        }


    }
}
