using System;
using System.Windows.Forms;

using Projeto3Camadas.Code.BLL; 
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas.Ui
{
    public partial class Frm_EstoqueEPA : Form
    {

        EstoqueBLL epabll = new EstoqueBLL();
        EstoqueDTO epadto = new EstoqueDTO();

        public Frm_EstoqueEPA()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            epadto.Produto = txtProduto.Text;
            epadto.Preco = txtPreco.Text;

            epabll.Inserir(epadto);

            
            MessageBox.Show("Cadastrado com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            txtId.Clear();
            txtProduto.Clear();
            txtPreco.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            
            epadto.Id = int.Parse(txtId.Text);
            epadto.Produto = txtProduto.Text;
            epadto.Preco = txtPreco.Text;

            
            epabll.Editar(epadto);

            MessageBox.Show("Alterado com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            epabll.Listar();

            txtId.Clear();
            txtProduto.Clear();
            txtPreco.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        { 
            epadto.Id = int.Parse(txtId.Text);
         
            epabll.Excluir(epadto);

            MessageBox.Show("Excluido com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            epabll.Listar();

            txtId.Clear();
            txtProduto.Clear();
            txtPreco.Clear();
        }

        private void Frm_EstoqueEPA_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = epabll.Listar();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProduto.Text = dgvProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPreco.Text = dgvProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
