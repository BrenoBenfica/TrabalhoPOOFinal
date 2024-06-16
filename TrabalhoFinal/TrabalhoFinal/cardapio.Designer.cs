namespace TrabalhoFinal
{
    partial class cardapio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Água Mineral Crystal 500ml S/Gás", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Coca-Cola 600ml", 2);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Suco Del Valle Sabor Uva 1l", 6);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Cheeseburger", 1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Cheeseburger Duplo Bacon", 5);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Cheeseburger Triplo", 4);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Burger Vegano", 3);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardapio));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProdutoSelecionado = new System.Windows.Forms.Label();
            this.pictureBoxCarrinho = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelQtdProdutos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Itens do Cardápio:";
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(551, 135);
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownQuantidade.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.BackColor = System.Drawing.SystemColors.Info;
            this.listViewProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listViewProdutos.Location = new System.Drawing.Point(47, 88);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Scrollable = false;
            this.listViewProdutos.ShowGroups = false;
            this.listViewProdutos.Size = new System.Drawing.Size(260, 319);
            this.listViewProdutos.SmallImageList = this.imageList1;
            this.listViewProdutos.TabIndex = 5;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.List;
            this.listViewProdutos.SelectedIndexChanged += new System.EventHandler(this.listViewProdutos_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Img_agUA-removebg-preview.png");
            this.imageList1.Images.SetKeyName(1, "kids-burger-thumb cheeseburguer.png");
            this.imageList1.Images.SetKeyName(2, "png-transparent-coca-cola-600-fizzy-drinks-diet-coke-fanta-gaseosas-cola-beverage" +
        "s-soft-drink-thumbnail-removebg-preview.png");
            this.imageList1.Images.SetKeyName(3, "whopper-de-plantas-thumb.png");
            this.imageList1.Images.SetKeyName(4, "Mega-Stacker-3.0-thumb-cupom-m-d_2022-07-21-165917_cczx.png");
            this.imageList1.Images.SetKeyName(5, "rodeio-duplo-thumb_2021-09-16-135740_wani.png");
            this.imageList1.Images.SetKeyName(6, "suco-delvalle-removebg-preview.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade:";
            // 
            // labelProdutoSelecionado
            // 
            this.labelProdutoSelecionado.AutoSize = true;
            this.labelProdutoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutoSelecionado.Location = new System.Drawing.Point(531, 96);
            this.labelProdutoSelecionado.Name = "labelProdutoSelecionado";
            this.labelProdutoSelecionado.Size = new System.Drawing.Size(0, 16);
            this.labelProdutoSelecionado.TabIndex = 8;
            // 
            // pictureBoxCarrinho
            // 
            this.pictureBoxCarrinho.Image = global::TrabalhoFinal.Properties.Resources.png_transparent_shopping_cart_online_shopping_empty_cart_angle_logo_shopping_centre;
            this.pictureBoxCarrinho.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarrinho.InitialImage")));
            this.pictureBoxCarrinho.Location = new System.Drawing.Point(657, 366);
            this.pictureBoxCarrinho.Name = "pictureBoxCarrinho";
            this.pictureBoxCarrinho.Size = new System.Drawing.Size(44, 41);
            this.pictureBoxCarrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarrinho.TabIndex = 9;
            this.pictureBoxCarrinho.TabStop = false;
            this.pictureBoxCarrinho.Click += new System.EventHandler(this.pictureBoxCarrinho_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Carrinho de itens:";
            // 
            // labelQtdProdutos
            // 
            this.labelQtdProdutos.AutoSize = true;
            this.labelQtdProdutos.BackColor = System.Drawing.Color.Red;
            this.labelQtdProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtdProdutos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQtdProdutos.Location = new System.Drawing.Point(686, 366);
            this.labelQtdProdutos.Name = "labelQtdProdutos";
            this.labelQtdProdutos.Size = new System.Drawing.Size(15, 13);
            this.labelQtdProdutos.TabIndex = 12;
            this.labelQtdProdutos.Text = "X";
            this.labelQtdProdutos.Click += new System.EventHandler(this.labelQtdProdutos_Click);
            // 
            // cardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 494);
            this.Controls.Add(this.labelQtdProdutos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxCarrinho);
            this.Controls.Add(this.labelProdutoSelecionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewProdutos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownQuantidade);
            this.Controls.Add(this.label1);
            this.Name = "cardapio";
            this.Text = "Cardápio";
            this.Load += new System.EventHandler(this.cardapio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProdutoSelecionado;
        private System.Windows.Forms.PictureBox pictureBoxCarrinho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelQtdProdutos;
    }
}