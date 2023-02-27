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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Iteraciones it = new Iteraciones();
            double[] iteracionesx1 = new double[10];
            double[] iteracionesx2 = new double[10];
            double[] iteracionesx3 = new double[10];
            double x1 = Double.Parse(txtX1.Text);
            double x2 = Double.Parse(txtX2.Text);
            double x3 = Double.Parse(txtX3.Text);
            iteracionesx1[0] = it.iteracionX1(x1, x2, x3);
            iteracionesx2[0] = it.iteracionX2(x1, x2, x3);
            iteracionesx3[0] = it.iteracionX3(x1, x2, x3);
            for (int i = 1; i < 10; i++) 
            {
                iteracionesx1[i] = it.iteracionX1(iteracionesx1[(i - 1)], iteracionesx2[(i - 1)], iteracionesx3[(i - 1)]);
                iteracionesx2[i] = it.iteracionX2(iteracionesx1[(i - 1)], iteracionesx2[(i - 1)], iteracionesx3[(i - 1)]);
                iteracionesx3[i] = it.iteracionX3(iteracionesx1[(i - 1)], iteracionesx2[(i - 1)], iteracionesx3[(i - 1)]);
            }

            for (int i = 0; i < 10; i++) 
            {
                dgb.Rows.Add(i,iteracionesx1[i],iteracionesx2[i],iteracionesx3[i]);
            }
            dgb.Rows.Add("Error Absoluto");
        }
    }
}
