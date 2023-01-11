using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    public class Aluno
    {
        public string Nome;
        public float NotaA;
        public float NotaB;
        public float NotaC;

        public float NotaFinal()
        {
            return NotaA + NotaB + NotaC;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public float Restante()
        {
            if (Aprovado())
            {
                return 0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }
    }
}
