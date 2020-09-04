using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Context
{
    public class BoletimContext
    {
        // 1 - Instancio o meu objeto de conexão
        SqlConnection con = new SqlConnection();

        public BoletimContext()
        {
            // 2 - Defino os dados de conexão com meu servidor SQL
            con.ConnectionString = @"Data Source=LAB107301\SQLEXPRESS2;Initial Catalog=boletim;User ID=sa;Password=sa132";
        }

        public SqlConnection Conectar()
        {
            // 3 - Verifico se a conexão está fechada para conectar ao banco
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            // 4 - Verifico se a conexão está aberta para fechar a conexão
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
