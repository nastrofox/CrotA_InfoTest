using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrotA_InfoTest
{
    public abstract class CrotA_Candidato
    {
        public int CrotA_matricola;
        public string CrotA_nome;

        public CrotA_Candidato(int crotA_matricola, string crotA_nome)
        {
            this.CrotA_matricola = crotA_matricola;
            this.CrotA_nome = crotA_nome;
        }   
        public int crotA_matricola
        {
            set;get;
        }
        public int crotA_nome
        {
            set; get;
        }
        public CrotA_Candidato()
        {
            CrotA_matricola = 0;
            CrotA_nome = " ";
        }
        public CrotA_Candidato(int crotA_matricola)
        {
            this.CrotA_matricola = crotA_matricola;
        }
        public CrotA_Candidato(int crotA_matricola, string crotA_nome)
        {
            this.CrotA_matricola = 1;
            this.CrotA_nome = "nome";
        }
        public abstract bool isIdoneo();
        public abstract int punteggio();
        public override string ToString()
        {
            return CrotA_matricola + " " + CrotA_nome;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            CrotA_Candidato other = (CrotA_Candidato)obj;
            return CrotA_matricola == other.CrotA_matricola && CrotA_nome == other.CrotA_nome;
            
        }
        public int CompareTo(CrotA_Candidato tmp)
        {
            return punteggio().CompareTo(tmp.punteggio());
        }

        public override int GetHashCode()
        {
            return crotA_matricola.GetHashCode() + CrotA_nome.GetHashCode();
        }

    }
}
