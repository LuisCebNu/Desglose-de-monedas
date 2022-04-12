using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescuentoARSyAFP
{
    public partial class Form1 : Form
    {
        double x;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultadoAFP;
            double resultadoARS;
            resultadoAFP = x % 2.87;
            resultadoARS = x % 3.04;
           
            
            lblDescuentoAFP.Text = Convert.ToString(Math.Round(resultadoAFP,2));
            lblDescuentoARS.Text = Convert.ToString (Math.Round(resultadoARS,2));

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(txtSalario.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Un error a ocurrido");
            }
            
            
           
            
        }
    }
}
