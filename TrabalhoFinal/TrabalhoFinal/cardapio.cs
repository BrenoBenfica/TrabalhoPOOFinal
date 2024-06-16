using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class cardapio : Form
    {
        public cardapio()
        {
            InitializeComponent();
            produtos = new List<Produto>();
        }
        public class Produto
        {
            private string nome;
            private double valor;
            private int quantidade;

            public Produto() { }
            public Produto(string nome, double valor, int quantidade)
            {
                this.nome = nome;
                this.valor = valor;
                this.quantidade = quantidade;
            }

            public string GetName() { return this.nome; }
            public double GetValor() { return this.valor; }
            public int GetQuantidade() { return this.quantidade; }
        }

        List<Produto> produtos;
        Produto produtoSelecionado;
        int qtdProdutosAdicionados = 0;

        private void cardapio_Load(object sender, EventArgs e)
        {
        
        }

        private void listViewProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProdutos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewProdutos.SelectedItems[0];

                switch (selectedItem.Text)
                {
                    case "Água Mineral Crystal 500ml S/Gás":
                        produtoSelecionado = new Produto(
                            "Agua Mineral Crystal 500ml S/Gas",
                            3.50,
                            (int)numericUpDownQuantidade.Value
                        );
                        labelProdutoSelecionado.Text = "Agua Mineral Crystal 500ml S/Gas";
                        break;
                    case "Coca-Cola 600ml":
                        produtoSelecionado = new Produto(
                            "Coca-Cola 600ml",
                            6.50,
                            (int)numericUpDownQuantidade.Value
                        );
                        labelProdutoSelecionado.Text = "Coca-Cola 600ml";
                        break;
                    case "Suco Del Valle Sabor Uva 1l":
                        produtoSelecionado = new Produto(
                            "Suco Del Valle Sabor Uva 1l",
                            5.00,
                            (int)numericUpDownQuantidade.Value
                        );
                        labelProdutoSelecionado.Text = "Suco Del Valle Sabor Uva 1l";
                        break;
                    case "Cheeseburger":
                        produtoSelecionado = new Produto(
                            "Cheeseburger",
                            20.00,
                            (int)numericUpDownQuantidade.Value
                        );
                        labelProdutoSelecionado.Text = "Cheeseburger";
                        break;
                    case "Cheeseburger Duplo Bacon":
                        produtoSelecionado = new Produto(
                            "Cheeseburger Duplo Bacon",
                            25.00,
                            (int)numericUpDownQuantidade.Value
                        );
                        labelProdutoSelecionado.Text = "Cheeseburger Duplo Bacon";
                        break;
                    case "Cheeseburger Triplo":
                        produtoSelecionado = new Produto(
                            "Cheeseburger Triplo",
                            27.00,
                            (int)numericUpDownQuantidade.Value
                        );
                        labelProdutoSelecionado.Text = "Cheeseburger Triplo";
                        break;
                    case "Burger Vegano":
                        produtoSelecionado = new Produto(
                            "Burger Vegano",
                            25.00,
                            (int)numericUpDownQuantidade.Value
                        );
                        labelProdutoSelecionado.Text = "Burger Vegano";
                        break;
                }

                numericUpDownQuantidade.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(produtoSelecionado != null)
            {
                produtos.Add(produtoSelecionado);
                produtoSelecionado = new Produto();

                labelQtdProdutos.Text = (qtdProdutosAdicionados += 1).ToString();
                labelQtdProdutos.Visible = true;

            }
        }

        private void pictureBoxCarrinho_Click(object sender, EventArgs e)
        {
            Contas contasPop = new Contas();
            contasPop.Show();
            this.Hide();
            contasPop.FormClosed += (s, args) => this.Show();
        }

        private void labelQtdProdutos_Click(object sender, EventArgs e)
        {

        }
    }
}
