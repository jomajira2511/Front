using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCsharp.OperadoresAritmeticos
{
    public partial class FormOperadoresAritmeticos : Form
    {
        public FormOperadoresAritmeticos()
        {
            InitializeComponent();
        }

        int Numero1;
        int Numero2;
        int Resultado;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormOperadoresAritmeticos_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToInt32 (TxtNumero1.Text);
            Numero2 = Convert.ToInt32(TxtNumero2.Text);
            Resultado = Numero1 + Numero2;
            LblResultado.Text = Convert.ToString(Resultado);

        }
    }
}
