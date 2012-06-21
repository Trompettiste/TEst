using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BestGameOfTheWorld
{
    public partial class BGOTW : Form
    {
        private int tempsRestant;

        public BGOTW()
        {
            InitializeComponent();

            tempsRestant = 10;
            label1.Text = tempsRestant + " s";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tempsRestant--;
            label1.Text = tempsRestant + " s";            

            if (tempsRestant == 0)
            {
                timer.Enabled = false;


                button1.Text = "Play again";
                MessageBox.Show("You win !");

                tempsRestant = 10;
                label1.Text = tempsRestant + " s";                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;

                tempsRestant = 10;
                label1.Text = tempsRestant + " s";

                button1.Text = "Play again";
                MessageBox.Show("You win !");                
            }
            else
            {
                button1.Text = "Click here to win";
                timer.Enabled = true;
            }
        }
    }
}