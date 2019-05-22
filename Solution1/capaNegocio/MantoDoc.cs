using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace capaNegocio
{
    class MantoDoc
    {
        bdConex test = new bdConex();
        private String Doctor_No, Hospital_Cod, Apellido, Especialidad;

        public String Especialidad1
        {
            get { return Especialidad; }
            set { Especialidad = value; }
        }

        public String Apellido1
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        public String Hospital_Cod1
        {
            get { return Hospital_Cod; }
            set { Hospital_Cod = value; }
        }

        public String Doctor_No1
        {
            get { return Doctor_No; }
            set { Doctor_No = value; }
        }

         public void insertDoc()
        {
            try {
            String insert="INSERT INTO Doctor(Doctor_No, Hospital_Cod, Apellido, Especialidad)VALUES('"+Doctor_No+"','"+Hospital_Cod+"','"+ Apellido+"','"+Especialidad+"')";
                    test.Conectar();
                    test.consultaSQL(insert);
                    test.Desconectar();         
            }
            catch {
            
            }
        }


        public void updateDoc()
        {
            try
            {
                String update = "update Doctor set NOMBRE='"
                                 + Apellido + "' where Doctor='"
                                 +Doctor_No + "'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void deletDoc()
        {
            try
            {
                String delete = "delete from Doctor where Doctor='"
                                 + Doctor_No + "'";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {

            }
        }


        public String prueba()
        {
            String mensaje;
            if (test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }
            else {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }
        public void mostrarDoctor()
        {
            try
            {
                String consulta = "select * from doctor";
                                 
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }



    }
}
