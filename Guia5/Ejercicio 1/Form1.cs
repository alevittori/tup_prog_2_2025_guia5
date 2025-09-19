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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            lbResultados.Items.Clear();


            string tel = "343-2356894";
            string tel2 = "3434-4568975";
            string tel3 = "45-56++98";

            TelefonoRegexValidador validarTel = new TelefonoRegexValidador(tel3);
            lbResultados.Items.Add(validarTel.VerMensaje());
           



            string patente = "dfr 123";
            string patente2 = "456 sd";
            PatentesViejasCharValidador validarPatenteChar = new PatentesViejasCharValidador(patente);
            lbResultados.Items.Add(validarPatenteChar.VerMensaje());
            validarPatenteChar = new PatentesViejasCharValidador(patente2);

            lbResultados.Items.Add(validarPatenteChar.VerMensaje());

            PatentesViejasRegexValidador validarPatenteRegex = new PatentesViejasRegexValidador(patente);
           
            lbResultados.Items.Add(validarPatenteRegex.VerMensaje());
            validarPatenteRegex = new PatentesViejasRegexValidador(patente2);
            lbResultados.Items.Add(validarPatenteRegex.VerMensaje());
        }
    }
}
