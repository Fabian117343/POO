using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1.Clases
{
    public class clsDoctorReceta
    {
        #region Atributos
        private int identificador;
        private String nombre1, nombre2, apellido1, apellido2;
        private String codigoColegioMedico;
        private String descripcionTratamiento;
        private String dosisIndicada;
        private String modoIngerirMedicamento;

        #endregion


        #region Constructores
        public clsDoctorReceta()
        {
            this.identificador = 0;
            this.nombre1 = "";
            this.nombre2 = "";
            this.apellido1 = "";
            this.apellido2 = "";
            this.codigoColegioMedico = "";
            this.descripcionTratamiento = "";
            this.dosisIndicada = "";
            this.modoIngerirMedicamento = "";

        }
        public clsDoctorReceta(int identificador, String nombre1, String nombre2, String apellido1, String apellido2, String codigoColegioMedico,
            String descripcionTratamiento, String dosisIndicada, String modoIngerirMedicamento)
        {
            this.identificador = identificador;
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.codigoColegioMedico = codigoColegioMedico;
            this.descripcionTratamiento = descripcionTratamiento;
            this.dosisIndicada = dosisIndicada;
            this.modoIngerirMedicamento = modoIngerirMedicamento;

        }
        #endregion


        #region Funciones y Procedimientos
        public String imprimirDatos()
        {
            String dato = "";
            dato = " Primer Nombre: " + this.nombre1 + "\n" + 
                " Segundo Nombre: " + this.nombre2 + "\n" + 
                " Primer Apellido: " + this.apellido1 + "\n" +
                " Segundo Apellido: " + this.apellido2 + "\n" + 
                " Codigo de Colegio de Medicos: " + this.codigoColegioMedico + "\n" +
                " Descripcion del Tratamiento: " + this.descripcionTratamiento + "\n" + 
                " Dosis Indicada: " + this.dosisIndicada + "\n" +
                " Modo de Ingerir el Medicamento: " + this.modoIngerirMedicamento;
            
            return dato;

        }
        #endregion


        #region Metodos
        public int Identificador
        {
            set { identificador = value; }
            get { return identificador; }
        }

        public String Nombre1
        {
            set { nombre1 = value.ToUpper(); }
            get { return nombre1; }
        }

        public String Nombre2
        {
            set { nombre2 = value.ToUpper(); }
            get { return nombre2; }
        }

        public String Apellido1
        {
            set { apellido1 = value.ToUpper(); }
            get { return apellido1; }
        }

        public String Apellido2
        {
            set { apellido2 = value.ToUpper(); }
            get { return apellido2; }
        }

        public String CodigoColegioMedico
        {
            set { codigoColegioMedico = value.ToUpper(); }
            get { return codigoColegioMedico; }
        }

        public String DescripcionTratamiento
        {
            set { descripcionTratamiento = value.ToUpper(); }
            get { return descripcionTratamiento; }
        }

        public String DosisIndicada
        {
            set { dosisIndicada = value.ToUpper(); }
            get { return dosisIndicada; }
        }

        public String ModoIngerirMedicamento
        {
            set { modoIngerirMedicamento = value.ToUpper(); }
            get { return modoIngerirMedicamento; }
        }


        #endregion 

    }
}
