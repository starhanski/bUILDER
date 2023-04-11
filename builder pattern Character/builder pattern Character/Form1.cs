using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace builder_pattern_Character
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int randomattack = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Character character = new Character();
            if(radioButton1.Checked)
            {
                WarriorBuilder warriorBuilder = new WarriorBuilder();
                warriorBuilder.SetHealth(100);
                warriorBuilder.SetAttack(randomattack);
                warriorBuilder.SetClass("Warrior");
                warriorBuilder.SetStrength(80);
                warriorBuilder.SetAbilities("Stamina Boost ,Shieldblock");
                 character = warriorBuilder.GetCharacter();
            }
            else if(radioButton2.Checked)
            {
                MageBuilder mageBuilder = new MageBuilder();
                mageBuilder.SetHealth(80);
                mageBuilder.SetAttack(randomattack);
                mageBuilder.SetClass("Mage");
                mageBuilder.SetStrength(30);
                mageBuilder.SetAbilities("Fireball, Self Heal");
                character = mageBuilder.GetCharacter();
            }
            else if (radioButton3.Checked)
            {
                ArcherBuilder archerBuilder = new ArcherBuilder();
                archerBuilder.SetHealth(80);
                archerBuilder.SetAttack(randomattack);
                archerBuilder.SetClass("Archer");
                archerBuilder.SetStrength(30);
                archerBuilder.SetAbilities("IceBow, Dash, Crack");
              character = archerBuilder.GetCharacter();
            }


            MessageBox.Show($"Yor Character: \n Class: {character.Class} \n Ability Power: {character.Attack} \n Abilities: {character.Abilities}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            randomattack = rand.Next(0,100);
            label2.Text = randomattack.ToString();
        }
    }
}
