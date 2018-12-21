using SoftecsulTarGetID.SoftecsulTarGetIDModel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SoftecsulTarGetID.SoftecsulTarGetIDController;
using Microsoft.EntityFrameworkCore;


namespace SoftecsulTarGetID.SoftecsulTarGetIDView
{
    public partial class frmConClientes : Form
    {

        private ClienteEquipamentoController clienteEquipamentoController;
        private TipoManutencaoController tipoManutencao;
        private ClienteController clienteController;
        private StatusRegistroController statusRegistroController;

        public frmConClientes()
        {
            InitializeComponent();
            clienteEquipamentoController = new ClienteEquipamentoController();
            clienteController = new ClienteController();
            tipoManutencao = new TipoManutencaoController();
            statusRegistroController = new StatusRegistroController();
        }

        private void frmConClientes_Load(object sender, EventArgs e)
        {


            //Configuration cx = new Configuration();

            ///http://www.macoratti.net/16/01/ef_erros1.htm
            ///https://www.devmedia.com.br/entity-framework-como-fazer-seu-primeiro-mapeamento-objeto-relacional/38756
            //_context = new TarGetIDContext();
            //ClienteService bd = new ClienteService(_context);
            //bd.Insert(cli);
            //Correto

            //clienteController.Create(cli);
            dgvClientes.DataSource = clienteController.ListaTodos();


            if (dgvClientes.Rows.Count > 0)
            {


                //dgvClientes.Columns["NumBanco"].HeaderText = "N° Banco"
                //.Columns("HomePage").HeaderText = "Home Page"

            }
        }

        private void dgvClientes_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount > 0)
            {
                if (dgvClientes.SelectedRows.Count == 1)
                {
                    Cliente c = (Cliente)Convert.ChangeType(dgvClientes.CurrentRow.DataBoundItem, typeof(Cliente));
                    // lblTipomanutecao.Text = tipoManutencao.
                    ListaClientesDetalhes(c.ClienteId);
                    TipoManutencao tm = (TipoManutencao)Convert.ChangeType(tipoManutencao.Details(c.TipoManutencaoId), typeof(TipoManutencao));

                    lblValorTipoManutencao.Text = tm.Tipo;
                }
            }
        }

        private void ListaClientesDetalhes(int Id)
        {

            dgvEquipamentos.DataSource = clienteEquipamentoController.ListaClienteEquipamentos(Id);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //(!String.IsNullOrEmpty(emailAuto)
            Cliente c = new Cliente();
            if (!string.IsNullOrEmpty(txtVersao.Text))
            {
                c.Versao = txtVersao.Text;
            }
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                c.NomeFantasia = txtNome.Text;
            }

            if ((!string.IsNullOrEmpty(mtbCNPJ.Text)) && (mtbCNPJ.Text != "  .   .   /    -"))
            {
                c.CNPJ = mtbCNPJ.Text;

            }

            dgvClientes.DataSource = clienteController.FiltraClientes(c);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount > 0)
            {

                if (dgvClientes.SelectedRows.Count == 1)
                {
                    try
                    {
                        int indexGrid = dgvClientes.CurrentRow.Index;
                        Cliente c = (Cliente)Convert.ChangeType(dgvClientes.CurrentRow.DataBoundItem, typeof(Cliente));
                        StatusRegistro sr = new StatusRegistro(c.ToString(), c.ClienteId.ToString(), "Anderson");

                        if (statusRegistroController.Busca(sr) == false)
                        {
                            //Não encontrou ninguém alterando o registros, inclui um registro e bloqueia para os outros
                            statusRegistroController.Create(sr);

                            Cliente cliente = (Cliente)Convert.ChangeType(clienteController.Edit(c.ClienteId), typeof(Cliente));
                            cliente.ClienteEquipamentos = clienteEquipamentoController.ListaClienteEquipamentos(c.ClienteId);
                            cliente.TipoManutencao = (TipoManutencao)Convert.ChangeType(tipoManutencao.Details(c.TipoManutencaoId), typeof(TipoManutencao));
                            cliente.Tag = "A";
                            frmCadClientes fcc = new frmCadClientes(cliente);

                            //fcc.Show();

                            fcc.ShowDialog();

                            clienteController = new ClienteController();

                            dgvClientes.DataSource = clienteController.ListaTodos();

                            statusRegistroController.Delete(sr.StatusRegistroId);
                            fcc.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("Clique no menu Pesquisar, e Selecione uma Cliente para Alterar");
            }
        }

        private void btnAlterar2_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount > 0)
            {

                if (dgvClientes.SelectedRows.Count == 1)
                {
                    try
                    {
                        Cliente c = (Cliente)Convert.ChangeType(dgvClientes.CurrentRow.DataBoundItem, typeof(Cliente));

                        StatusRegistro sr = new StatusRegistro(c.ToString(), c.ClienteId.ToString(), "Marcio");

                        if (statusRegistroController.Busca(sr) == false)
                        {
                            //Não encontrou ninguém alterando o registros, inclui um registro e bloqueia para os outros
                            statusRegistroController.Create(sr);

                            Cliente cliente = (Cliente)Convert.ChangeType(clienteController.Edit(c.ClienteId), typeof(Cliente));
                            cliente.ClienteEquipamentos = clienteEquipamentoController.ListaClienteEquipamentos(c.ClienteId);
                            cliente.TipoManutencao = (TipoManutencao)Convert.ChangeType(tipoManutencao.Details(c.TipoManutencaoId), typeof(TipoManutencao));
                            cliente.Tag = "A";
                            frmCadClientes fcc = new frmCadClientes(cliente);
                            //Para simular duas pessoa alterando, abrir em modo Show
                            //fcc.Show();
                            fcc.ShowDialog();

                            dgvClientes.DataSource = clienteController.ListaTodos();


                            statusRegistroController.Delete(sr.StatusRegistroId);
                            fcc.Dispose();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Clique no menu Pesquisar, e Selecione um Cliente para Alterar");
                }
            }
            else
            {
                MessageBox.Show("Clique no menu Pesquisar, e Selecione uma Cliente para Alterar");
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Tag = "I";
                frmCadClientes fcc = new frmCadClientes(cliente);
                fcc.ShowDialog();
                //Verifica se o usuário cancelou (se cancelou não precisa atualizar nada).
                // '------------------------------------------------------------------------
                if (fcc.Tag.Equals("S"))
                {
                    dgvClientes.DataSource = clienteController.ListaTodos();
                    dgvClientes.ClearSelection();
                    ListaClientesDetalhes(cliente.ClienteId);
                }
                fcc.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount > 0)
            {
                if (dgvClientes.SelectedRows.Count == 1)
                {
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        try
                        {
                            //Sua rotina de exclusão
                            Cliente c = (Cliente)Convert.ChangeType(dgvClientes.CurrentRow.DataBoundItem, typeof(Cliente));
                            clienteController.Delete(c.ClienteId);

                            //Confirmando exclusão para o usuário
                            MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvClientes.DataSource = clienteController.ListaTodos();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro .: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Clique no menu Pesquisar, e Selecione um Cliente para Alterar", "ATENÇÃO!!!", MessageBoxButtons.YesNo);
                }
            }
            else
            {
                MessageBox.Show("Clique no menu Pesquisar, e Selecione uma Cliente para Alterar");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
