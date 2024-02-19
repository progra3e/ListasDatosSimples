using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasDatosSimples
{
    public partial class Form1 : Form
    {
        //Lista
        List<int> listaEnteros = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {                
            int numero = 0;
            bool seConvirtio = int.TryParse(textBoxNumero.Text, out numero);
            if (seConvirtio)
            {
                listaEnteros.Add(numero);
                Mostrar();
            }
            else
            {
                MessageBox.Show("Debe Ingresar un número");
            }
        }


        private void Mostrar()
        {
            //Funciona con: Combobox, Listbox, Datagridview
            listBoxMostrar.DataSource = null;
            listBoxMostrar.Refresh();
            listBoxMostrar.DataSource = listaEnteros;
        }
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();                    
        }
        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            listaEnteros.Sort();
            Mostrar();
        }

        private void buttonDescendente_Click(object sender, EventArgs e)
        {
            listaEnteros.Sort();
            listaEnteros.Reverse();
            Mostrar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {            
            int numero = 0;            
            bool seConvirtio = int.TryParse(textBoxNumero.Text, out numero);            
            if (seConvirtio) 
            {
                listaEnteros.Remove(numero);                
                Mostrar();
            }
            else
            {
                MessageBox.Show("Debe Ingresar un número");
            }

        }
    }
}
