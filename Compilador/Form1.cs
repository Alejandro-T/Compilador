using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AsignacionDetoken asi = new AsignacionDetoken();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            asi.inicializar();

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            // String a = "";
            List<int> lista = new List<int>();
            lista.Add(10);
            for(int i=0; i<10; i++)
            {
                dataGridView1.Rows.Add
                    (asi.arreglo[i].Palabra
                    ,asi.arreglo[i].id_token
                    ,asi.arreglo[i].id_tipo,asi.contlineas());
            }
            //dataGridView1.Rows.Add(richTextBox1.Text,asi.arreglo,lista[0]);
            
            
            
           
           
           
        }

        
    }
}