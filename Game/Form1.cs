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
            //button1.Visible = false;
            //button2.Visible = false;
            //button3.Visible = false;
            //button4.Visible = false;
            //button5.Visible = false;
            //button6.Visible = false;
            //button7.Visible = false;
            //button8.Visible = false;
            //label1.Visible = false;
            //label2.Visible = false;
            //label3.Visible = false;
            //label4.Visible = false;
            //label5.Visible = false;
            //label6.Visible = false;
            //label7.Visible = false;
            //label8.Visible = false;
            //label9.Visible = false;
            //label10.Visible = false;
            //label11.Visible = false;
            //label12.Visible = false;
            //label13.Visible = false;
            //label14.Visible = false;
            //label15.Visible = false;
            //label16.Visible = false;

            InitializeComponent();
        }

        private void Startgamebutton_Click(object sender, EventArgs e)
        {
            //Startgamebutton.Text = "Начать игру";
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            progressBar1.Visible = true;
            progressBar2.Visible = true;
            progressBar3.Visible = true;
            progressBar4.Visible = true;
            progressBar5.Visible = true;
            progressBar6.Visible = true;
            progressBar7.Visible = true;
            progressBar8.Visible = true;
            progressBar9.Visible = true;
            progressBar10.Visible = true;
            progressBar11.Visible = true;
            progressBar12.Visible = true;
            progressBar13.Visible = true;
            progressBar14.Visible = true;
            progressBar15.Visible = true;
            progressBar16.Visible = true;

            
            
        }
        Character Palladin1 = new Palladin(800, 400, 80);
        Character Palladin2 = new Palladin(800, 400, 80);
        Character Priest1 = new Priest(400, 900, 30);
        Character Priest2 = new Priest(400, 900, 30);
        Character Shaman1 = new Shaman(500, 700, 50);
        Character Shaman2 = new Shaman(500, 700, 50);
        Character Rogue1 = new Rogue(360, 500, 100);
        Character Rogue2 = new Rogue(360, 500, 100);
        Character agressor;
        private void Form1_Load(object sender, EventArgs e)
        {

            
            
            //List<Character> AllCharacters = new List<Character>();

            //{


            //    AllCharacters.Add(Palladin1);
            //    AllCharacters.Add(Palladin2);
            //    AllCharacters.Add(Priest1);
            //    AllCharacters.Add(Priest2);
            //    AllCharacters.Add(Shaman1);
            //    AllCharacters.Add(Shaman2);
            //    AllCharacters.Add(Rogue1);
            //    AllCharacters.Add(Rogue2);
            //}
            //label1.Text = (" " + AllCharacters[0].HP);
            Startgamebutton.Text = "команда 1";
            panel4.Visible = false;



            label1.Text = ("здоровье " + Palladin1.Hp);
            label2.Text = ("мана " + Palladin1.MP);
            label3.Text = ("здоровье " + Priest1.Hp);
            label4.Text = ("мана " + Priest1.MP);
            label5.Text = ("здоровье " + Shaman1.Hp);
            label6.Text = ("мана " + Shaman1.MP);
            label7.Text = ("здоровье " + Rogue1.Hp);
            label8.Text = ("мана " + Rogue1.MP);
            label9.Text = ("здоровье " + Palladin2.Hp);
            label10.Text = ("мана " + Palladin2.MP);
            label11.Text = ("здоровье " + Priest2.Hp);
            label12.Text = ("мана " + Priest2.MP);
            label13.Text = ("здоровье " + Shaman2.Hp);
            label14.Text = ("мана" + Shaman2.MP);
            label15.Text = ("здоровье " + Rogue2.Hp);
            label16.Text = ("мана " + Rogue2.MP);
            progressBar1.Maximum = ( Palladin1.Hp);
            progressBar2.Maximum = ( Palladin1.MP);
            progressBar3.Maximum = (Priest1.Hp);
            progressBar4.Maximum = ( Priest1.MP);
            progressBar5.Maximum = ( + Shaman1.Hp);
            progressBar6.Maximum = ( Shaman1.MP);
            progressBar7.Maximum = ( Rogue1.Hp);
            progressBar8.Maximum = (Rogue1.MP);
            progressBar9.Maximum = (  Palladin2.Hp);
            progressBar10.Maximum = ( Palladin2.MP);
            progressBar11.Maximum = ( Priest2.Hp);
            progressBar12.Maximum = ( Priest2.MP);
            progressBar13.Maximum = ( Shaman2.Hp);
            progressBar14.Maximum = ( Shaman2.MP);
            progressBar15.Maximum = ( Rogue2.Hp);
            progressBar16.Maximum = (Rogue2.MP);
            progressBar1.Value = (Palladin1.Hp);
            progressBar2.Value = (Palladin1.MP);
            progressBar3.Value = (Priest1.Hp);
            progressBar4.Value = (Priest1.MP);
            progressBar5.Value = (+Shaman1.Hp);
            progressBar6.Value = (Shaman1.MP);
            progressBar7.Value = (Rogue1.Hp);
            progressBar8.Value = (Rogue1.MP);
            progressBar9.Value = (Palladin2.Hp);
            progressBar10.Value = (Palladin2.MP);
            progressBar11.Value = (Priest2.Hp);
            progressBar12.Value = (Priest2.MP);
            progressBar13.Value = (Shaman2.Hp);
            progressBar14.Value = (Shaman2.MP);
            progressBar15.Value = (Rogue2.Hp);
            progressBar16.Value = (Rogue2.MP);
            

            //label1.Text = (" " + AllCharacters[0].HP);
            //label1.Text = (" " + AllCharacters[0].HP);
            //label1.Text = (" " + AllCharacters[0].HP);
            //label1.Text = (" " + AllCharacters[0].HP);
            //label1.Text = (" " + AllCharacters[0].HP);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            agressor = Palladin1;
            

            


        }

        private void button10_Click(object sender, EventArgs e)
        {
            agressor = Priest1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            agressor = Rogue1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            agressor = Shaman1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Palladin2.Hp = Palladin2.Hp - agressor.Damage;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Priest2.Hp = Priest2.Hp - agressor.Damage;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Rogue2.Hp = Rogue2.Hp - agressor.Damage;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Shaman2.Hp = Shaman2.Hp - agressor.Damage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Shaman1.Hp = Shaman1.Hp - agressor.Damage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Palladin1.Hp = Palladin1.Hp - agressor.Damage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Priest1.Hp = Priest1.Hp - agressor.Damage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rogue1.Hp = Rogue1.Hp - agressor.Damage;
        }

       
   
    }
}
