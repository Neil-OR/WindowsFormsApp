using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForms.ManipulaAgenda
{
    class Conexao
    {
        public static SqlConnection Conectar()
        {
            string Conexao = @"Data Source = LAPTOP - VIJ1QKBN\SQLEXPRESS; Initial Catalog = AppForms; Integrated Security = True";
            SqlConnection connection = new SqlConnection(Conexao);
            connection.Open();
            return connection;
        }
    }
}
