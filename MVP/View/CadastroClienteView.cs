using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using MVP.Commands;
using MVP.BusinessLogic;

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

        public event Action<string> Adicionar;
        public event Action<string> Remover;
        public event Action Limpar;

        public Form1(IClienteRepository cliente)
        {
            InitializeComponent();
            var _clienteBll = new ClientePresenter(this, cliente);
            AdicionarButton.Click += (s, a) => Adicionar(NomeTextBox.Text);
            RemoverButton.Click += (s,a) => Remover(NomeTextBox.Text);
            LimparButton.Click += (a,s) => Limpar();
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

        public void FocoNome()
        {
            NomeTextBox.Focus();
        }
    }
}