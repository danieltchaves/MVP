using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace MVP
{
    public partial class Form1 : Form, ICadastroClienteView
    {
        public string Nome
        {
            get => NomeTextBox.Text;
            set => NomeTextBox.Text = value;
        }
        public string Erro
        {
            get => ErroLabel.Text;
            set
            {
                ErroLabel.Text = value;
                ErroLabel.Visible = !string.IsNullOrWhiteSpace(value);
            }
        }
        public event EventHandler Adicionar;
        public event EventHandler Remover;
        public event EventHandler Limpar;

        public Form1()
        {
            InitializeComponent();
            var _clienteBll = new ClientePresenter(this);
            AdicionarButton.Click += Adicionar;
            RemoverButton.Click += Remover;
            LimparButton.Click += Limpar;
        }

        public void AdicionarItem(string nome)
        {
            var pos = ClientesGrid.Rows.Add();
            ClientesGrid[NomeClienteGrid.Index, pos].Value = NomeTextBox.Text;
        }

        public void RemoverItem(string nome)
        {
            foreach (DataGridViewRow row in ClientesGrid.Rows.Cast<DataGridViewRow>().Where(a => a.Cells[NomeClienteGrid.Name].Value != null && 
                                                                                                 a.Cells[NomeClienteGrid.Name].Value.ToString() == nome))
            {
                ClientesGrid.Rows.Remove(row);
            }
        }

        public List<string> BuscarItems()
        {
            return ClientesGrid.Rows.Cast<DataGridViewRow>().Select(a => a.Cells[NomeClienteGrid.Name].ToString()).ToList();
        }

        public void AtribuirItems(List<string> nomes)
        {
            ClientesGrid.DataSource = nomes;
        }

        public void MostrarMensagem(string msg)
        {
            MessageBox.Show(msg, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimparItens()
        {
            ClientesGrid.Rows.Clear();
        }
    }
}