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

            Startgamebutton.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
                Character Palladin1 = new Palladin(800, 400, 80);
            Character Palladin2 = new Palladin(800, 400, 80);
            Character Priest1 = new Priest(400, 900, 30);
            Character Priest2 = new Priest(400, 900, 30);
            Character Shaman1 = new Shaman(500, 700, 50);
            Character Shaman2 = new Shaman(500, 700, 50);
            Character Rogue1 = new Rogue(360, 500, 100);
            Character Rogue2 = new Rogue(360, 500, 100);
            List<Character> AllCharacters = new List<Character>();

            {


                AllCharacters.Add(Palladin1);
                AllCharacters.Add(Palladin2);
                AllCharacters.Add(Priest1);
                AllCharacters.Add(Priest2);
                AllCharacters.Add(Shaman1);
                AllCharacters.Add(Shaman2);
                AllCharacters.Add(Rogue1);
                AllCharacters.Add(Rogue2);
            }
            label1.Text = (" " + AllCharacters[0].HP);
            label2.Text = (" " + AllCharacters[0].MP);
            label3.Text = (" " + AllCharacters[1].HP);
            label4.Text = (" " + AllCharacters[1].MP);
            label5.Text = (" " + AllCharacters[2].HP);
            label6.Text = (" " + AllCharacters[2].MP);
            label7.Text = (" " + AllCharacters[3].HP);
            label8.Text = (" " + AllCharacters[3].MP);
            label9.Text = (" " + AllCharacters[4].HP);
            label10.Text = (" " + AllCharacters[4].MP);
            label11.Text = (" " + AllCharacters[5].HP);
            label12.Text = (" " + AllCharacters[5].MP);
            label13.Text = (" " + AllCharacters[6].HP);
            label14.Text = (" " + AllCharacters[6].MP);
            label15.Text = (" " + AllCharacters[7].HP);
            label16.Text= (" " + AllCharacters[7].MP);

            //label1.Text = (" " + AllCharacters[0].HP);
            //label1.Text = (" " + AllCharacters[0].HP);
            //label1.Text = (" " + AllCharacters[0].HP);
            //label1.Text = (" " + AllCharacters[0].HP);
            //label1.Text = (" " + AllCharacters[0].HP);

        }

   
    }
}
