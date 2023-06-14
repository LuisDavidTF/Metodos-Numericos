using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Numericos
{
    public partial class FormSimpson : Form
    {
        public FormSimpson()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            tbRes.Text=Iteraciones.Simpson(Double.Parse(txtA.Text), Double.Parse(txtB.Text), Double.Parse(txtParticiones.Text)).ToString();
        }
    }
}
