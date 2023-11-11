using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_05_movimentar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void img_cima_Click(object sender, EventArgs e)
        {
            if (img_personagem.Top > 0)
            {
                img_personagem.Top = img_personagem.Top - 10;
            }
        }

        private void img_baixo_Click(object sender, EventArgs e)
        {
            if (img_personagem.Top < 400)
            {
                img_personagem.Top = img_personagem.Top + 10;
            }
        }

        private void img_esquerda_Click(object sender, EventArgs e)
        {
            if (img_personagem.Left > 0)
            {
                img_personagem.Left = img_personagem.Left - 10;
            }
        }

        private void img_direita_Click(object sender, EventArgs e)
        {
            if (img_personagem.Left < 600)
            {
                img_personagem.Left = img_personagem.Left + 10;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                img_cima_Click(sender, e);
            }
            if(e.KeyCode == Keys.Down)
            {
                img_baixo_Click(sender, e);
            }
            if (e.KeyCode == Keys.Left)
            {
                img_esquerda_Click(sender, e);
            }
            if (e.KeyCode == Keys.Right)
            {
                img_direita_Click(sender, e);
            }
            if(img_personagem.Bounds.IntersectsWith(img_menina.Bounds))
            {
                MessageBox.Show("Boa! Conseguiu salvar o Gon das mãos do Hisoka!!!");
                img_personagem.Top = 0;
                img_personagem.Left = 0;
            }
        }
    }
}
