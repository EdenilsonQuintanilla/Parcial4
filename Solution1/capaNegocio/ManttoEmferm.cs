using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace capaNegocio
{
    class ManttoEmferm
    { bdConex test = new bdConex();
        private String inscripcion,apellido,dirrecion,fecha_Nac,S,NSS;

public String NSS1
{
  get { return NSS; }
  set { NSS = value; }
}

public String S1
{
  get { return S; }
  set { S = value; }
}

public String Fecha_Nac
{
  get { return fecha_Nac; }
  set { fecha_Nac = value; }
}

public String Dirrecion1
{
  get { return dirrecion; }
  set { dirrecion = value; }
}

public String Dirrecion
{
  get { return dirrecion; }
  set { dirrecion = value; }
}

public String Apellido
{
  get { return apellido; }
  set { apellido = value; }
}

public String Inscripcion
{
  get { return inscripcion; }
  set { inscripcion = value; }
}
        public DataTable dt = new DataTable();
       
        //
         public void insertEmf()
        {
            try {
            String insert="INSERT INTO Doctor(inscripcion,apellido,dirrecion,fecha_Nac,S,NSS)VALUES('"+inscripcion+"','"+apellido+"','"+dirrecion+"','"+fecha_Nac+"','"+S+"','"+NSS+"')";
                    test.Conectar();
                    test.consultaSQL(insert);
                    test.Desconectar();         
            }
            catch {
            
            }
        }


        public void updateEmf()
        {
            try
            {
                String update = "update Emp set NOMBRE='"
                                 + Apellido + "' where Doctor='"
                                 +NSS+ "'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void deletemf()
        {
            try
            {
                String delete = "delete from Enfermo where Enfermo='"
                                 + NSS + "'";
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
        public void mostrarEnfermo()
        {
            try
            {
                String consulta = "select * from Enfermo";
                                 
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
