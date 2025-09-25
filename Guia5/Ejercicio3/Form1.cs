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
        List<Vehiculo> vehiculos;
        string xml;
        /*
         * la idea del ejerciico creo que es tomar un xml dado y separar las patentes, hacer un solo recorrido
         * e ir creando los objetos vehiculos
         * con las patentes dadas, e ir actualizando o agregando multas si la patente se repitiera.
         * 
         * */

        /*
         * <multa> 
        <patente>ACD 232</patente>
        <importe>234556,00</importe>
        </multa> 
        <multa>
        <patente>ACE 232</patente>
        <importe>234556,00</importe>
        </multa> 
        <multa> 
        <patente>ACE 732</patente>
        <importe>234556,00</importe>
        </multa>
        <multa> 
        <patente>ACE 232</patente>
        <importe>234556,00</importe>
        </multa>

        */

public Form1()
{
    InitializeComponent();
    vehiculos = new List<Vehiculo> { new Vehiculo("ACE 232"), new Vehiculo("ACD 232"), new Vehiculo("ACE 732") };
}

private void btnPrueba_Click(object sender, EventArgs e)
{

    xml = textBox1.Text;
    //Vehiculo auto = new Vehiculo("ACE 232");
    //auto.Importar(xml);
    foreach(Vehiculo ve in vehiculos)
    {
        ve.Importar(xml);
        listBox1.Items.Add(ve.ToString());
    }

}
}
}
