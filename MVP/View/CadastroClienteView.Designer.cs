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
            this.AdicionarButton = new System.Windows.Forms.Button();
            this.ClientesGrid = new System.Windows.Forms.DataGridView();
            this.NomeClienteGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.ErroLabel = new System.Windows.Forms.Label();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.LimparButton = new System.Windows.Forms.Button();
            this.SalvarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdicionarButton
            // 
            this.AdicionarButton.Location = new System.Drawing.Point(159, 6);
            this.AdicionarButton.Name = "AdicionarButton";
            this.AdicionarButton.Size = new System.Drawing.Size(75, 23);
            this.AdicionarButton.TabIndex = 3;
            this.AdicionarButton.Text = "Adicionar";
            this.AdicionarButton.UseVisualStyleBackColor = true;
            // 
            // ClientesGrid
            // 
            this.ClientesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeClienteGrid});
            this.ClientesGrid.Location = new System.Drawing.Point(12, 48);
            this.ClientesGrid.Name = "ClientesGrid";
            this.ClientesGrid.Size = new System.Drawing.Size(465, 250);
            this.ClientesGrid.TabIndex = 4;
            // 
            // NomeClienteGrid
            // 
            this.NomeClienteGrid.DataPropertyName = "Nome";
            this.NomeClienteGrid.HeaderText = "Nome";
            this.NomeClienteGrid.Name = "NomeClienteGrid";
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Location = new System.Drawing.Point(9, 12);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(38, 13);
            this.NomeLabel.TabIndex = 5;
            this.NomeLabel.Text = "Nome:";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(53, 9);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.NomeTextBox.TabIndex = 6;
            // 
            // ErroLabel
            // 
            this.ErroLabel.AutoSize = true;
            this.ErroLabel.ForeColor = System.Drawing.Color.Red;
            this.ErroLabel.Location = new System.Drawing.Point(50, 32);
            this.ErroLabel.Name = "ErroLabel";
            this.ErroLabel.Size = new System.Drawing.Size(35, 13);
            this.ErroLabel.TabIndex = 7;
            this.ErroLabel.Text = "label1";
            this.ErroLabel.Visible = false;
            // 
            // RemoverButton
            // 
            this.RemoverButton.Location = new System.Drawing.Point(240, 6);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(75, 23);
            this.RemoverButton.TabIndex = 8;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.UseVisualStyleBackColor = true;
            // 
            // LimparButton
            // 
            this.LimparButton.Location = new System.Drawing.Point(321, 6);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(75, 23);
            this.LimparButton.TabIndex = 9;
            this.LimparButton.Text = "Limpar";
            this.LimparButton.UseVisualStyleBackColor = true;
            // 
            // SalvarButton
            // 
            this.SalvarButton.Location = new System.Drawing.Point(402, 6);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(75, 23);
            this.SalvarButton.TabIndex = 10;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 312);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.LimparButton);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.ErroLabel);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.NomeLabel);
            this.Controls.Add(this.ClientesGrid);
            this.Controls.Add(this.AdicionarButton);
            this.Name = "Form1";
            this.Text = "Cadastro Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AdicionarButton;
        private System.Windows.Forms.DataGridView ClientesGrid;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Label ErroLabel;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button LimparButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeClienteGrid;
        private System.Windows.Forms.Button SalvarButton;
    }
}

