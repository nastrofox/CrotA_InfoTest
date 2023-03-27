using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrotA_InfoTest
{
    public class CrotA_Disoccupato : CrotA_Candidato
    {
        private int CrotA_voto;
        private bool CrotA_lode;
        public int CrotA_Voto
        {
            get { return CrotA_voto; }
            set 
            { 
                if(value>=0 && value<110 )
                    CrotA_voto = value;
            }
        }
        public bool CrotA_Lode
        {
            get { return CrotA_lode; }
            set { CrotA_Lode = value; }
        }
        public CrotA_Disoccupato():base()
        {
            CrotA_voto = 0;
            CrotA_lode = false;
        }
        public CrotA_Disoccupato(int voto, bool lode,int matricola,string nome):base(matricola,nome)
        {
            CrotA_Voto = voto;
            CrotA_Lode = lode;
        }
        public override int punteggio()
        {
            int tmp = (CrotA_voto * 100) / 110;
            if (CrotA_lode == true)
            {
                tmp = 5;
            }
            return tmp;
        }
        public override bool isIdoneo()
        {
            return this.punteggio() >= 72;
        }
        public override string ToString()
        {
            return CrotA_matricola + " " + CrotA_nome+" "+CrotA_voto+" "+CrotA_lode;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            CrotA_Disoccupato other = (CrotA_Disoccupato)obj;
            return CrotA_voto == other.CrotA_Voto && CrotA_lode == other.CrotA_Lode;

        }
        public int CompareTo(CrotA_Disoccupato tmp)
        {
            return punteggio().CompareTo(tmp.punteggio());
        }
        public override int GetHashCode()
        {
            return CrotA_voto.GetHashCode() + CrotA_lode.GetHashCode();
        }
    }
}
