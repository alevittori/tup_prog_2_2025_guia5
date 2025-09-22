using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    
    public partial class Form1 : Form
    {
        int cantNombre = 10000;


        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cantNombre; i++) 
            {
                sb.AppendLine(GeneradorNombres.GenerarNombre());
            }

            lbResultado.Items.AddRange(sb.ToString().Split('\n'));
            
        }
    }
}
