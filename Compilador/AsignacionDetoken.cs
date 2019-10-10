using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador
{
    class AsignacionDetoken
    {
        public List<ClaseValores> caracteres = 
            new List<ClaseValores>();
        public List<ClaseValores> arreglo
        {
            get { return caracteres; }
            set { caracteres = value; }
        }
        public void inicializar()
        {
            //palabra,id_token,id_tipo,numLinea
            ClaseValores v1 = new ClaseValores("Prog",-1,-1,-0);
            caracteres.Add(v1);
            ClaseValores v2 = new ClaseValores("Var", -2, -1, -0);
            caracteres.Add(v2);
            ClaseValores v3 = new ClaseValores("Proc", -3, -1, -0);
            caracteres.Add(v3);
            ClaseValores v4 = new ClaseValores("Inicio", -4, -1, -0);
            caracteres.Add(v4);
            ClaseValores v5 = new ClaseValores("Fin", -5, -1, -0);
            caracteres.Add(v5);
            ClaseValores v6 = new ClaseValores("Entero", -6, -1, -0);
            caracteres.Add(v6);
            ClaseValores v7 = new ClaseValores("Real", -7, -1, -0);
            caracteres.Add(v7);
            ClaseValores v8 = new ClaseValores("String", -8, -1, -0);
            caracteres.Add(v8);
            ClaseValores v9 = new ClaseValores("Limpiar", -9, -1, -0);
            caracteres.Add(v9);
            ClaseValores v10 = new ClaseValores("Vexy", -10, -1, -0);
            caracteres.Add(v10);
            ClaseValores v11 = new ClaseValores("Leer", -11, -1, -0);
            caracteres.Add(v11);
            ClaseValores v12 = new ClaseValores("Escribir", -12, -1, -0);
            caracteres.Add(v12);



        }
        public int contlineas()
        {
            int numid = 0;
            foreach (var nlinea in caracteres)
            {
                numid = numid + 1;
            }
            return numid - 1;
        }

    }
}