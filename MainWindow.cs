using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonikaFoksLab1Zadanie
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            //inicjacja komponentów w oknie
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        //przycisk otwierający okno gry
        private void playButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
        }

        //przycisk wywołujący MessageBox z informacjami o grze
        private void helpButton_Click(object sender, EventArgs e)
        {
            string message = "In this game you have to shoot zombies. You are getting points, all you have to do is survive! Remender, don't shoot puppers and don't miss. Good luck.";
            string caption = "How to play?";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, button);
        }
        
        //przycisk wyjścia z gry
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
