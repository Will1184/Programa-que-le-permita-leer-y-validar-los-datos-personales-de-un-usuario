using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Label = System.Windows.Forms.Label;

namespace GM21057Guia6Ejercicio2
{
    internal class Usuario
    {
        private string nombre, correoElectronico, telefono; 
        private DateTime fechaNacimiento;

        public Usuario()
        {
        }

        public Usuario(string nombre, string correoElectronico, string telefono, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.correoElectronico = correoElectronico;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }

        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
       }

        public  void taxonomiaGeneraciones(DateTime fechaNacimiento,Label labelGeneracion, Label labelMarcoTemporal, Label labelPoblacion, Label labelCircustanciaHistorica, Label labelRasgo)
        {
            string generacionAlfa= "01/01/2010", generacionZ= "01/01/1994", generacionY= "01/01/1981", generacionX= "01/01/1969", babyBoom= "01/01/1949", silentGeneracion= "01/01/1930";
  

            if (fechaNacimiento >= DateTime.Parse(generacionZ) && fechaNacimiento < DateTime.Parse(generacionAlfa))
            {
                labelGeneracion.Text = "Generacion Z";
                labelMarcoTemporal.Text = "1994-2010";
                labelPoblacion.Text = "7.800.000";
                labelCircustanciaHistorica.Text = "Expancion masiva de internet";
                labelRasgo.Text = "Irreverencia";
            }
            else if (fechaNacimiento >= DateTime.Parse(generacionY) && fechaNacimiento < DateTime.Parse(generacionZ))
            {
                labelGeneracion.Text = "Generacion Y";
                labelMarcoTemporal.Text = "1981-1993";
                labelPoblacion.Text = "7.200.000";
                labelCircustanciaHistorica.Text = "Inicio de la digitacion";
                labelRasgo.Text = "Frustracion";
            }
            else if (fechaNacimiento >= DateTime.Parse(generacionX) && fechaNacimiento < DateTime.Parse(generacionY))
            {
                labelGeneracion.Text = "Generacion X";
                labelMarcoTemporal.Text = "1969-1980";
                labelPoblacion.Text = "9.300.000";
                labelCircustanciaHistorica.Text = "Crisis del 73 y transicion española";
                labelRasgo.Text = "Obsesion por el exito";
            }
            else if (fechaNacimiento >= DateTime.Parse(babyBoom) && fechaNacimiento < DateTime.Parse(generacionX))
            {
                labelGeneracion.Text = "Baby Boom";
                labelMarcoTemporal.Text = "1949-1968";
                labelPoblacion.Text = "12.200.000";
                labelCircustanciaHistorica.Text = "Paz y explosion demografica";
                labelRasgo.Text = "Ambicion";
            }
            else if(fechaNacimiento >= DateTime.Parse(silentGeneracion) && fechaNacimiento < DateTime.Parse(babyBoom))
            {
                labelGeneracion.Text = "Silenciosa";
                labelMarcoTemporal.Text = "1930-1948";
                labelPoblacion.Text = "6.300.000";
                labelCircustanciaHistorica.Text = "Conflictos belicos";
                labelRasgo.Text = "Austeridad";
            }   else
            {
                MessageBox.Show("Fecha no valida","Error");
                
            }
        }
    }
}
