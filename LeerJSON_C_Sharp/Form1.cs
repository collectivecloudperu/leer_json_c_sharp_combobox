using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeerJSON_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Leemos el archivo 'postres.json' 
            using (StreamReader archivo = File.OpenText(@"C:/Users/carlos/source/repos/LeerJSON_C_Sharp/LeerJSON_C_Sharp/postres.json"))

            {
                // Leemos los datos del archivo 'postre.json' desde el inicio hasta el final 
                string json = archivo.ReadToEnd();

                // Deserializamos el objeto 'json' 
                dynamic miarray = JsonConvert.DeserializeObject(json);

                // Recorremos el array 'miarray' 
                foreach (var item in miarray)
                {
                    // Agregamos el campo nombre del archivo 'postres.json' al ComboBox llamado 'comboBox1' 
                    comboBox1.Items.Add(item.nombre);
                    //Console.WriteLine("Datos: " + item.nombre);

                }

            }
        }
    }
}
