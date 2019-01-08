namespace SoftecsulTarGetID.SoftecsulTarGetIDView
{
    partial class frmCadClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gpxTipomanutencao = new System.Windows.Forms.GroupBox();
            this.cboTipoManutencao = new System.Windows.Forms.ComboBox();
            this.gpxClientesEquipamento = new System.Windows.Forms.GroupBox();
            this.dgvClienteEquipamento = new System.Windows.Forms.DataGridView();
            this.cbxAtualizaOnLine = new System.Windows.Forms.CheckBox();
            this.txtVersao = new System.Windows.Forms.TextBox();
            this.cbxHabilitaAtualizacao = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxInativo = new System.Windows.Forms.CheckBox();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpxTipomanutencao.SuspendLayout();
            this.gpxClientesEquipamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteEquipamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtIE);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gpxTipomanutencao);
            this.panel1.Controls.Add(this.gpxClientesEquipamento);
            this.panel1.Controls.Add(this.cbxAtualizaOnLine);
            this.panel1.Controls.Add(this.txtVersao);
            this.panel1.Controls.Add(this.cbxHabilitaAtualizacao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxInativo);
            this.panel1.Controls.Add(this.mtbCNPJ);
            this.panel1.Controls.Add(this.txtRazaoSocial);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtClienteId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNomeFantasia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 680);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(167, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 42);
            this.panel3.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.errorProvider1.SetIconAlignment(this.btnClose, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnClose.Location = new System.Drawing.Point(671, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 680);
            this.panel2.TabIndex = 23;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.errorProvider1.SetIconAlignment(this.btnCancelar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnCancelar.Location = new System.Drawing.Point(3, 84);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 42);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.errorProvider1.SetIconAlignment(this.btnSalvar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnSalvar.Location = new System.Drawing.Point(3, 42);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(161, 42);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 42);
            this.panel4.TabIndex = 0;
            // 
            // gpxTipomanutencao
            // 
            this.gpxTipomanutencao.Controls.Add(this.cboTipoManutencao);
            this.gpxTipomanutencao.Location = new System.Drawing.Point(595, 192);
            this.gpxTipomanutencao.Name = "gpxTipomanutencao";
            this.gpxTipomanutencao.Size = new System.Drawing.Size(269, 71);
            this.gpxTipomanutencao.TabIndex = 22;
            this.gpxTipomanutencao.TabStop = false;
            this.gpxTipomanutencao.Text = "Tipo Manutenção";
            // 
            // cboTipoManutencao
            // 
            this.cboTipoManutencao.FormattingEnabled = true;
            this.cboTipoManutencao.Location = new System.Drawing.Point(6, 41);
            this.cboTipoManutencao.Name = "cboTipoManutencao";
            this.cboTipoManutencao.Size = new System.Drawing.Size(301, 29);
            this.cboTipoManutencao.TabIndex = 0;
            // 
            // gpxClientesEquipamento
            // 
            this.gpxClientesEquipamento.Controls.Add(this.dgvClienteEquipamento);
            this.gpxClientesEquipamento.Location = new System.Drawing.Point(288, 300);
            this.gpxClientesEquipamento.Name = "gpxClientesEquipamento";
            this.gpxClientesEquipamento.Size = new System.Drawing.Size(582, 368);
            this.gpxClientesEquipamento.TabIndex = 21;
            this.gpxClientesEquipamento.TabStop = false;
            this.gpxClientesEquipamento.Text = "Cliente Equipamentos";
            // 
            // dgvClienteEquipamento
            // 
            this.dgvClienteEquipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteEquipamento.Location = new System.Drawing.Point(20, 54);
            this.dgvClienteEquipamento.Name = "dgvClienteEquipamento";
            this.dgvClienteEquipamento.RowTemplate.Height = 24;
            this.dgvClienteEquipamento.Size = new System.Drawing.Size(562, 308);
            this.dgvClienteEquipamento.TabIndex = 0;
            // 
            // cbxAtualizaOnLine
            // 
            this.cbxAtualizaOnLine.AutoSize = true;
            this.cbxAtualizaOnLine.Location = new System.Drawing.Point(551, 273);
            this.cbxAtualizaOnLine.Name = "cbxAtualizaOnLine";
            this.cbxAtualizaOnLine.Size = new System.Drawing.Size(154, 25);
            this.cbxAtualizaOnLine.TabIndex = 20;
            this.cbxAtualizaOnLine.Text = "Atualizar On-Line";
            this.cbxAtualizaOnLine.UseVisualStyleBackColor = true;
            // 
            // txtVersao
            // 
            this.txtVersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtVersao.Enabled = false;
            this.txtVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersao.Location = new System.Drawing.Point(768, 169);
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(96, 22);
            this.txtVersao.TabIndex = 19;
            // 
            // cbxHabilitaAtualizacao
            // 
            this.cbxHabilitaAtualizacao.AutoSize = true;
            this.cbxHabilitaAtualizacao.Location = new System.Drawing.Point(704, 273);
            this.cbxHabilitaAtualizacao.Name = "cbxHabilitaAtualizacao";
            this.cbxHabilitaAtualizacao.Size = new System.Drawing.Size(173, 25);
            this.cbxHabilitaAtualizacao.TabIndex = 18;
            this.cbxHabilitaAtualizacao.Text = "Habilita Atualização";
            this.cbxHabilitaAtualizacao.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Versão";
            // 
            // cbxInativo
            // 
            this.cbxInativo.AutoSize = true;
            this.cbxInativo.Location = new System.Drawing.Point(445, 273);
            this.cbxInativo.Name = "cbxInativo";
            this.cbxInativo.Size = new System.Drawing.Size(82, 25);
            this.cbxInativo.TabIndex = 16;
            this.cbxInativo.Text = "Inativo";
            this.cbxInativo.UseVisualStyleBackColor = true;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.Location = new System.Drawing.Point(288, 211);
            this.mtbCNPJ.Mask = "00,000,000/0000-00";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(176, 28);
            this.mtbCNPJ.TabIndex = 15;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(288, 177);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(299, 28);
            this.txtRazaoSocial.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Razão Social";
            // 
            // txtClienteId
            // 
            this.txtClienteId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtClienteId.Enabled = false;
            this.txtClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteId.Location = new System.Drawing.Point(766, 121);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(104, 22);
            this.txtClienteId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(288, 119);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(299, 28);
            this.txtNomeFantasia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "IE";
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(288, 245);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(151, 28);
            this.txtIE.TabIndex = 25;
            // 
            // frmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 680);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gpxTipomanutencao.ResumeLayout(false);
            this.gpxClientesEquipamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteEquipamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpxClientesEquipamento;
        private System.Windows.Forms.CheckBox cbxAtualizaOnLine;
        private System.Windows.Forms.TextBox txtVersao;
        private System.Windows.Forms.CheckBox cbxHabilitaAtualizacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxInativo;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.GroupBox gpxTipomanutencao;
        private System.Windows.Forms.ComboBox cboTipoManutencao;
        private System.Windows.Forms.DataGridView dgvClienteEquipamento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.Label label6;
    }
}