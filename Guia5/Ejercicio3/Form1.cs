using Ejercicio3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        string xml = "<multa> \r\n  <patente>ACD 232</patente>\r\n  <importe>234556,00</importe>\r\n</multa> \r\n<multa>\r\n  <patente>ACE 232</patente>\r\n  <importe>234556,00</importe>\r\n</multa> \r\n<multa> \r\n  <patente>ACE 732</patente>\r\n  <importe>234556,00</importe>\r\n</multa>\r\n<multa> \r\n  <patente>ACE 232</patente>\r\n  <importe>234556,00</importe>\r\n</multa>\r\n";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Vehiculo auto = new Vehiculo("ACE 232");
            auto.Importar(xml);

            listBox1.Items.Add(auto.CantidadMultas);
            listBox1.Items.Add(auto.ImporteTotal);
        }
    }
}
