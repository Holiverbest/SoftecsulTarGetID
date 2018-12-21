using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftecsulTarGetID.SoftecsulTarGetIDModel
{
    class Cliente
    {

        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        //Toda a vez que atualizar a classe, tem que gerar um update no migration:
        //no console do gerenciador de pacotes => Add-Migration Addxxxxxxx   (nome da atualização)
        //no console do gerenciador de pacotes => Update-Database –Verbose
        //
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx


        [Display(Name = "Cod.")]
        public int ClienteId { get; set; }

        [Display(Name = "Cliente")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Tamanho máximo de 100 e mínimo de 10")]
        [Required(ErrorMessage = "O nome   é obrigatório", AllowEmptyStrings = false)]
        public string NomeFantasia { get; set; }

        [Display(Name = "Razão Social")]    
        [Required(ErrorMessage = "O Razão Social é obrigatório", AllowEmptyStrings = false)]
        public string RazaoSocial { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###-##-####}")]
        [Required(ErrorMessage = "O CNPJ é obrigatório", AllowEmptyStrings = false)]
        public string CNPJ { get; set; }

        public bool Inativo { get; set; }

        [Display(Name = "Versão")]
        public string Versao { get; set; }

        [Display(Name = "Atualização Habilitada")]
        public bool HabilitaAtualizacao { get; set; }

        [Display(Name = "Atualização On-Line")]
        public bool AtualizarOnLine { get; set; }

        public int TipoManutencaoId { get; set; }

        //Testando as opções :
        // AutomaticMigrationsEnabled = true;
        // AutomaticMigrationDataLossAllowed = true;

       
        public decimal Limite{ get; set; }

        public TipoManutencao TipoManutencao { get; set; }
        //string formatado = Convert.ToUInt64("01954698950").ToString(@"000\.000\.000\-00"); = CPF
        //string formatado = Convert.ToUInt64("01234567000199").ToString(@"00\.000\.000\/0000\-00") CNPJ
        [NotMapped]
        public string Tag { get; set; }
        public ICollection<ClienteEquipamento> ClienteEquipamentos { get; set; } = new List<ClienteEquipamento>();

        /// <summary>
        /// Costrutor vazio
        /// </summary>
        public Cliente()
        {

        }

        /// <summary>
        /// Construtor com passagem de parametros
        /// </summary>
        /// <param name="nomeFantasia"></param>
        /// <param name="razaoSocial"></param>
        /// <param name="cnpj"></param>
        /// <param name="inativo"></param>
        /// <param name="versao"></param>
        /// <param name="habilitaatualizacao"></param>
        /// <param name="atualizacaoonline"></param>
        /// <param name="tipoManutencao"></param>
        public Cliente(string nomeFantasia, string razaoSocial, string cnpj, Boolean inativo,
            string versao, Boolean habilitaatualizacao, Boolean atualizacaoonline, TipoManutencao tipoManutencao)
        {
            this.NomeFantasia = nomeFantasia;
            this.RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
            this.Inativo = inativo;
            this.Versao = versao;
            this.HabilitaAtualizacao = habilitaatualizacao;
            this.AtualizarOnLine = atualizacaoonline;
            this.TipoManutencaoId = tipoManutencao.TipoManutencaoId;
            this.TipoManutencao = tipoManutencao;
        }

    }
}
