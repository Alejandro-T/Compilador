using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador
{
    class ClaseValores
    {
        public string palabra;
        public int id_token;
        public int id_tipo;
        public int numLinea;
        //public String comentarios;


        public ClaseValores
            (string palabra, int id_token, int id_tipo, int numLinea)
        {
            this.palabra = palabra;
            this.id_token = id_token;
            this.id_tipo = id_tipo;
            this.numLinea = numLinea;
        }
        public String Palabra
        {
            get { return palabra;}
            set { this.palabra = Palabra; }
        }
        public int Token
        {
            get { return Token;}
            set { this.id_token = Token; }
        }
        public int Tipo
        {
            get { return Tipo; }
            set { this.id_tipo = Tipo; }
        }
        public int Linea
        {
            get { return Linea; }
            set { this.numLinea = Linea; }
           
        }
        public String ToString()
        {
            return "" + palabra + id_token;
        }
        
        
    }
}
