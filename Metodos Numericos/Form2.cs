using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Expressions;

namespace Metodos_Numericos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(txtX1.Text);
            double b = Double.Parse(txtX2.Text);
            for (int i = 0; i < 5; i++)
            {
                double m = (a + b) / 2;
                String fa = tbFx.Text;
                String fb = tbFx.Text;
                String fm = tbFx.Text;
                double faRes = Eval.Execute<double>(fa, new { x = a });
                double fbRes = Eval.Execute<double>(fb, new { x = b });
                double fmRes = Eval.Execute<double>(fa, new { x = m });
                if ((a > 0 && m < 0) || (a < 0 && m > 0))
                {
                    b = m;
                }
                if ((m < 0 && b > 0) || (m > 0 && b < 0))
                {
                    a = m;
                }
                dgb.Rows.Add((i+1), fmRes, faRes, fbRes, a + "," + b);
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "7";
        }

        private void bPun_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + ".";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "0";
        }

        private void bX_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "x";
        }

        private void bSum_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "+";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "3";
        }

        private void bRes_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "-";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "6";
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "*";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            tbFx.Text = tbFx.Text + "9";
        }

        private void bElevar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favor de colocarlo como multiplicacion ej x^3 == x*x*x");
        }

        private void bSup_Click(object sender, EventArgs e)
        {
            if(tbFx.Text.Length>0)
            tbFx.Text=tbFx.Text.Substring(0,tbFx.Text.Length-1);
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Visible = true;
        }
    }
}
