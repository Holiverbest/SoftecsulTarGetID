using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftecsulTarGetID.SoftecsulTarGetIDModel
{
    class ClienteEquipamento
    {
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        //Toda a vez que atualizar a classe, tem que gerar um update no migration:
        //no console do gerenciador de pacotes => Add-Migration Addtag   (nome da atualização)
        //no console do gerenciador de pacotes => Update-Database –Verbose
        //
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        public int ClienteEquipamentoId { get; set; }
        public string NomeEquipamento { get; set; }
        public string TipoEquipamento { get; set; }
        public string ModeloEquipamento { get; set; }
        public string FabricanteEquipamento { get; set; }
        public string VersaoEquipamento { get; set; }
        public string VersaoDll { get; set; }       
        public int ClienteId { get; set; }
        public string PortaCom { get; set; }
        public int IDterminal { get; set; }

        public Cliente Cliente { get; set; }


        public ClienteEquipamento()
        {

        }

        public ClienteEquipamento(string nomeequipamento, string tipoequipamento, string modeloequipamento, string fabricanteEquipamento, string versaoequipamento, string versaodll, Cliente cliente)
        {
            this.NomeEquipamento = nomeequipamento;
            this.TipoEquipamento = tipoequipamento;
            this.ModeloEquipamento = modeloequipamento;
            this.FabricanteEquipamento = fabricanteEquipamento;
            this.VersaoEquipamento = versaoequipamento;
            this.VersaoDll = versaodll;
            this.ClienteId = cliente.ClienteId;
            this.Cliente = cliente;
        }

    }
}
