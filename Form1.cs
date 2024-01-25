using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGColorTest
{
    public enum Colors
    {
        White = 2,
        Blue = 3,
        Black = 5,
        Red = 7,
        Green = 11,
    }

    public partial class MainWindow : Form
    {
        private string[] combinationNames = new string[24];

        private int attempts = 0;
        private int correct = 0;
        private int currentCombo = 0;

        Timer timer;
        Stopwatch sw;

        public MainWindow()
        {
            InitializeComponent();
            testPanel.Visible = false;
            reward.Visible = false;
            titleScreen.Visible = true;

            //initialize combination names in hash table
            combinationNames[23] = "jund";
            combinationNames[16] = "bant";
            combinationNames[15] = "grixis";
            combinationNames[20] = "naya";
            combinationNames[10] = "esper";
            combinationNames[12] = "jeskai";
            combinationNames[14] = "mardu";
            combinationNames[19] = "sultai";
            combinationNames[21] = "temur";
            combinationNames[18] = "abzan";
        }

        private void Beginbutton_Click(object sender, EventArgs e)
        {
            titleScreen.Visible = false;
            testPanel.Visible = true;
            colorGuess.Clear();
            NewTest("test");
            this.ActiveControl = colorGuess;
        }

        private void NewTest(string colorCombo)
        {
            Random rnd = new Random();
            Colors[] colorArray = { Colors.White, Colors.Blue, Colors.Black, Colors.Red, Colors.Green };
            Bitmap[] imageArray = new Bitmap[12];
            imageArray[(int)Colors.White] = Properties.Resources.white;
            imageArray[(int)Colors.Blue] = Properties.Resources.blue;
            imageArray[(int)Colors.Black] = Properties.Resources.black;
            imageArray[(int)Colors.Red] = Properties.Resources.red;
            imageArray[(int)Colors.Green] = Properties.Resources.green;

            Colors[] pickedColors = new Colors[3];

            for(int i = 0; i < 3; i++)
            {
                int pick = rnd.Next(0, 5);
                while(pickedColors[0] == colorArray[pick] || pickedColors[1] == colorArray[pick] || pickedColors[2] == colorArray[pick])
                {
                    pick = rnd.Next(0, 5);
                }
                pickedColors[i] = colorArray[pick];
            }

            currentCombo = (int)pickedColors[0] + (int)pickedColors[1] + (int)pickedColors[2];

            leftColor.Image = imageArray[(int)pickedColors[0]];
            leftColor.Refresh();
            leftColor.Visible = true;

            middleColor.Image = imageArray[(int)pickedColors[1]];
            middleColor.Refresh();
            middleColor.Visible = true;

            rightColor.Image = imageArray[(int)pickedColors[2]];
            rightColor.Refresh();
            rightColor.Visible = true;
        }

        private void ColorGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                attempts++;

                // check if correct and increment score
                string guess = colorGuess.Text.ToLower();

                if(guess == combinationNames[currentCombo])
                {
                    Guess(true);
                }
                else
                {
                    Guess(false);
                }

                // display proper text
                attemptsText.Text = attempts.ToString();
                correctText.Text = correct.ToString();

                Beginbutton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void Guess(bool correctGuess)
        {
            if (reward.Visible == true)
            {
                timer.Stop();
                sw.Stop();
                reward.Visible = false;
            }

            if (correctGuess == true)
            {
                correct++;
                reward.ForeColor = Color.Green;
                reward.Text = "Correct!";
            }
            else // !correctGuess
            {
                reward.ForeColor = Color.Red;
                reward.Text = "Wrong!";
            }

            reward.Visible = true;
            timer = new Timer();
            sw = new Stopwatch();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
            sw.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if(sw.Elapsed.Seconds >= 2)
            {
                timer.Stop();
                sw.Stop();
                reward.Visible = false;
            }
        }
    }
}
