using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrotA_InfoTest
{
    public partial class Form1 : Form
    {
        List<CrotA_Candidato> CrotA_memoria;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void aggiungi(CrotA_Candidato el)
        {
            if (el == null)
            {
                throw new Exception("l'elemento è nullo");
            }
            else
            {
                CrotA_memoria.Add(el);
            }

        }
        public void visualizza()
        {
            foreach (ListViewItem oggetto in listView1.Items)
            {
                Console.WriteLine(oggetto.Text);
            }

        }
        public void modifica(string nome, string matricola)
        {


            for (int i = 0; i < CrotA_memoria.Count; i++)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem oggetto = listView1.SelectedItems[i];
                    oggetto.SubItems[i].Text = nome;
                    oggetto.SubItems[i].Text = matricola;
                }
            }



        }
        public void elimina()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem oggetto = listView1.SelectedItems[0];
                listView1.Items.Remove(oggetto);
            }
            else
            {
                throw new Exception("item non selezionato");
            }
        }
        public void visualizzaIdonei()
        {
          
        }

    }
}
