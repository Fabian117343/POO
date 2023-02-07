using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1.Clases
{
    public class clsDetalleFactura
    {

        #region Atributos
        private int identificador;
        private String articulo;
        private String cantidad;
        private String precio;
        private String iva;
        private String subTotal;

        #endregion


        #region Constructores
        public clsDetalleFactura()
        {
            this.identificador = 0;
            this.articulo = "";
            this.cantidad = "";
            this.precio = "";
            this.iva = "";
            this.subTotal = "";  
        
        }

        public clsDetalleFactura(int identificador, String articulo, String cantidad, String precio, String iva, String subTotal)
        {
            this.identificador = identificador;
            this.articulo = articulo;
            this.cantidad = cantidad;
            this.precio = precio;
            this.iva = iva;
            this.subTotal = subTotal;

        }
        #endregion


        #region Funciones y Procedimientos
        public String imprimirDatos()
        {
            string dato = "";
            dato = " Articulo: " + this.articulo + "\n" + " Cantidad: " + this.cantidad + "\n" + " Precio: " + this.precio + "\n" +
                " IVA: " + this.iva + "\n" + " SubTotal: " + this.subTotal;
            return dato;
                }

        #endregion


        #region Metodos
        public int Identificador
        {
            set { identificador = value; }
            get { return identificador; }
        }

        public String Articulo
        {
            set { articulo = value.ToUpper(); }
            get { return articulo; }
        }

        public String Cantidad
        {
            set { cantidad = value.ToUpper(); }
            get { return cantidad; }
        }

        public String Precio
        {
            set { precio = value.ToUpper(); }
            get { return precio; }
        }

        public String IVA
        {
            set { iva = value.ToUpper(); }
            get { return iva; }
        }

        public String SubTotal
        {
            set { subTotal = value.ToUpper(); }
            get { return subTotal; }
        }


        #endregion


    }
}
