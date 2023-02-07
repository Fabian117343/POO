using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1.Clases
{
    public class clsCliente
    {

        #region Atributos
        private int identificador;
        private String nombre1, nombre2, apellido1, apellido2, numeroIdentificacion;
        private DateTime fechaNacimiento;
        private double peso;
        private char sexo;
        private String alergiasMedicamentos;
        private String celular;
        private String correo;


        #endregion


        #region Constructores
        public clsCliente()
            {
            this.identificador = 0;
            this.nombre1 = "";
            this.nombre2 = "";
            this.apellido1 = "";
            this.apellido2 = "";
            this.numeroIdentificacion = "";
            this.fechaNacimiento = Convert.ToDateTime("01/01/1990");
            this.peso = 0;
            this.sexo = '*';
            this.alergiasMedicamentos = "";
            this.celular = "";
            this.correo = "";

            }

        public clsCliente(int identificador, String nombre1, String nombre2, String apellido1, String apellido2,
            String numeroIdenti, DateTime fechaNacimiento, double peso, char sexo, String alergiasM,
            String celular, String correo)
        {
            this.identificador = identificador;
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.numeroIdentificacion = numeroIdenti;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.sexo = sexo;
            this.alergiasMedicamentos = alergiasM;
            this.celular = celular;
            this.correo = correo;
        }
        #endregion


        #region Funciones y Procedimientos
        public String imprimirDatos()
        {
            String dato = "";
            dato = " Primer Nombre: " + this.nombre1 + "\n" + " Segundo Nombre: " + this.nombre2 + "\n" +
                " Primer Apellido: " + this.apellido1 + "\n" + " Segundo Apellido: " + this.apellido2 + "\n" +
                " Numero Identificacion: " + this.numeroIdentificacion + "\n" + " Fecha Nacimiento: " + this.fechaNacimiento + "\n" +
                " Peso: " + this.peso + "\n" + " Sexo: " + this.sexo + "\n" + " Alergias Medicamentos: " + this.alergiasMedicamentos + "\n" +
                " Celular: " + this.celular + "\n" + " Correo: " + this.correo;
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

        public String NumeroIdentificacion
        {
            set { numeroIdentificacion = value.ToUpper(); }
            get { return numeroIdentificacion; }
        }

        public DateTime FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }        
               
        public double Peso
        {
            set { peso = value; }
            get { return peso; }
        }

        public char Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public String Celular
        {
            set { celular = value.ToUpper(); }
            get { return celular; }
        }

        public String Correo
        {
            set { correo = value.ToUpper(); }
            get { return correo; }
        }

        #endregion 





    }
}
