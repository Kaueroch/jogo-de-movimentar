
namespace _26_05_movimentar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.img_direita = new System.Windows.Forms.PictureBox();
            this.img_esquerda = new System.Windows.Forms.PictureBox();
            this.img_baixo = new System.Windows.Forms.PictureBox();
            this.img_cima = new System.Windows.Forms.PictureBox();
            this.img_menina = new System.Windows.Forms.PictureBox();
            this.img_personagem = new System.Windows.Forms.PictureBox();
            this.lblpontos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_direita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_esquerda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_baixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_cima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_menina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_personagem)).BeginInit();
            this.SuspendLayout();
            // 
            // img_direita
            // 
            this.img_direita.Image = global::_26_05_movimentar.Properties.Resources.pdir;
            this.img_direita.Location = new System.Drawing.Point(600, 390);
            this.img_direita.Name = "img_direita";
            this.img_direita.Size = new System.Drawing.Size(87, 90);
            this.img_direita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_direita.TabIndex = 5;
            this.img_direita.TabStop = false;
            this.img_direita.Visible = false;
            this.img_direita.Click += new System.EventHandler(this.img_direita_Click);
            // 
            // img_esquerda
            // 
            this.img_esquerda.Image = global::_26_05_movimentar.Properties.Resources.pesq;
            this.img_esquerda.Location = new System.Drawing.Point(414, 390);
            this.img_esquerda.Name = "img_esquerda";
            this.img_esquerda.Size = new System.Drawing.Size(87, 90);
            this.img_esquerda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_esquerda.TabIndex = 4;
            this.img_esquerda.TabStop = false;
            this.img_esquerda.Visible = false;
            this.img_esquerda.Click += new System.EventHandler(this.img_esquerda_Click);
            // 
            // img_baixo
            // 
            this.img_baixo.Image = global::_26_05_movimentar.Properties.Resources.pbaixo;
            this.img_baixo.Location = new System.Drawing.Point(507, 390);
            this.img_baixo.Name = "img_baixo";
            this.img_baixo.Size = new System.Drawing.Size(87, 90);
            this.img_baixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_baixo.TabIndex = 3;
            this.img_baixo.TabStop = false;
            this.img_baixo.Visible = false;
            this.img_baixo.Click += new System.EventHandler(this.img_baixo_Click);
            // 
            // img_cima
            // 
            this.img_cima.Image = global::_26_05_movimentar.Properties.Resources.pcima;
            this.img_cima.Location = new System.Drawing.Point(507, 294);
            this.img_cima.Name = "img_cima";
            this.img_cima.Size = new System.Drawing.Size(87, 90);
            this.img_cima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_cima.TabIndex = 2;
            this.img_cima.TabStop = false;
            this.img_cima.Visible = false;
            this.img_cima.Click += new System.EventHandler(this.img_cima_Click);
            // 
            // img_menina
            // 
            this.img_menina.BackColor = System.Drawing.Color.Transparent;
            this.img_menina.Image = ((System.Drawing.Image)(resources.GetObject("img_menina.Image")));
            this.img_menina.Location = new System.Drawing.Point(600, 155);
            this.img_menina.Name = "img_menina";
            this.img_menina.Size = new System.Drawing.Size(143, 128);
            this.img_menina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_menina.TabIndex = 1;
            this.img_menina.TabStop = false;
            // 
            // img_personagem
            // 
            this.img_personagem.BackColor = System.Drawing.Color.Transparent;
            this.img_personagem.Image = global::_26_05_movimentar.Properties.Resources.gumball;
            this.img_personagem.Location = new System.Drawing.Point(8, 7);
            this.img_personagem.Name = "img_personagem";
            this.img_personagem.Size = new System.Drawing.Size(109, 99);
            this.img_personagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_personagem.TabIndex = 0;
            this.img_personagem.TabStop = false;
            // 
            // lblpontos
            // 
            this.lblpontos.AutoSize = true;
            this.lblpontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpontos.Location = new System.Drawing.Point(4, 456);
            this.lblpontos.Name = "lblpontos";
            this.lblpontos.Size = new System.Drawing.Size(73, 24);
            this.lblpontos.TabIndex = 6;
            this.lblpontos.Text = "Pontos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 491);
            this.Controls.Add(this.lblpontos);
            this.Controls.Add(this.img_direita);
            this.Controls.Add(this.img_esquerda);
            this.Controls.Add(this.img_baixo);
            this.Controls.Add(this.img_cima);
            this.Controls.Add(this.img_menina);
            this.Controls.Add(this.img_personagem);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo bom demais";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.img_direita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_esquerda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_baixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_cima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_menina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_personagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_personagem;
        private System.Windows.Forms.PictureBox img_menina;
        private System.Windows.Forms.PictureBox img_cima;
        private System.Windows.Forms.PictureBox img_baixo;
        private System.Windows.Forms.PictureBox img_esquerda;
        private System.Windows.Forms.PictureBox img_direita;
        private System.Windows.Forms.Label lblpontos;
    }
}

