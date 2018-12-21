using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftecsulTarGetID.SoftecsulTarGetIDModel
{
    class StatusRegistro
    {

        public int StatusRegistroId { get; set; }

        public string Tabela { get; set; }
        [StringLength(20)]
        public string IDTabela { get; set; }
        public string Funcionario { get; set; }
        
        public StatusRegistro()
        {

        }

        public StatusRegistro(string tabela, string idtabela, string funcionario)
        {
            this.Tabela = tabela;
            this.IDTabela = idtabela;
            this.Funcionario = funcionario;
        }
    }
}
