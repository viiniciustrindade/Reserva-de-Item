namespace Mov_Reserva
{
    partial class SelecionarLeitor
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodLeitor = new System.Windows.Forms.TextBox();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.colCodigoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeDoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexoDoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Codigo leitor";
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.Location = new System.Drawing.Point(101, 6);
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.Size = new System.Drawing.Size(67, 22);
            this.txtCodLeitor.TabIndex = 19;
            this.txtCodLeitor.TextChanged += new System.EventHandler(this.txtCodLeitor_TextChanged);
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLeitor.Location = new System.Drawing.Point(101, 34);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(446, 22);
            this.txtNomeLeitor.TabIndex = 20;
            this.txtNomeLeitor.TextChanged += new System.EventHandler(this.txtNomeLeitor_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nome leitor";
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoLeitor,
            this.colNomeDoLeitor,
            this.colCpf,
            this.colEmail,
            this.colRG,
            this.colCelular,
            this.colTelefone,
            this.colRua,
            this.colCidade,
            this.colBairro,
            this.colUf,
            this.colNumero,
            this.colCep,
            this.colDataNasc,
            this.colSexoDoLeitor});
            this.dadosGrid.Location = new System.Drawing.Point(15, 62);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(532, 270);
            this.dadosGrid.TabIndex = 22;
            this.dadosGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid_CellDoubleClick);
            // 
            // colCodigoLeitor
            // 
            this.colCodigoLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodigoLeitor.FillWeight = 152.2843F;
            this.colCodigoLeitor.HeaderText = "Codigo";
            this.colCodigoLeitor.MinimumWidth = 6;
            this.colCodigoLeitor.Name = "colCodigoLeitor";
            this.colCodigoLeitor.ReadOnly = true;
            this.colCodigoLeitor.Width = 80;
            // 
            // colNomeDoLeitor
            // 
            this.colNomeDoLeitor.FillWeight = 73.85786F;
            this.colNomeDoLeitor.HeaderText = "Nome";
            this.colNomeDoLeitor.MinimumWidth = 6;
            this.colNomeDoLeitor.Name = "colNomeDoLeitor";
            this.colNomeDoLeitor.ReadOnly = true;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "CPF";
            this.colCpf.MinimumWidth = 6;
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            this.colCpf.ToolTipText = "000.000.000-00";
            this.colCpf.Visible = false;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Visible = false;
            // 
            // colRG
            // 
            this.colRG.HeaderText = "RG";
            this.colRG.MinimumWidth = 6;
            this.colRG.Name = "colRG";
            this.colRG.ReadOnly = true;
            this.colRG.Visible = false;
            // 
            // colCelular
            // 
            this.colCelular.HeaderText = "Celular";
            this.colCelular.MinimumWidth = 6;
            this.colCelular.Name = "colCelular";
            this.colCelular.ReadOnly = true;
            this.colCelular.Visible = false;
            // 
            // colTelefone
            // 
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.MinimumWidth = 6;
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Visible = false;
            // 
            // colRua
            // 
            this.colRua.HeaderText = "Rua";
            this.colRua.MinimumWidth = 6;
            this.colRua.Name = "colRua";
            this.colRua.ReadOnly = true;
            this.colRua.Visible = false;
            // 
            // colCidade
            // 
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.MinimumWidth = 6;
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            this.colCidade.Visible = false;
            // 
            // colBairro
            // 
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.MinimumWidth = 6;
            this.colBairro.Name = "colBairro";
            this.colBairro.ReadOnly = true;
            this.colBairro.Visible = false;
            // 
            // colUf
            // 
            this.colUf.HeaderText = "UF";
            this.colUf.MinimumWidth = 6;
            this.colUf.Name = "colUf";
            this.colUf.ReadOnly = true;
            this.colUf.Visible = false;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Numero";
            this.colNumero.MinimumWidth = 6;
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Visible = false;
            // 
            // colCep
            // 
            this.colCep.HeaderText = "Cep";
            this.colCep.MinimumWidth = 6;
            this.colCep.Name = "colCep";
            this.colCep.ReadOnly = true;
            this.colCep.Visible = false;
            // 
            // colDataNasc
            // 
            this.colDataNasc.HeaderText = "Data de Nascimento";
            this.colDataNasc.MinimumWidth = 6;
            this.colDataNasc.Name = "colDataNasc";
            this.colDataNasc.ReadOnly = true;
            this.colDataNasc.Visible = false;
            // 
            // colSexoDoLeitor
            // 
            this.colSexoDoLeitor.FillWeight = 73.85786F;
            this.colSexoDoLeitor.HeaderText = "Sexo";
            this.colSexoDoLeitor.MinimumWidth = 6;
            this.colSexoDoLeitor.Name = "colSexoDoLeitor";
            this.colSexoDoLeitor.ReadOnly = true;
            this.colSexoDoLeitor.Visible = false;
            // 
            // SelecionarLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 344);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodLeitor);
            this.Controls.Add(this.txtNomeLeitor);
            this.Controls.Add(this.label8);
            this.Name = "SelecionarLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar leitor";
            this.Load += new System.EventHandler(this.SelecionarLeitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodLeitor;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeDoLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexoDoLeitor;
    }
}