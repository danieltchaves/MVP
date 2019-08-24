namespace MVP
{
    partial class Form1
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
            this.bntAdicionar = new System.Windows.Forms.Button();
            this.ClientesGrid = new System.Windows.Forms.DataGridView();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.IDClienteGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeClienteGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAdicionar
            // 
            this.bntAdicionar.Location = new System.Drawing.Point(159, 6);
            this.bntAdicionar.Name = "bntAdicionar";
            this.bntAdicionar.Size = new System.Drawing.Size(75, 23);
            this.bntAdicionar.TabIndex = 3;
            this.bntAdicionar.Text = "Adicionar";
            this.bntAdicionar.UseVisualStyleBackColor = true;
            this.bntAdicionar.Click += new System.EventHandler(this.executeAdicionar);
            // 
            // ClientesGrid
            // 
            this.ClientesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDClienteGrid,
            this.NomeClienteGrid});
            this.ClientesGrid.Location = new System.Drawing.Point(12, 48);
            this.ClientesGrid.Name = "ClientesGrid";
            this.ClientesGrid.Size = new System.Drawing.Size(412, 250);
            this.ClientesGrid.TabIndex = 4;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 12);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 6;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(50, 32);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(35, 13);
            this.lbError.TabIndex = 7;
            this.lbError.Text = "label1";
            this.lbError.Visible = false;
            // 
            // IDClienteGrid
            // 
            this.IDClienteGrid.HeaderText = "Id";
            this.IDClienteGrid.Name = "IDClienteGrid";
            // 
            // NomeClienteGrid
            // 
            this.NomeClienteGrid.HeaderText = "Nome";
            this.NomeClienteGrid.Name = "NomeClienteGrid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.executeRemover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.ClientesGrid);
            this.Controls.Add(this.bntAdicionar);
            this.Name = "Form1";
            this.Text = "Cadastro Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntAdicionar;
        private System.Windows.Forms.DataGridView ClientesGrid;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDClienteGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeClienteGrid;
        private System.Windows.Forms.Button button1;
    }
}

