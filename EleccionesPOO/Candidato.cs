using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionesPOO
{
    public class Candidato
    {
        public int Numero { get; set; }
        public int Votos { get; set; }

        public Candidato(int numero, int votos)
        {
            Numero = numero;
            Votos = votos;
        }
    }
}
