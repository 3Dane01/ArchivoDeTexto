using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
    //entrada y salida de datos 
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArchivoDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar(string nombreArchivo, string texto)
        {
            //Abrir el archivo: Write sobreescribe el archivo, Append agrega los datos al final del archivo
            //nombre del archivo, como quiero abrir un archivo (append tiene que existir el archivo y lo modifica o le agrega la siguiente linea),
            //y el tercer archivo es para abrir osea para leer o para escribir
            FileStream stream = new FileStream(nombreArchivo, FileMode.Append, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);
            //Usar el objeto para escribir al archivo, WriteLine, escribe linea por linea
            //Write escribe todo en la misma linea. En este ejemplo se hará un dato por cada línea
            writer.WriteLine(texto);
            //Cerrar el archivo
            writer.Close();
        }

        //Pero si queremos que lo guarde en un lugar específico, tenemos que agregar el Path (camino) por ejemplo:
        //Guardar(@"C:\Users\usuarioactual\Desktop\archivo.txt", textBox1.Text);
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Guardar("archivo.txt", textBox1.Text);
            //para mostrar que se guardo
            MessageBox.Show("Texto Guardado");
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            //Ademas de utilizar el control openFileDialog, es necesario declarar un objeto de este tipo
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //Directorio en donde se va a iniciar la busqueda
            openFileDialog1.InitialDirectory = "c:\\";
            //Tipos de archivos que se van a buscar, en este caso archivos de texto con extensión .txt, el * quiere decir cualquier tipo de nombe de archivo
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            //Muestra la ventana para abrir el archivo y verifica que si se pueda abrir
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //Guardamos en una variable el nombre del archivo que abrimos
                string nombreArchivo = openFileDialog1.FileName;

                //Abrimos el archivo, en este caso lo abrimos para lectura
                FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                //Un ciclo para leer el archivo hasta el final del archivo
                //Lo leído se va guardando en un control richTextBox
                while (reader.Peek() > -1)
                //Esta linea envía el texto leído a un control richTextBox, se puede cambiar para que
                //lo muestre en otro control por ejemplo un combobox
                {
                    string textoLeido = reader.ReadLine();
                    richTextBox1.AppendText(textoLeido);
                }
                //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
                reader.Close();
            }
        }

        private void buttonLeerDirecto_Click(object sender, EventArgs e)
        {
            //Guardamos en una variable el nombre del archivo que abrimos
            string nombreArchivo = @"E:\Progra3\Progrmas\ArchivoDeTexto\bin\Debug\archivo.txt";
            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Un ciclo para leer el archivo hasta el final del archivo
            //Lo leído se va guardando en un control richTextBox
            while (reader.Peek() > -1)
            //Esta linea envía el texto leído a un control richTextBox, se puede cambiar para que
            //lo muestre en otro control por ejemplo un combobox
            {
                string textoLeido = reader.ReadLine();
                richTextBox1.AppendText(textoLeido);
            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces.
            //Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }
    }
}
