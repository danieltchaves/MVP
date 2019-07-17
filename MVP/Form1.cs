using System;
using System.Windows.Forms;

namespace MVP
{
    public partial class Form1 : Form, IView
    {
        private ClienteBLL _clienteBll;

        public Form1()
        {
            InitializeComponent();
            _clienteBll = new ClienteBLL(this);
        }

        public void Limpar()
        {
            grdCliente.Rows.Clear();
        }

        public void MostrarErro(string msgErro)
        {
            lbError.Visible = true;
            lbError.Text = msgErro;
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            _clienteBll.Adicionar(txtNome.Text);
        }

        public void AdicionarItemGrid(int id, string nome)
        {
            var pos = grdCliente.Rows.Add();
            grdCliente[Id.Index, pos].Value = id;
            grdCliente[Nome.Index, pos].Value = nome;
        }
    }
}