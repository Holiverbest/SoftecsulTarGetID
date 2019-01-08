using SoftecsulTarGetID.SoftecsulTarGetIDController;
using SoftecsulTarGetID.SoftecsulTarGetIDModel;
using SoftecsulTarGetID.SoftecsulTarGetIDService.Exception;
using System;
using System.Windows.Forms;
using DllValidacao;

namespace SoftecsulTarGetID.SoftecsulTarGetIDView
{
    public partial class frmCadClientes : Form
    {

        private TipoManutencaoController tipoManutencao;
        private ClienteController clienteController;

        public frmCadClientes(object cliente)
        {
            InitializeComponent();

            tipoManutencao = new TipoManutencaoController();
            clienteController = new ClienteController();
            Cliente c = (Cliente)Convert.ChangeType(cliente, typeof(Cliente));

            if (c.Tag == "A")
            {
                btnSalvar.Text = "Alterar";

                txtClienteId.Text = c.ClienteId.ToString();
                txtNomeFantasia.Text = c.NomeFantasia;
                txtRazaoSocial.Text = c.RazaoSocial;
                txtVersao.Text = c.Versao;
                mtbCNPJ.Text = c.CNPJ;
                cbxInativo.Checked = c.Inativo;
                cbxAtualizaOnLine.Checked = c.AtualizarOnLine;
                cbxHabilitaAtualizacao.Checked = c.HabilitaAtualizacao;
                dgvClienteEquipamento.DataSource = c.ClienteEquipamentos;

                TipoManutencao tp = new TipoManutencao();
                cboTipoManutencao.DataSource = tipoManutencao.ListaTipoManutencao();
                cboTipoManutencao.DisplayMember = "Tipo";
                cboTipoManutencao.ValueMember = "TipoManutencaoId";
                cboTipoManutencao.SelectedValue = c.TipoManutencaoId;
            }

            if (c.Tag == "I")
            {



            }
        }

        //private void mnuSalvar_Click(object sender, EventArgs e)
        //{
        //    this.Tag = "S";
        //    Cliente c = new Cliente();

        //    c.ClienteId = Convert.ToInt32(txtClienteId.Text);

        //    c.NomeFantasia = txtNomeFantasia.Text;
        //    c.RazaoSocial = txtRazaoSocial.Text;
        //    c.Versao = txtVersao.Text;
        //    c.CNPJ = mtbCNPJ.Text;
        //    c.Inativo = cbxInativo.Checked;
        //    c.AtualizarOnLine = cbxAtualizaOnLine.Checked;
        //    c.HabilitaAtualizacao = cbxHabilitaAtualizacao.Checked;
        //    c.TipoManutencaoId = Convert.ToInt32(cboTipoManutencao.SelectedValue);
        //    clienteController.Update(c);
        //    this.Hide();
        //}

        //private void mnuCancelar_Click(object sender, EventArgs e)
        //{
        //    this.Tag = "C";
        //    this.Close();
        //}

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Cliente c = new Cliente();          

            //A DLL de validação esta no projeto Softecsul.Validacao.
            //Se houver a necessidade de ajuste tem que alterar no proeto a dll e importar novamente para o projeto que esta utilizando.
            Validacao valida = new Validacao();
            //Validadno nome fantasia         
            valida.ValidaObjeto(txtNomeFantasia, true, "TN", 100, "Cadastro", "", "", "", "", "", "Cadastro");
            valida.ValidaObjeto(txtRazaoSocial, true, "TN", 100, "Cadastro", "", "", "", "", "", "Cadastro");
            valida.ValidaObjeto(mtbCNPJ, true, "CNPJ", 18, "Não", "Cliente", "CNPJ", "I", "", "", "Cadastro");
            valida.ValidaObjeto(cbxInativo, true, "BOOL", 5, "Não", "Cliente", "", "", "", "", "Cadastro");
            valida.ValidaObjeto(cbxHabilitaAtualizacao , true, "BOOL", 5, "Não", "Cliente", "", "", "", "", "Cadastro");
            valida.ValidaObjeto(cbxAtualizaOnLine , true, "BOOL", 5, "Não", "Cliente", "", "", "", "", "Cadastro");
            valida.ValidaObjeto(txtIE, false, "IE", 20, "SC", "Cliente", "IE", "I", "", "", "Cadastro");


            if (valida.NumeroErros == 0)
            {

                c.ClienteId = Convert.ToInt32(txtClienteId.Text);

                c.NomeFantasia = txtNomeFantasia.Text;
                c.RazaoSocial = txtRazaoSocial.Text;
                c.Versao = txtVersao.Text;
                c.CNPJ = mtbCNPJ.Text;
                c.Inativo = cbxInativo.Checked;
                c.AtualizarOnLine = cbxAtualizaOnLine.Checked;
                c.HabilitaAtualizacao = cbxHabilitaAtualizacao.Checked;
                c.TipoManutencaoId = Convert.ToInt32(cboTipoManutencao.SelectedValue);

                clienteController.Update(c);
                this.Tag = "S";
                this.Hide();

            }

            //var result = DataAnnotation.ValidateEntity<Cliente>(c);

            //if (result.HasError)
            //{
            //    string msg = "";
            //    foreach (var erro in result.ValidationErrors)
            //    {
            //        //var n = erro.MemberNames;
            //        //if (n == "NomeFantasia")
            //        //{
            //        //    errorProvider1.SetError(txtNomeFantasia, erro.ErrorMessage);
            //        //}
            //        //else
            //        //{
            //        //    errorProvider1.SetError(txtNomeFantasia, "");
            //        //}

            //        //if (erro.MemberNames.Equals("RazaoSocial"))
            //        //{
            //        //    errorProvider1.SetError(txtNomeFantasia, erro.ErrorMessage);
            //        //}
            //        //else
            //        //{
            //        //    errorProvider1.SetError(txtNomeFantasia, "");
            //        //}

            //        msg = msg + erro.ErrorMessage + "\n";
            //    }
            //    //Conversado com o Anderson e passado que o error provider não tarbalha com o dataanotatio
            //    MessageBox.Show("Erro: " + msg);

            //}
            //else
            //{
            //    clienteController.Update(c);
            //    this.Hide();
            //}

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "C";
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Tag = "C";
            this.Close();
        }
    }
}
