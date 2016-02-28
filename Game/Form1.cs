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
        }

   
    }
}
