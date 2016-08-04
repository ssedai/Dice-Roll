#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion

namespace DiceGame
{
    public partial class Form1 : Form
    {
        #region Declaration

        Image[] diceImages;
        int[] dice;
        Random rand;

        #endregion

        #region Initialization

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.square_ios_app_xxl;
            diceImages[1] = Properties.Resources.red_die_1_th;
            diceImages[2] = Properties.Resources.red_die_2_th;
            diceImages[3] = Properties.Resources.red_die_3_th;
            diceImages[4] = Properties.Resources.red_die_4_th;
            diceImages[5] = Properties.Resources.red_die_5_th;
            diceImages[6] = Properties.Resources.red_die_6_th;

            dice = new int[5] { 0, 0, 0, 0, 0 };

            rand = new Random();
        }

        #endregion

        #region Private Methods

        private void btn_rollDice_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void RollDice()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);

            }

            label1.Image = diceImages[dice[0]];
            label2.Image = diceImages[dice[1]];
            label3.Image = diceImages[dice[2]];
            label4.Image = diceImages[dice[3]];
            label5.Image = diceImages[dice[4]];
        }

        #endregion
    }
}
