using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrotA_InfoTest
{
    internal class CrotA_Candidato
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
        public abstract bool isIdoneo()
        {
            return false;
        }
        public abstract int punteggio()
        {
            return 0;
        }
    }
}
