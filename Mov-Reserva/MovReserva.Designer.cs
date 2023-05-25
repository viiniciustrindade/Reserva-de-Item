namespace Mov_Reserva
{
    partial class MovReserva
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovReserva));
            this.cbxTipoMovimento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExemplar = new System.Windows.Forms.TextBox();
            this.txtTipoItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodLeitor = new System.Windows.Forms.TextBox();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataReserva = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpPrazoReserva = new System.Windows.Forms.DateTimePicker();
            this.labels = new System.Windows.Forms.Label();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCarregarItem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCarregarLeitor = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.colCodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumExemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrazoReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTipoMovimento
            // 
            this.cbxTipoMovimento.BackColor = System.Drawing.SystemColors.Window;
            this.cbxTipoMovimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoMovimento.FormattingEnabled = true;
            this.cbxTipoMovimento.Items.AddRange(new object[] {
            "Reservar",
            "Devolver"});
            this.cbxTipoMovimento.Location = new System.Drawing.Point(210, 9);
            this.cbxTipoMovimento.Name = "cbxTipoMovimento";
            this.cbxTipoMovimento.Size = new System.Drawing.Size(94, 24);
            this.cbxTipoMovimento.TabIndex = 1;
            this.cbxTipoMovimento.SelectedIndexChanged += new System.EventHandler(this.cbxTipoMovimento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo movimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo item";
            // 
            // txtCodItem
            // 
            this.txtCodItem.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodItem.Location = new System.Drawing.Point(92, 26);
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.ReadOnly = true;
            this.txtCodItem.Size = new System.Drawing.Size(88, 22);
            this.txtCodItem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome item";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeItem.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeItem.Location = new System.Drawing.Point(293, 26);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.ReadOnly = true;
            this.txtNomeItem.Size = new System.Drawing.Size(607, 22);
            this.txtNomeItem.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exemplar";
            // 
            // txtExemplar
            // 
            this.txtExemplar.BackColor = System.Drawing.SystemColors.Window;
            this.txtExemplar.Location = new System.Drawing.Point(92, 54);
            this.txtExemplar.Name = "txtExemplar";
            this.txtExemplar.ReadOnly = true;
            this.txtExemplar.Size = new System.Drawing.Size(88, 22);
            this.txtExemplar.TabIndex = 8;
            // 
            // txtTipoItem
            // 
            this.txtTipoItem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipoItem.Location = new System.Drawing.Point(293, 54);
            this.txtTipoItem.Name = "txtTipoItem";
            this.txtTipoItem.ReadOnly = true;
            this.txtTipoItem.Size = new System.Drawing.Size(254, 22);
            this.txtTipoItem.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Localização";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocalizacao.Location = new System.Drawing.Point(639, 54);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.ReadOnly = true;
            this.txtLocalizacao.Size = new System.Drawing.Size(261, 22);
            this.txtLocalizacao.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Codigo leitor";
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodLeitor.Location = new System.Drawing.Point(96, 28);
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.ReadOnly = true;
            this.txtCodLeitor.Size = new System.Drawing.Size(84, 22);
            this.txtCodLeitor.TabIndex = 14;
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLeitor.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeLeitor.Location = new System.Drawing.Point(297, 28);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.ReadOnly = true;
            this.txtNomeLeitor.Size = new System.Drawing.Size(603, 22);
            this.txtNomeLeitor.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nome leitor";
            // 
            // dtpDataReserva
            // 
            this.dtpDataReserva.Location = new System.Drawing.Point(95, 219);
            this.dtpDataReserva.Name = "dtpDataReserva";
            this.dtpDataReserva.Size = new System.Drawing.Size(301, 22);
            this.dtpDataReserva.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data reserva";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Prazo reserva";
            // 
            // dtpPrazoReserva
            // 
            this.dtpPrazoReserva.Location = new System.Drawing.Point(499, 219);
            this.dtpPrazoReserva.Name = "dtpPrazoReserva";
            this.dtpPrazoReserva.Size = new System.Drawing.Size(308, 22);
            this.dtpPrazoReserva.TabIndex = 20;
            // 
            // labels
            // 
            this.labels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labels.AutoSize = true;
            this.labels.Location = new System.Drawing.Point(745, 15);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(60, 16);
            this.labels.TabIndex = 21;
            this.labels.Text = "Situação";
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSituacao.Enabled = false;
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Items.AddRange(new object[] {
            "Disponivel",
            "Reservado"});
            this.cbxSituacao.Location = new System.Drawing.Point(811, 12);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(102, 24);
            this.cbxSituacao.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCarregarItem);
            this.groupBox1.Controls.Add(this.txtLocalizacao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTipoItem);
            this.groupBox1.Controls.Add(this.txtExemplar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNomeItem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 95);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações item";
            // 
            // btnCarregarItem
            // 
            this.btnCarregarItem.FlatAppearance.BorderSize = 0;
            this.btnCarregarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarItem.Image = global::Mov_Reserva.Properties.Resources.magnifying_glass_icon;
            this.btnCarregarItem.Location = new System.Drawing.Point(186, 26);
            this.btnCarregarItem.Name = "btnCarregarItem";
            this.btnCarregarItem.Size = new System.Drawing.Size(23, 22);
            this.btnCarregarItem.TabIndex = 13;
            this.btnCarregarItem.UseVisualStyleBackColor = true;
            this.btnCarregarItem.Click += new System.EventHandler(this.btnCarregarItem_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnCarregarLeitor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCodLeitor);
            this.groupBox2.Controls.Add(this.txtNomeLeitor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(7, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 68);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações leitor";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // btnCarregarLeitor
            // 
            this.btnCarregarLeitor.FlatAppearance.BorderSize = 0;
            this.btnCarregarLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarLeitor.Image = global::Mov_Reserva.Properties.Resources.magnifying_glass_icon;
            this.btnCarregarLeitor.Location = new System.Drawing.Point(186, 28);
            this.btnCarregarLeitor.Name = "btnCarregarLeitor";
            this.btnCarregarLeitor.Size = new System.Drawing.Size(23, 22);
            this.btnCarregarLeitor.TabIndex = 17;
            this.btnCarregarLeitor.UseVisualStyleBackColor = true;
            this.btnCarregarLeitor.Click += new System.EventHandler(this.btnCarregarLeitor_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(813, 218);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodItem,
            this.colTipoMovimento,
            this.colSituacao,
            this.colNomeItem,
            this.colNumExemplar,
            this.colLocalizacao,
            this.colTipoItem,
            this.colCodLeitor,
            this.colNomeLeitor,
            this.colDataRes,
            this.colPrazoReserva});
            this.dadosGrid.Location = new System.Drawing.Point(7, 248);
            this.dadosGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(906, 320);
            this.dadosGrid.TabIndex = 26;
            this.dadosGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid_CellDoubleClick);
            // 
            // colCodItem
            // 
            this.colCodItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodItem.FillWeight = 152.2843F;
            this.colCodItem.HeaderText = "Codigo item";
            this.colCodItem.MinimumWidth = 6;
            this.colCodItem.Name = "colCodItem";
            this.colCodItem.ReadOnly = true;
            // 
            // colTipoMovimento
            // 
            this.colTipoMovimento.HeaderText = "Tipo Movimento";
            this.colTipoMovimento.MinimumWidth = 6;
            this.colTipoMovimento.Name = "colTipoMovimento";
            this.colTipoMovimento.ReadOnly = true;
            this.colTipoMovimento.Visible = false;
            // 
            // colSituacao
            // 
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.MinimumWidth = 6;
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            // 
            // colNomeItem
            // 
            this.colNomeItem.HeaderText = "Item";
            this.colNomeItem.MinimumWidth = 6;
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            // 
            // colNumExemplar
            // 
            this.colNumExemplar.HeaderText = "Exemplar";
            this.colNumExemplar.MinimumWidth = 6;
            this.colNumExemplar.Name = "colNumExemplar";
            this.colNumExemplar.ReadOnly = true;
            this.colNumExemplar.Visible = false;
            // 
            // colLocalizacao
            // 
            this.colLocalizacao.HeaderText = "Localização";
            this.colLocalizacao.MinimumWidth = 6;
            this.colLocalizacao.Name = "colLocalizacao";
            this.colLocalizacao.ReadOnly = true;
            this.colLocalizacao.Visible = false;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "Tipo Item";
            this.colTipoItem.MinimumWidth = 6;
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            this.colTipoItem.Visible = false;
            // 
            // colCodLeitor
            // 
            this.colCodLeitor.HeaderText = "Codigo Leitor";
            this.colCodLeitor.MinimumWidth = 6;
            this.colCodLeitor.Name = "colCodLeitor";
            this.colCodLeitor.ReadOnly = true;
            // 
            // colNomeLeitor
            // 
            this.colNomeLeitor.HeaderText = "Nome Leitor";
            this.colNomeLeitor.MinimumWidth = 6;
            this.colNomeLeitor.Name = "colNomeLeitor";
            this.colNomeLeitor.ReadOnly = true;
            // 
            // colDataRes
            // 
            this.colDataRes.HeaderText = "Data reserva";
            this.colDataRes.MinimumWidth = 6;
            this.colDataRes.Name = "colDataRes";
            this.colDataRes.ReadOnly = true;
            // 
            // colPrazoReserva
            // 
            this.colPrazoReserva.HeaderText = "Prazo Reserva";
            this.colPrazoReserva.MinimumWidth = 6;
            this.colPrazoReserva.Name = "colPrazoReserva";
            this.colPrazoReserva.ReadOnly = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(7, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 22);
            this.btnNovo.TabIndex = 27;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // MovReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 574);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbxSituacao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labels);
            this.Controls.Add(this.dtpPrazoReserva);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDataReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTipoMovimento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovReserva";
            this.Text = "Reserva de Item";
            this.Load += new System.EventHandler(this.MovReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipoMovimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExemplar;
        private System.Windows.Forms.TextBox txtTipoItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodLeitor;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataReserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpPrazoReserva;
        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCarregarItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.Button btnCarregarLeitor;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumExemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrazoReserva;
    }
}

