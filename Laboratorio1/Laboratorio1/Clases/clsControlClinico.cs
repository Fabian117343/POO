using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1.Clases
{
    public class clsControlClinico
    {

        #region Atributos
        private int identificador;
        private String sintomas;
        private int idCliente;

        #endregion


        #region Constructores
        public clsControlClinico()
        {
            this.identificador = 0;
            this.sintomas = "";
            this.idCliente = 0;      
        
        }
        public clsControlClinico(int identificador, String sintomas, int idCliente)
        {
            this.identificador = identificador;
            this.sintomas = sintomas;
            this.idCliente = idCliente;

        }
        #endregion


        #region Funciones y Procedimientos
        public String imprimirDatos()
        {
            String dato = "";
            dato = " Sintomas del Paciente: " + this.sintomas + "\n" + " Identificador del Paciente: " + this.idCliente;

            return dato;

        }
        #endregion


        #region Metodos
        public int Identificador
        {
            set { identificador = value; }
            get { return identificador; }
        }

        public String Sintomas
        {
            set { sintomas = value.ToUpper(); }
            get { return sintomas; }
        }

        public int IdCliente
        {
            set { idCliente = value; }
            get { return idCliente; }
        }


        #endregion


    }
}
