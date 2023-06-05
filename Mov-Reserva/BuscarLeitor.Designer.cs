namespace Mov_Reserva
{
    partial class BuscarLeitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarLeitor));
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodLeitor = new System.Windows.Forms.TextBox();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colCodigoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeDoLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
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
            this.colNomeDoLeitor});
            this.dadosGrid.Location = new System.Drawing.Point(11, 59);
            this.dadosGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(532, 270);
            this.dadosGrid.TabIndex = 27;
            this.dadosGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Codigo leitor";
            // 
            // txtCodLeitor
            // 
            this.txtCodLeitor.Location = new System.Drawing.Point(97, 4);
            this.txtCodLeitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodLeitor.Name = "txtCodLeitor";
            this.txtCodLeitor.Size = new System.Drawing.Size(67, 22);
            this.txtCodLeitor.TabIndex = 24;
            this.txtCodLeitor.TextChanged += new System.EventHandler(this.txtCodLeitor_TextChanged);
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(97, 32);
            this.txtNomeLeitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(245, 22);
            this.txtNomeLeitor.TabIndex = 25;
            this.txtNomeLeitor.TextChanged += new System.EventHandler(this.txtNomeLeitor_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nome leitor";
            // 
            // colCodigoLeitor
            // 
            this.colCodigoLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodigoLeitor.FillWeight = 152.2843F;
            this.colCodigoLeitor.HeaderText = "Código";
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
            // BuscarLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 332);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodLeitor);
            this.Controls.Add(this.txtNomeLeitor);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BuscarLeitor";
            this.Text = "Buscar leitor";
            this.Load += new System.EventHandler(this.BuscarLeitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodLeitor;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeDoLeitor;
    }
}