using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sqlclient;
using System.Dynamic;

namespace conexion
{
    class conexionbd
    {
        private string cadena = "Data source=LAPTOP-AL0D1IG20; Initial Catalog=Feria; Integrated security=True ";
        public SqlConnection sqlConnection = new SqlConnection();

        public conexionbd()
        {
            sqlConnection.ConnectionString = cadena;
            CreateInstanceBinder 
            update 
            read 
            delete 
        }

        public void open()
        {
            try
            {
                sqlConnection.Open();
                Console.Writeline("se ha conectado correctamente");
            }
            catch (Exepcion ex)
            {
                Console.Writeline("error al abrir "+Exepxion ex );
                throw;
            }
        }
    }

    public void cerrar()
    {
        sqlConnection.close();
    }
}