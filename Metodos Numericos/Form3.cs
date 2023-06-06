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
    public partial class Form3 : Form
    {
        public Form3()
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
            int n1 =Int16.Parse(txtN.Text);
            double a = Double.Parse(txtX1.Text);
            double b = Double.Parse(txtX2.Text);
            double iX = (b - a) / n1;
            double x=a+(0*iX);
            double y1 = Double.Parse(txtY1.Text);
            double fx= Eval.Execute<double>(tbFx.Text, new { y = y1, x = x });
            for (int i = 0; i < Int16.Parse(txtN.Text); i++) 
            {
                dgb.Rows.Add((i),(a+(i*iX)));
            }
            dgb2.Rows.Add((0), x,y1,tbFx.Text+ (Eval.Execute<double>(tbFx.Text, new { y = y1,x=x })));
            for (int i = 1; i < n1; i++)
            {
                y1 = y1 + (iX * fx);
                x = a + (i * iX);
                fx = Eval.Execute<double>(tbFx.Text, new { y = y1, x = x });
                dgb2.Rows.Add((i), x, y1, tbFx.Text+"= " + fx);
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
            tbFx.Text = tbFx.Text + "y";
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
            tbFx.Text = tbFx.Text + "x";
        }

        private void bSup_Click(object sender, EventArgs e)
        {
            if(tbFx.Text.Length>0)
            tbFx.Text=tbFx.Text.Substring(0,tbFx.Text.Length-1);
        }
    }
}
