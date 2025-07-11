using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pROYECTO
{
    internal class Clsconeccion
    {
        private string cadenaconneccion;

        public Clsconeccion()
        {
            cadenaconneccion = "server=localhost; Database=control de pacientes; Uid=root; Pwd=; Port=3306;";
        }
        //Agregamos el metodo getconeccion
        public MySqlConnection GetConnection() 
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaconneccion);
                conn.Open();
                return conn;
            }
            catch
            {
                return null;
            }
        
        }
    }
}
