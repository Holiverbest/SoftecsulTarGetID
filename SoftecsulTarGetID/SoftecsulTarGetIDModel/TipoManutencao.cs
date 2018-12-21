using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftecsulTarGetID.SoftecsulTarGetIDModel
{
    class TipoManutencao
    {
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        //Toda a vez que atualizar a classe, tem que gerar um update no migration:
        //no console do gerenciador de pacotes => Add-Migration Addxxxxxxx   (nome da atualização)
        //no console do gerenciador de pacotes => Update-Database –Verbose
        //
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        public int TipoManutencaoId { get; set; }
        public string Tipo { get; set; }
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

        public TipoManutencao(string tipo)
        {
            this.Tipo = tipo;
        }
        public TipoManutencao()
        {

        }

    }
}
