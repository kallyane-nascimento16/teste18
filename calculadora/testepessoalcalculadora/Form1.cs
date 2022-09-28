using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testepessoalcalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void buttonsoma_Click(object sender, EventArgs e)
        {
            soma obs = new soma();
            obs.numero1=double.Parse(textBoxnumero1.Text);
            obs.numero2=double.Parse(textBoxnumero2.Text);
            obs.somar();

            labelresultado.Text = Convert.ToString(obs.somar());
        }
    }
}
