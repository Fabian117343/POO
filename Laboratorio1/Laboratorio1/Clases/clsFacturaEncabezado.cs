using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1.Clases
{
    public class clsFacturaEncabezado
    {

        #region Atributos
        private int identificador;
        private String razonSocial;
        private String cedulaJuridica;
        private String telefono;
        private String correo;
        private String totalPagar;

        #endregion

        #region Constructores
        public clsFacturaEncabezado()
        {
            this.identificador = 0;
            this.razonSocial = "";
            this.cedulaJuridica = "";
            this.telefono = "";
            this.correo = "";
            this.totalPagar = "";

        }

        public clsFacturaEncabezado(int identificador, String razonSocial, String cedulaJuridica, String telefono, String correo, String totalPagar)
        {
            this.identificador = identificador;
            this.razonSocial = razonSocial;
            this.cedulaJuridica = cedulaJuridica;
            this.telefono = telefono;
            this.correo = correo;
            this.totalPagar = totalPagar;

        }
        #endregion


        #region Funciones y Procedimientos
        public String imprimirDatos()
        {
            string dato = "";
            dato = "Razon Social: " + this.razonSocial + "\n" + " Cedula Juridica: " + this.cedulaJuridica + "\n" +
                " Telefono: " + this.telefono + "\n" + " Correo: " + this.correo + "\n" + " Total a Pagar: " + this.totalPagar;

            return dato;
        }
        #endregion


        #region Metodos

        public int Identificador
        {
            set { identificador = value; }
            get { return identificador; }
        }

        public String RazonSocial
        {
            set { razonSocial = value.ToUpper(); }
            get { return razonSocial; }
        }

        public String CedulaJuridica
        {
            set { cedulaJuridica = value.ToUpper(); }
            get { return cedulaJuridica; }
        }

        public String Telefono
        {
            set { telefono = value.ToUpper(); }
            get { return telefono; }
        }

        public String Correo
        {
            set { correo = value.ToUpper(); }
            get { return correo; }
        }

        public String TotalPagar
        {
            set { totalPagar = value.ToUpper(); }
            get { return totalPagar; }
        }

        #endregion


    }
}
