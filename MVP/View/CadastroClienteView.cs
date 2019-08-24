using System;
using System.Windows.Forms;
using System.Linq;

namespace MVP
{
    public partial class Form1 : Form, ICadastroClienteView
    {
        private ClientePresenter _clienteBll;
        private EventHandler AdicionarEventHandler;
        private EventHandler RemoverEventHandler;

        public Form1()
        {
            InitializeComponent();
            _clienteBll = new ClientePresenter(this);
            AdicionarEventHandler += executeAdicionar;
            RemoverEventHandler += executeRemover;
        }

        private void executeAdicionar(object sender, EventArgs e)
        {
            _clienteBll.Adicionar(txtNome.Text);
        }

        private void executeRemover(object sender, EventArgs e)
        {
            _clienteBll.Remover(txtNome.Text);
        }

        public void AdicionarItemGrid(string nome)
        {
            var pos = ClientesGrid.Rows.Add();
            ClientesGrid[IDClienteGrid.Index, pos].Value = 0;
            ClientesGrid[NomeClienteGrid.Index, pos].Value = txtNome.Text;
        }

        public void RemoverItemsGrid(string nome)
        {
            foreach (DataGridViewRow row in ClientesGrid.Rows.Cast<DataGridViewRow>().Where(a=> a.Cells[NomeClienteGrid.Name].Value != null))
            {
                if (row.Cells[NomeClienteGrid.Name].Value.ToString() == nome)
                {
                    ClientesGrid.Rows.Remove(row);
                }
            }
        }

        public void LimparGrid()
        {
            ClientesGrid.Rows.Clear();
        }

        public void MostrarErroLabel(string msgErro)
        {
            lbError.Visible = true;
            lbError.Text = msgErro;
        }
    }
}