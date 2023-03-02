using System.Data.Sqlclient;

namespace conexion 
{
    class conexionbd{
        string cadena="Data source=LAPTOP-AL0D1IG2; Initial Catalog=Feria; Integrated security=True ";
        public SqlConnection sqlConnection= new SqlConnection();

        public conexionbd(){
            sqlConnection.ConnectionString=cadena;

        }

        public void open (){
            try
            {
                sqlConnection.Open();
                Console.Writeline("se ha conectado correctamente");
            }
            catch (Exepcion ex )
            {
                Console.Writeline("error al abrir ");
                throw;
            }
        }
    }

    public void cerrar(){
        sqlConnection.close();
    }
}