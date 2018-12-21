using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftecsulTarGetID.SoftecsulTarGetIDData
{
    class MySqlConfiguration : System.Data.Entity.DbConfiguration
    {
        //Erro Specified key was too long; max key lenght is 767 bytes
        //Este problema significa que o o tamanho da chave primária para o mysql padrão foi 
        //    ultrapassado.Para resolver este problema teremos que modificar esta configuração do mysql, 
        //    porém faremos isso via código.Para personalizar as configurações do banco de dados temos que 
        //    implementar DBConfiguration.No construtor utilizamos o método 
        //    SetHistoryContext onde configuramos a classe que vamos implementar as modificações.
        public MySqlConfiguration()
        {
            SetHistoryContext("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
        }
    }
}
