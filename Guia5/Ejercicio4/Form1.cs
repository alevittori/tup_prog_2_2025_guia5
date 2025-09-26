using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = "La ratona a partir de las definiciones clasifica las piezas, a partir de las definiciones la ratona toma las piezas \r\ny construye nuevos objetos, y la ratona con la definiciones controla que la interacción \r\nentre los objetos sean las de esperar por sus propias definiciones \r\n";
            string palabra = textBox1.Text;
            string patron = $@"\b(?<palabra>{Regex.Escape(palabra)})\b";
            string reemplazo = @"{\b ${palabra}}";
            string resultado = Regex.Replace(frase, patron, reemplazo, RegexOptions.IgnoreCase);
            richTextBox1.Rtf = $@"{{\rtf1\ansi {resultado}}}";
            int cantidad = Regex.Matches(frase, patron, RegexOptions.IgnoreCase).Count;
            label2.Text = cantidad.ToString();
            label2.Visible = true;

        }
    }
}
