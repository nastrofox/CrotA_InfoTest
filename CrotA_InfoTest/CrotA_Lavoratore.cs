using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrotA_InfoTest
{
    public class CrotA_Lavoratore:CrotA_Candidato
    {
        public int CrotA_esperienze;
        public int CrotA_Esperienze
        {
            get { return CrotA_esperienze; }
            set { if (value >= 0 && value <= 5)
                {
                    CrotA_esperienze = value;
                }
                
            }
        }
        public CrotA_Lavoratore():base()
        {
            CrotA_esperienze = 0;
        }
        public CrotA_Lavoratore(int crotA_esperienze, int crotA_Esperienze,int matricola,string nome):base(matricola,nome)
        {
            CrotA_Esperienze = crotA_esperienze;
        }
        public override int punteggio()
        {
            return 20 * CrotA_esperienze;
        }
        public override bool isIdoneo()
        {
            if(punteggio()>=60)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return CrotA_matricola + " " + CrotA_nome + " " + CrotA_esperienze ;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            CrotA_Lavoratore other = (CrotA_Lavoratore)obj;
            return CrotA_esperienze == other.CrotA_Esperienze;

        }
        public int CompareTo(CrotA_Lavoratore tmp)
        {
            return punteggio().CompareTo(tmp.punteggio());
        }
        public override int GetHashCode()
        {
            return CrotA_esperienze.GetHashCode();
        }
    }
}
