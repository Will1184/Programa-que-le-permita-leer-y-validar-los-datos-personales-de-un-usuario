// Guía:#6
// Ejercicio:#2
// Fecha: 02/10/2022
// Autor: BRANDON WILLIAM GOMEZ MONGE
// Carnet: GM21057
// GD: #1
// Instructora: ING. NELLY LISSETTE HENRIQUEZ SANCHEZ

namespace GM21057Guia6Ejercicio2
//Elabore un programa que le permita leer y validar los datos personales de un usuario
//(nombre, correo electrónico, teléfono incluyendo código de país, fecha de nacimiento) y
//le muestre la información correspondiente a su generación

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Metodo que revisa si um campo de texto esta vacio, si es asi no deja ejecutar todo el programa
        private bool validacion()
        {
            //DECLARACION DE VARIABLE
            bool noError = true;
            
            if (textBoxNombre.Text == string.Empty)
            {
                errorIcon.SetError(textBoxNombre, "Ingrese el Nombre");
                noError = false;
            }
            if (textBoxCorreo.Text == string.Empty)
            {
                errorIcon.SetError(textBoxCorreo, "Ingrese el correo");
                noError = false;
            }
            if (maskedTextBoxTelefono.Text == string.Empty)
            {
                errorIcon.SetError(maskedTextBoxTelefono, "Ingrese el numero de Telefono");
                noError = false;
            }
            if (maskedTextBoxFechaNacimiento.Text == string.Empty)
            {
                errorIcon.SetError(maskedTextBoxFechaNacimiento, "Ingrese la fecha de nacimiento");
                noError = false;
            }
            return noError;
            
        }

        // Al dar click al Boton "Ingresar"  hace que se ingrese los datos digitados por el usuario y se ejecute el metodo que verifica la generacion del usuario

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            //CAPTURA DE ERRRORES
            if (validacion())
            {
                //CREACION DE OBJETO
                Usuario usuario = new Usuario(textBoxNombre.Text, textBoxCorreo.Text, maskedTextBoxTelefono.Text, DateTime.Parse(maskedTextBoxFechaNacimiento.Text));
                //ENTRADA DE DATOS, PROCESO DE DATOS Y SALIDA DE DATOS
                usuario.taxonomiaGeneraciones(usuario.FechaNacimiento, labelGeneracion, labelMarcoTemporal, labelPoblacion, labelCircustanciaHistorica, labelRasgo);

            }

        }

        // Al dar click al Boton "Salir"  hace que el usuario salga del programa
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion=MessageBox.Show("¿Quiere salir del programa?","Salir del programa", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(opcion==DialogResult.Yes)Close();
        }
        // Al dar click al Boton "Borrar" borra los datos de textbox, masked y los label que hayan sido usados

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBoxCorreo.Clear();
            textBoxNombre.Clear();
            maskedTextBoxFechaNacimiento.Clear();
            maskedTextBoxTelefono.Clear();

            labelGeneracion.Text = "";
            labelMarcoTemporal.Text = "";
            labelPoblacion.Text = "";
            labelCircustanciaHistorica.Text = "";
            labelRasgo.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}