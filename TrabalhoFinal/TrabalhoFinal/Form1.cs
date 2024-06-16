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
    public partial class Form1 : Form
    {
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

        //criação da comanda de cada mesa
        List<Produto> comandaMesa1 = new List<Produto>();
        List<Produto> comandaMesa2 = new List<Produto>();
        List<Produto> comandaMesa3 = new List<Produto>();
        List<Produto> comandaMesa4 = new List<Produto>();
        List<Produto> comandaMesa5 = new List<Produto>();
        List<Produto> comandaMesa6 = new List<Produto>();
        List<Produto> comandaMesa7 = new List<Produto>();
        List<Produto> comandaMesa8 = new List<Produto>();
        List<Produto> comandaMesa9 = new List<Produto>();
        List<Produto> comandaMesa10 = new List<Produto>();
        List<Produto> comandaMesa11 = new List<Produto>();
        List<Produto> comandaMesa12 = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        //eventos de click de cada mesa
        private void mesa1_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }

        private void mesa2_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }

        private void mesa3_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }

        private void mesa4_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }

        private void mesa5_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }

        private void mesa6_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }

        private void mesa7_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }

        private void mesa8_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }

        private void mesa9_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }

        private void mesa10_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }

        private void mesa11_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }

        private void mesa12_Click(object sender, EventArgs e)
        {
            cardapio cardPop = new cardapio();
            cardPop.Show();
            this.Hide();
            cardPop.FormClosed += (s, args) => this.Show();
        }
    }
}
