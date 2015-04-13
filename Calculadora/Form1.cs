using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //variable que almacena el primer operando
        int operando1 = 0;
        int operando2 = 0;

        String operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Convierto el tipo genérico object a button
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                //añado el texto del botón pulsado al label
                label1.Text = boton.Text;
            }
            else {
                //añado el texto del botón pulsado al label
                label1.Text = label1.Text + boton.Text;
            }
        }
    }
}
