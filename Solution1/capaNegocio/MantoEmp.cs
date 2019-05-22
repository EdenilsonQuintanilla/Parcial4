using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace capaNegocio
{
    class MantoEmp
    {
       { bdConex test = new bdConex();
        private String Emp_No,Apellido,Oficio,Dir,Fecha_Alt,Salario,Comision,Dept_No;

public String Dept_No1
{
  get { return Dept_No; }
  set { Dept_No = value; }
}

public String Comision1
{
  get { return Comision; }
  set { Comision = value; }
}

public String Salario1
{
  get { return Salario; }
  set { Salario = value; }
}

public String Fecha_Alt1
{
  get { return Fecha_Alt; }
  set { Fecha_Alt = value; }
}

public String Dir1
{
  get { return Dir; }
  set { Dir = value; }
}

public String Oficio1
{
  get { return Oficio; }
  set { Oficio = value; }
}

public String Emp_No1
{
  get { return Emp_No; }
  set { Emp_No = value; }
}

public String Apellido1
{
  get { return Apellido; }
  set { Apellido = value; }
}


}
        public DataTable dt = new DataTable();
       
        //
         public void insertEmp()
        {
            try {
            String insert="INSERT INTO Emp(Emp_No,Apellido,Oficio,Dir,Fecha_Alt,Salario,Comision,Dept_No;)VALUES('"+Emp_No+"','"+Apellido+"','"+Oficio+"','"+Dir+"','"+Fecha_Alt+"','"+Salario+"','"+Comision"','"+Dep_No+"')";
                    test.Conectar();
                    test.consultaSQL(insert);
                    test.Desconectar();         
            }
            catch {
            
            }
        }


        public void updateEmp()
        {
            try
            {
                String update = "update Emp set NOMBRE='"
                                 + Apellido + "' where Emp='"
                                 +Emp_No+ "'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void deletemp()
        {
            try
            {
                String delete = "delete from Emp where Emp='"
                                 + Emp_No + "'";
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
        public void mostrarEmp()
        {
            try
            {
                String consulta = "select * from Emp";
                                 
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
