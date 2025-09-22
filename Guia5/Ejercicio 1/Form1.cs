using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        List<string> telefonos = new List<string> { "343-2356894" , "3434-4568975" , "45-56++98" };
        List<string> patentes = new List<string> { "dfr 123" , "456 sd" };
        List<string> cuits = new List<string> { "20-28464555-2","20-05410060-5 ", "30-50000173-5", "30-50000845-4", "30-50004977-0", "27-653468-2", "23-5648975648-8" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            lbResultados.Items.Clear();

            lbResultados.Items.Add("VAlidador telefono char");
            foreach (string tel in telefonos)
            {
                lbResultados.Items.Add(new TelefonoCharValidador(tel).VerMensaje());

            }
            lbResultados.Items.Add("");
            lbResultados.Items.Add("Validador telefonos regex");
            lbResultados.Items.Add("");
            foreach (string tel in telefonos)
            {
                lbResultados.Items.Add(new TelefonoRegexValidador(tel).VerMensaje());
            }

            lbResultados.Items.Add("");
            lbResultados.Items.Add("Validacion patentes viejas con char");
            lbResultados.Items.Add("");
            foreach (string patente in patentes)
            {
                lbResultados.Items.Add(new PatentesViejasCharValidador(patente).VerMensaje());
            }

            lbResultados.Items.Add("");
            lbResultados.Items.Add("valdiadion patentes viejas con regex");
            lbResultados.Items.Add("");
            foreach (string patente in patentes)
            {
                lbResultados.Items.Add(new PatentesViejasRegexValidador(patente).VerMensaje());
            }

            lbResultados.Items.Add("");
            lbResultados.Items.Add("Validacion de CUIT ");
            lbResultados.Items.Add("");
            foreach (string cuit in cuits)
            {
                lbResultados.Items.Add(new CuitValidador(cuit).VerMensaje());
            }
        }
    }
}
