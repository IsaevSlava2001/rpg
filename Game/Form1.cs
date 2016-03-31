using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using рпг;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
        }

        private void Startgamebutton_Click(object sender, EventArgs e)
        {
            Startgamebutton.Visible = false;
            button21.Visible = true;
            button20.Visible = true;
            button17.Visible = true;
            buttonpalladin.Visible = true;
            button18.Visible = false;
            button19.Visible = false;
            button8.Visible = false;
            button22.Visible = false;
            button25.Visible = false;
            button27.Visible = false;
            button29.Visible = false;
            button26.Visible = false;
            button28.Visible = false;
            button31.Visible = false;
            button30.Visible = false;
            button24.Visible = false;
            label17.Visible = true;
            label18.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label21.Visible = false;
            label22.Visible = false;
            label32.Visible = false;
            label31.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            progressBar17.Visible = true;
            progressBar18.Visible = true;
            progressBar19.Visible = true;
            progressBar20.Visible = true;
            progressBar21.Visible = true;
            progressBar22.Visible = true;
            progressBar23.Visible = true;
            progressBar24.Visible = true;
            progressBar25.Visible = false;
            progressBar26.Visible = false;
            progressBar27.Visible = false;
            progressBar28.Visible = false;
            progressBar29.Visible = false;
            progressBar30.Visible = false;
            progressBar31.Visible = false;
            progressBar32.Visible = false;

            
            
        }
       static Character Palladin1 = new Palladin(800, 400, 80);
       static Character Palladin2 = new Palladin(800, 400, 80);
       static Character Priest1 = new Priest(400, 900, 30);
       static Character Priest2 = new Priest(400, 900, 30);
       static Character Shaman1 = new Shaman(500, 700, 50);
       static Character Shaman2 = new Shaman(500, 700, 50);
       static Character Rogue1 = new Rogue(360, 500, 100);
        static Character Rogue2 = new Rogue(360, 500, 100);
        static Character agressor;
        private void Form1_Load(object sender, EventArgs e)
        {
            label17.Text = ("здоровье " + Palladin1.Hp);
            label18.Text = ("мана " + Palladin1.MP);
            label25.Text = ("здоровье " + Priest1.Hp);
            label26.Text = ("мана " + Priest1.MP);
            label19.Text = ("здоровье " + Shaman1.Hp);
            label20.Text = ("мана " + Shaman1.MP);
            label27.Text = ("здоровье " + Rogue1.Hp);
            label28.Text = ("мана " + Rogue1.MP);
            label21.Text = ("здоровье " + Palladin2.Hp);
            label22.Text = ("мана " + Palladin2.MP);
            label32.Text = ("здоровье " + Priest2.Hp);
            label31.Text = ("мана " + Priest2.MP);
            label23.Text = ("здоровье " + Shaman2.Hp);
            label24.Text = ("мана" + Shaman2.MP);
            label29.Text = ("здоровье " + Rogue2.Hp);
            label30.Text = ("мана " + Rogue2.MP);
            progressBar17.Maximum = ( Palladin1.Hp);
            progressBar18.Maximum = ( Palladin1.MP);
            progressBar19.Maximum = (Priest1.Hp);
            progressBar20.Maximum = ( Priest1.MP);
            progressBar21.Maximum = ( + Shaman1.Hp);
            progressBar22.Maximum = ( Shaman1.MP);
            progressBar23.Maximum = ( Rogue1.Hp);
            progressBar24.Maximum = (Rogue1.MP);
            progressBar25.Maximum = (  Palladin2.Hp);
            progressBar26.Maximum = ( Palladin2.MP);
            progressBar27.Maximum = ( Priest2.Hp);
            progressBar28.Maximum = ( Priest2.MP);
            progressBar29.Maximum = ( Shaman2.Hp);
            progressBar30.Maximum = ( Shaman2.MP);
            progressBar31.Maximum = ( Rogue2.Hp);
            progressBar32.Maximum = (Rogue2.MP);
            progressBar17.Value = (Palladin1.Hp);
            progressBar18.Value = (Palladin1.MP);
            progressBar19.Value = (Priest1.Hp);
            progressBar20.Value = (Priest1.MP);
            progressBar21.Value = (+Shaman1.Hp);
            progressBar22.Value = (Shaman1.MP);
            progressBar23.Value = (Rogue1.Hp);
            progressBar24.Value = (Rogue1.MP);
            progressBar25.Value = (Palladin2.Hp);
            progressBar26.Value = (Palladin2.MP);
            progressBar27.Value = (Priest2.Hp);
            progressBar28.Value = (Priest2.MP);
            progressBar29.Value = (Shaman2.Hp);
            progressBar30.Value = (Shaman2.MP);
            progressBar31.Value = (Rogue2.Hp);
            progressBar32.Value = (Rogue2.MP);
 }

        private void buttonpalladin_Click(object sender, EventArgs e)
        {
            
              agressor=Palladin1;
            button21.Visible = false;
            button20.Visible = false;
            button17.Visible = false;
            buttonpalladin.Visible = false;
            progressBar17.Visible = false;
            progressBar18.Visible = false;
            progressBar19.Visible = false;
            progressBar20.Visible = false;
            progressBar21.Visible = false;
            progressBar22.Visible = false;
            progressBar23.Visible = false;
            progressBar25.Visible = true;
            progressBar26.Visible = true;
            progressBar27.Visible = true;
            progressBar28.Visible = true;
            progressBar29.Visible = true;
            progressBar30.Visible = true;
            progressBar31.Visible = true;
            progressBar32.Visible = true;
            progressBar24.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label21.Visible = true;
            label22.Visible = true;
            label32.Visible = true;
            label31.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            button29.Visible = true;
            button26.Visible = true;
            button30.Visible = true;
            button24.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
             agressor=Priest1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Shaman1 = agressor;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Rogue1 = agressor;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Palladin2.Hp = Palladin2.Hp - agressor.Damage;
        }
    }
}
