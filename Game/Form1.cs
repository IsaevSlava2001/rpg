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
            comandlabel.Text = "команда 1";
            Startgamebutton.Visible = false;
            buttonshaman1.Visible = true;
            buttonrogue1.Visible = true;
            buttonpriest1.Visible = true;
            buttonpalladin1.Visible = true;
            buttonpalladin1atack.Visible = false;
            buttonpriest1atack.Visible = false;
            buttonshaman1atack.Visible = false;
            buttonrogue1atack.Visible = false;
            buttonpalladin2.Visible = false;
            buttonpriest2.Visible = false;
            buttonpalladin2atack.Visible = false;
            buttonpriest2atack.Visible = false;
            buttonrogue2.Visible = false;
            buttonshaman2.Visible = false;
            buttonshaman2atack.Visible = false;
            buttonrogue2atack.Visible = false;
            labelpalladin1Health.Visible = true;
            labelpriest1health.Visible = true;
            labelpalladin1mana.Visible = true;
            labelpriest1mana.Visible = true;
            labelshaman1health.Visible = true;
            labelrogue1health.Visible = true;
            labelshaman1mana.Visible = true;
            labelrogue1mana.Visible = true;
            labelpalladin2health.Visible = false;
            labelpriest2health.Visible = false;
            labelpalladin2mana.Visible = false;
            labelpriest2mana.Visible = false;
            labelshaman2health.Visible = false;
            labelrogue2health.Visible = false;
            labelshaman2mana.Visible = false;
            labelrogue2mana.Visible = false;
            progressBarpalladin1Health.Visible = true;
            progressBarpalladin1mana.Visible = true;
            progressBarpriest1health.Visible = true;
            progressBarpriest1mana.Visible = true;
            progressBarshaman1health.Visible = true;
            progressBarrogue1health.Visible = true;
            progressBarshaman1mana.Visible = true;
            progressBarrogue1mana.Visible = true;
            progressBarpalladin2health.Visible = false;
            progressBarpriest2health.Visible = false;
            progressBarpalladin2mana.Visible = false;
            progressBarpriest2mana.Visible = false;
            progressBarshaman2health.Visible = false;
            progressBarrogue2health.Visible = false;
            progressBarshaman2mana.Visible = false;
            progressBarrogue2mana.Visible = false;

            
            
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
            progressBarpalladin1Health.Maximum = (Palladin1.Hp);
            progressBarpalladin1mana.Maximum = (Palladin1.MP);
            progressBarpriest1health.Maximum = (Priest1.Hp);
            progressBarpriest1mana.Maximum = (Priest1.MP);
            progressBarshaman1health.Maximum = (Shaman1.Hp);
            progressBarrogue1health.Maximum = (Rogue1.Hp);
            progressBarshaman1mana.Maximum = (Shaman1.MP);
            progressBarrogue1mana.Maximum = (Rogue1.MP);
            progressBarpalladin2health.Maximum = (Palladin2.Hp);
            progressBarpriest2health.Maximum = (Priest2.Hp);
            progressBarpalladin2mana.Maximum = (Palladin2.MP);
            progressBarpriest2mana.Maximum = (Priest2.MP);
            progressBarshaman2health.Maximum = (Shaman2.Hp);
            progressBarshaman2mana.Maximum = (Shaman2.MP);
            progressBarrogue2health.Maximum = (Rogue2.Hp);
            progressBarrogue2mana.Maximum = (Rogue2.MP);
            labelpalladin1Health.Text = ("здоровье " + Palladin1.Hp);
            labelpriest1health.Text = ("мана " + Priest1.Hp);
            labelpalladin1mana.Text = ("здоровье " + Palladin1.MP);
            labelpriest1mana.Text = ("мана " + Priest1.MP);
            labelshaman1health.Text = ("здоровье " + Shaman1.Hp);
            labelrogue1health.Text = ("мана " + Rogue1.Hp);
            labelshaman1mana.Text = ("здоровье " + Shaman1.MP);
            labelrogue1mana.Text = ("мана " + Rogue1.MP);
            labelpalladin2health.Text = ("здоровье " + Palladin2.Hp);
            labelpriest2health.Text = ("мана " + Priest2.Hp);
            labelpalladin2mana.Text = ("здоровье " + Palladin2.MP);
            labelpriest2mana.Text = ("мана " + Priest2.MP);
            labelshaman2health.Text = ("здоровье " + Shaman2.Hp);
            labelpriest1mana.Text = ("мана" + Priest1.MP);
            labelrogue2health.Text = ("здоровье " + Rogue2.Hp);
            labelrogue2mana.Text = ("мана " + Rogue2.MP);
            progressBarpalladin1Health.Value = (Palladin1.Hp);
            progressBarpalladin1mana.Value = (Palladin1.MP);
            progressBarpriest1health.Value = (Priest1.Hp);
            progressBarpriest1mana.Value = (Priest1.MP);
            progressBarshaman1health.Value = (Shaman1.Hp);
            progressBarrogue1health.Value = (Rogue1.Hp);
            progressBarshaman1mana.Value = (Shaman1.MP);
            progressBarrogue1mana.Value = (Rogue1.MP);
            progressBarpalladin2health.Value = (Palladin2.Hp);
            progressBarpriest2health.Value = (Priest2.Hp);
            progressBarpalladin2mana.Value = (Palladin2.MP);
            progressBarpriest2mana.Value = (Priest2.MP);
            progressBarshaman2health.Value = (Shaman2.Hp);
            progressBarshaman2mana.Value = (Shaman2.MP);
            progressBarrogue2health.Value = (Rogue2.Hp);
            progressBarrogue2mana.Value = (Rogue2.MP);
          
          
            
           
        }

        private void buttonpalladin_Click(object sender, EventArgs e)
        {
            
            agressor=Palladin1;
            buttonshaman1.Visible = false;
            buttonrogue1.Visible = false;
            buttonpriest1.Visible = false;
            buttonpalladin1.Visible = false;
            progressBarpalladin1Health.Visible = false;
            progressBarpalladin1mana.Visible = false;
            progressBarpriest1health.Visible = false;
            progressBarpriest1mana.Visible = false;
            progressBarshaman1health.Visible = false;
            progressBarrogue1health.Visible = false;
            progressBarshaman1mana.Visible = false;
            progressBarpalladin2health.Visible = true;
            progressBarpriest2health.Visible = true;
            progressBarpalladin2mana.Visible = true;
            progressBarpriest2mana.Visible = true;
            progressBarshaman2health.Visible = true;
            progressBarrogue2health.Visible = true;
            progressBarshaman2mana.Visible = true;
            progressBarrogue2mana.Visible = true;
            progressBarrogue1mana.Visible = false;
            labelpalladin1Health.Visible = false;
            labelpriest1health.Visible = false;
            labelpalladin1mana.Visible = false;
            labelpriest1mana.Visible = false;
            labelshaman1health.Visible = false;
            labelrogue1health.Visible = false;
            labelshaman1mana.Visible = false;
            labelrogue1mana.Visible = false;
            labelpalladin2health.Visible = true;
            labelpriest2health.Visible = true;
            labelpalladin2mana.Visible = true;
            labelpriest2mana.Visible = true;
            labelshaman2health.Visible = true;
            labelrogue2health.Visible = true;
            labelshaman2mana.Visible = true;
            labelrogue2mana.Visible = true;
            buttonpalladin2atack.Visible = true;
            buttonpriest2atack.Visible = true;
            buttonshaman2atack.Visible = true;
            buttonrogue2atack.Visible = true;  
        }

        private void button17_Click(object sender, EventArgs e)
        {
             agressor=Priest1;
            buttonshaman1.Visible = false;
            buttonrogue1.Visible = false;
            buttonpriest1.Visible = false;
            buttonpalladin1.Visible = false;
            progressBarpalladin1Health.Visible = false;
            progressBarpalladin1mana.Visible = false;
            progressBarpriest1health.Visible = false;
            progressBarpriest1mana.Visible = false;
            progressBarshaman1health.Visible = false;
            progressBarrogue1health.Visible = false;
            progressBarshaman1mana.Visible = false;
            progressBarpalladin2health.Visible = true;
            progressBarpriest2health.Visible = true;
            progressBarpalladin2mana.Visible = true;
            progressBarpriest2mana.Visible = true;
            progressBarshaman2health.Visible = true;
            progressBarrogue2health.Visible = true;
            progressBarshaman2mana.Visible = true;
            progressBarrogue2mana.Visible = true;
            progressBarrogue1mana.Visible = false;
            labelpalladin1Health.Visible = false;
            labelpriest1health.Visible = false;
            labelpalladin1mana.Visible = false;
            labelpriest1mana.Visible = false;
            labelshaman1health.Visible = false;
            labelrogue1health.Visible = false;
            labelshaman1mana.Visible = false;
            labelrogue1mana.Visible = false;
            labelpalladin2health.Visible = true;
            labelpriest2health.Visible = true;
            labelpalladin2mana.Visible = true;
            labelpriest2mana.Visible = true;
            labelshaman2health.Visible = true;
            labelrogue2health.Visible = true;
            labelshaman2mana.Visible = true;
            labelrogue2mana.Visible = true;
            buttonpalladin2atack.Visible = true;
            buttonpriest2atack.Visible = true;
            buttonshaman2atack.Visible = true;
            buttonrogue2atack.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Shaman1 = agressor;
            buttonshaman1.Visible = false;
            buttonrogue1.Visible = false;
            buttonpriest1.Visible = false;
            buttonpalladin1.Visible = false;
            progressBarpalladin1Health.Visible = false;
            progressBarpalladin1mana.Visible = false;
            progressBarpriest1health.Visible = false;
            progressBarpriest1mana.Visible = false;
            progressBarshaman1health.Visible = false;
            progressBarrogue1health.Visible = false;
            progressBarshaman1mana.Visible = false;
            progressBarpalladin2health.Visible = true;
            progressBarpriest2health.Visible = true;
            progressBarpalladin2mana.Visible = true;
            progressBarpriest2mana.Visible = true;
            progressBarshaman2health.Visible = true;
            progressBarrogue2health.Visible = true;
            progressBarshaman2mana.Visible = true;
            progressBarrogue2mana.Visible = true;
            progressBarrogue1mana.Visible = false;
            labelpalladin1Health.Visible = false;
            labelpriest1health.Visible = false;
            labelpalladin1mana.Visible = false;
            labelpriest1mana.Visible = false;
            labelshaman1health.Visible = false;
            labelrogue1health.Visible = false;
            labelshaman1mana.Visible = false;
            labelrogue1mana.Visible = false;
            labelpalladin2health.Visible = true;
            labelpriest2health.Visible = true;
            labelpalladin2mana.Visible = true;
            labelpriest2mana.Visible = true;
            labelshaman2health.Visible = true;
            labelrogue2health.Visible = true;
            labelshaman2mana.Visible = true;
            labelrogue2mana.Visible = true;
            buttonpalladin2atack.Visible = true;
            buttonpriest2atack.Visible = true;
            buttonshaman2atack.Visible = true;
            buttonrogue2atack.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Rogue1 = agressor;
            buttonshaman1.Visible = false;
            buttonrogue1.Visible = false;
            buttonpriest1.Visible = false;
            buttonpalladin1.Visible = false;
            progressBarpalladin1Health.Visible = false;
            progressBarpalladin1mana.Visible = false;
            progressBarpriest1health.Visible = false;
            progressBarpriest1mana.Visible = false;
            progressBarshaman1health.Visible = false;
            progressBarrogue1health.Visible = false;
            progressBarshaman1mana.Visible = false;
            progressBarpalladin2health.Visible = true;
            progressBarpriest2health.Visible = true;
            progressBarpalladin2mana.Visible = true;
            progressBarpriest2mana.Visible = true;
            progressBarshaman2health.Visible = true;
            progressBarrogue2health.Visible = true;
            progressBarshaman2mana.Visible = true;
            progressBarrogue2mana.Visible = true;
            progressBarrogue1mana.Visible = false;
            labelpalladin1Health.Visible = false;
            labelpriest1health.Visible = false;
            labelpalladin1mana.Visible = false;
            labelpriest1mana.Visible = false;
            labelshaman1health.Visible = false;
            labelrogue1health.Visible = false;
            labelshaman1mana.Visible = false;
            labelrogue1mana.Visible = false;
            labelpalladin2health.Visible = true;
            labelpriest2health.Visible = true;
            labelpalladin2mana.Visible = true;
            labelpriest2mana.Visible = true;
            labelshaman2health.Visible = true;
            labelrogue2health.Visible = true;
            labelshaman2mana.Visible = true;
            labelrogue2mana.Visible = true;
            buttonpalladin2atack.Visible = true;
            buttonpriest2atack.Visible = true;
            buttonshaman2atack.Visible = true;
            buttonrogue2atack.Visible = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Palladin2.Hp = Palladin2.Hp - agressor.Damage;
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Priest2.Hp = Priest2.Hp - agressor.Damage;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Shaman2.Hp = Shaman2.Hp - agressor.Damage;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Rogue2.Hp = Rogue2.Hp - agressor.Damage;
            labelpalladin1Health.Text = ("здоровье " + Palladin1.Hp);
            labelpriest1health.Text = ("мана " + Priest1.Hp);
            labelpalladin1mana.Text = ("здоровье " + Palladin1.MP);
            labelpriest1mana.Text = ("мана " + Priest1.MP);
            labelshaman1health.Text = ("здоровье " + Shaman1.Hp);
            labelrogue1health.Text = ("мана " + Rogue1.Hp);
            labelshaman1mana.Text = ("здоровье " + Shaman1.MP);
            labelrogue1mana.Text = ("мана " + Rogue1.MP);
            labelpalladin2health.Text = ("здоровье " + Palladin2.Hp);
            labelpriest2health.Text = ("мана " + Priest2.Hp);
            labelpalladin2mana.Text = ("здоровье " + Palladin2.MP);
            labelpriest2mana.Text = ("мана " + Priest2.MP);
            labelshaman2health.Text = ("здоровье " + Shaman2.Hp);
            labelpriest1mana.Text = ("мана" + Priest1.MP);
            labelrogue2health.Text = ("здоровье " + Rogue2.Hp);
            labelrogue2mana.Text = ("мана " + Rogue2.MP);
            progressBarpalladin1Health.Value = (Palladin1.Hp);
            progressBarpalladin1mana.Value = (Palladin1.MP);
            progressBarpriest1health.Value = (Priest1.Hp);
            progressBarpriest1mana.Value = (Priest1.MP);
            progressBarshaman1health.Value = (Shaman1.Hp);
            progressBarrogue1health.Value = (Rogue1.Hp);
            progressBarshaman1mana.Value = (Shaman1.MP);
            progressBarrogue1mana.Value = (Rogue1.MP);
            progressBarpalladin2health.Value = (Palladin2.Hp);
            progressBarpriest2health.Value = (Priest2.Hp);
            progressBarpalladin2mana.Value = (Palladin2.MP);
            progressBarpriest2mana.Value = (Priest2.MP);
            progressBarshaman2health.Value = (Shaman2.Hp);
            progressBarshaman2mana.Value = (Shaman2.MP);
            progressBarrogue2health.Value = (Rogue2.Hp);
            progressBarrogue2mana.Value = (Rogue2.MP);

            comandlabel.Text = "команда2";
            buttonshaman1.Visible = false;
            buttonrogue1.Visible = false;
            buttonpriest1.Visible = false;
            buttonpalladin1.Visible = false;
            buttonpalladin1atack.Visible = false;
            buttonpriest1atack.Visible = false;
            buttonshaman1atack.Visible = false;
            buttonrogue1atack.Visible = false;
            buttonpalladin2.Visible = true;
            buttonpriest2.Visible = true;
            buttonpalladin2atack.Visible = false;
            buttonpriest2atack.Visible = false;
            buttonrogue2.Visible = true;
            buttonshaman2.Visible = true;
            buttonshaman2atack.Visible = false;
            buttonrogue2atack.Visible = false;
            labelpalladin1Health.Visible = false;
            labelpriest1health.Visible = false;
            labelpalladin1mana.Visible = false;
            labelpriest1mana.Visible = false;
            labelshaman1health.Visible = false;
            labelrogue1health.Visible = false;
            labelshaman1mana.Visible = false;
            labelrogue1mana.Visible = false;
            labelpalladin2health.Visible = true;
            labelpriest2health.Visible = true;
            labelpalladin2mana.Visible = true;
            labelpriest2mana.Visible = true;
            labelshaman2health.Visible = true;
            labelrogue2health.Visible = true;
            labelshaman2mana.Visible = true;
            labelrogue2mana.Visible = true;
            progressBarpalladin1Health.Visible = false;
            progressBarpalladin1mana.Visible = false;
            progressBarpriest1health.Visible = false;
            progressBarpriest1mana.Visible = false;
            progressBarshaman1health.Visible = false;
            progressBarrogue1health.Visible = false;
            progressBarshaman1mana.Visible = false;
            progressBarrogue1mana.Visible = false;
            progressBarpalladin2health.Visible = true;
            progressBarpriest2health.Visible = true;
            progressBarpalladin2mana.Visible = true;
            progressBarpriest2mana.Visible = true;
            progressBarshaman2health.Visible = true;
            progressBarrogue2health.Visible = true;
            progressBarshaman2mana.Visible = true;
            progressBarrogue2mana.Visible = true;



        }
    }
}
