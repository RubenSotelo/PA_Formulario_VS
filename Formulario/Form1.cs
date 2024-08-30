using System.IO;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GuardarElemento(object sender, EventArgs e)
        {
            String genero = "";
            if (rbHombre.Checked){
                genero = "Hombre";
            }else if(rbMujer.Checked){
                genero = "Mujer";
            }
            String datos = "Nombre: "+tbNombre.Text+"\n"+"Apellido: "+tbApellido.Text
                +"\n"+"Telefono: "+tbTelefono.Text+ "\n"+"Edad: "+tbEdad.Text
                +"\n"+"Estatura: "+tbEstatura.Text+"\n"+"Genero: "+genero;
            String url = "C:\\Users\\dell\\Desktop\\Programacion_Avanzada\\datosC.txt";
            bool bandera = File.Exists(url);
            using (StreamWriter writer = new StreamWriter(url, true))
            {
                if (bandera)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
            }
            MessageBox.Show("Datos guardados: \r\n"+datos+"\r\n Informacion");
        }

        private void LimpiarElemento(object sender, EventArgs e)
        {

        }
    }
}
