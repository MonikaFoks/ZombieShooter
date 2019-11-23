using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace MonikaFoksLab1Zadanie
{
    public partial class Game : Form
    {
     
        //utworzenie nowej zmiennej random do umieszczania komponentów na planszy
        Random random = new Random();
        //zmienna random do ruchu Jumpscarea
        Random randomJump = new Random();

        //efekty dźwiękowe gry i jumpscarea
        SoundPlayer audio = new SoundPlayer(MonikaFoksLab1Zadanie.Properties.Resources.gameMusic);
        SoundPlayer scream = new SoundPlayer(MonikaFoksLab1Zadanie.Properties.Resources.jumpScareScream);
        SoundPlayer gameOver = new SoundPlayer(MonikaFoksLab1Zadanie.Properties.Resources.gameOver);

        //inicjowanie zmiennych odpowiedzialnych za wynik, czas i trafione/nietrafione strzały
        int score = 0;
        int total_shots = 0;
        int missed_shots = 0;
        int puppers = 0;
        int time = 0;

        //funkcja inicjująca komponenty
        public Game()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            audio.Play();
        }

        //funkcja odpowiadająca za pokazywanie się Jumpscarea i zatrzymująca muzykę i timery, gdy Jumpscare jest na planszy
        void jumpScare()
        {
            jumpScarePic.Visible = true;
            jumpScareJumpTimer.Start();
            secondZombieTimer.Stop();
            firstZombieTimer.Stop();
            batTimer.Stop();
            pupperTimer.Stop();
            audio.Stop();
            scream.Play();
        }

        //Funkcja usuwająca Jumpscarea i wznawiająca timery i muzykę
        void removeJumpScare()
        {
            secondZombieTimer.Start();
            firstZombieTimer.Start();
            batTimer.Start();
            pupperTimer.Start();
            jumpScarePic.Visible = false;
            scream.Stop();
            audio.Play();
        }

        //timer trwania gry
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            time++;
            gameTimeLabel.Text = "Time: " + time;
            
        }

        //funkcja obliczająca ilość dobrych strzałów
        void goodShot()
        {
            total_shots++;
            scoreLabel.Text = "Score: " + score;
            totalShotsLabel.Text = "Total shots: " + total_shots;
            if (score == 13)
                jumpScare();
        }

        //funkcja obliczająca ilość nietrafionych strzałów
        void missedShot()
        {
            missed_shots++;
            total_shots++;
            missedShotLabel.Text = "Missed shots: " + missed_shots;
            totalShotsLabel.Text = "Total shots: " + total_shots;

            //w przypadku 10 złych trafień gra się kończy i pokazują się informacje o końcu gry.
            //grę można zresetować albo z niej wyjść
            if (missed_shots == 10)
            {
                string message = "You missed 5 times! Zombies ate your brain.";
                messageLabel.Text = message;

                //schowanie wszystkich komponentów oprócz przycisków
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(PictureBox))
                        c.Visible = false;
                    else if(c.GetType() != typeof(Button))
                        c.Hide();
                }

                messageLabel.Visible = true;
                gameOverLabel.Visible = true;

                //muzyka gry zostaje zatrzymana, pojawia się muzyka końca gry
                audio.Stop();
                gameOver.Play();

                //zatrzymanie timerów, aby komponenty przestały się pokazywać
                labelsTimer.Stop();
                gameTimer.Stop();
                secondZombieTimer.Stop();
                firstZombieTimer.Stop();
                batTimer.Stop();
                pupperTimer.Stop();
            }
        }

        //funkcja obliczjąca ilość trafień w psa (złych trafień)
        void badShot()
        {
            missed_shots++;
            total_shots++;
            scoreLabel.Text = "Score: " + score;
            missedShotLabel.Text = "Missed shots: " + missed_shots;
            totalShotsLabel.Text = "Total shots: " + total_shots;
            badShotLabel.Text = "Puppers: " + puppers;
        }
        //przycisk powodujący powrót do głownego okna
        private void exitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
            audio.Stop();
        }

        //funkcja zegara kontrolującego widoczność i umieszczenie Zobmie1
        private void firstZombieTimer_Tick(object sender, EventArgs e)
        {
            zombie1.Visible = true;
            firstZombieVisibleTimer.Start();
            int x, y;
            x = random.Next(50, 900);
            y = random.Next(300, 500);
            zombie1.Location = new Point(x, y);
        }

        //funkcja zegara kontrolującego widoczność i umieszczenie Zobmie1
        private void secondZombieTimer_Tick(object sender, EventArgs e)
        {
            secondZombieVisibleTimer.Start();
            zombie2.Visible = true;
            int x, y;
            x = random.Next(50, 900);
            y = random.Next(300, 500);
            zombie2.Location = new Point(x, y);
        }

        //timer kontrolujący pojawianie się psa w losowym miejscu na "ziemi"
        private void pupperTimer_Tick(object sender, EventArgs e)
        {
            pupperOnBoardTimer.Start();
            pupper.Visible = true;
            int x, y;
            x = random.Next(50, 900);
            y = random.Next(300, 500);
            pupper.Location = new Point(x, y);
        }

        //funkcja poruszająca Jumpscarem
        private void jumpScareJumpTimer_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = random.Next(-220, -100);
            y = random.Next(-20, 10);
            jumpScarePic.Location = new Point(x, y);
        }

        //timer kontrolujący pojawianie się Jumpscarea
        private void jumpscareTimer_Tick(object sender, EventArgs e)
        {
            jumpScare();
            jumpscareTimer.Stop();
        }

        //funkcja kontrolująca timer pojawiania się nietoperza
        private void batTimer_Tick(object sender, EventArgs e)
        {
            batVisibleTimer.Start();
            bat.Visible = true;
            int x, y;
            x = random.Next(50, 900);
            y = random.Next(0, 300);
            bat.Location = new Point(x, y);
        }

        //funkcja dodająca punkt i usuwająca z planszy Zombie1 po trafieniu go
        private void zombie1_Click(object sender, EventArgs e)
        {
            score++;
            zombie1.Visible = false;
            goodShot();
        }

        //funkcja dodająca 3 punkty i usuwająca z planszy Zombie2 po trafieniu go
        private void zombie2_Click(object sender, EventArgs e)
        {
            score = score + 3;
            zombie2.Visible = false;
            goodShot();
        }

        //funkcja usuwająca jumpScarea z ekranu i dodająca za niego 10 punktów
        private void jumpScare_Click(object sender, EventArgs e)
        {
            score = score + 10;
            removeJumpScare();
            goodShot();
        }

        //funkcja dodająca 2 punkty za trafienie nietoperza i usuwająca go z planszy
        private void bat_Click(object sender, EventArgs e)
        {
            score = score + 2;
            bat.Visible = false;
            goodShot();
        }

        //funkcja odejmująca 10 punktów za trafienie psa, usuwająca go z planszy po trafieniu
        //oraz w przypadku trzech trafień psa kończąca grę i usuwająca komponenty z planszy
        private void pupper_Click(object sender, EventArgs e)
        {
            score = score - 10;
            pupper.Visible = false;
            messageLabel.Visible = true;
            puppers++;
            badShot();
            labelsTimer.Start();

            //w przypadku 3 trafień psa gra się kończy i pokazują się informacje o końcu gry.
            //grę można zresetować albo z niej wyjść
            if (puppers == 3)
            {
                string message = "You shoot 3 puppers! Zombies ate you in revenge.";
                messageLabel.Text = message;
                
                foreach(Control c in this.Controls)
                {
                    if(c.GetType() == typeof(PictureBox))
                        c.Visible = false;
                    else if (c.GetType() != typeof(Button))
                        c.Hide();
                }

                //zatrzymanie muzyki gry w celu odtworzenia dźwięku końca gry
                audio.Stop();
                gameOver.Play();
                
                //pojawienie się informacji o przegraniu gry
                messageLabel.Visible = true;
                gameOverLabel.Visible = true;

                //zatrzymanie timerów, aby komponenty przestały się pokazywać
                labelsTimer.Stop();
                gameTimer.Stop();
                secondZombieTimer.Stop();
                firstZombieTimer.Stop();
                batTimer.Stop();
                pupperTimer.Stop();

            }
        }

        //funkcja uznająca kliknięcie tła okna zamiast zombie/psa/nietoperza za nietrafiony strzał
        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            missedShot();
        }

        //timer kontrolujący czas widoczności psa na planszy
        private void pupperOnBoardTimer_Tick(object sender, EventArgs e)
        {
            pupperOnBoardTimer.Stop();
            pupper.Visible = false;
        }

        //funkcja kontrolująca widoczność wiadomości o postrzeleniu psa
        private void labelsTimer_Tick(object sender, EventArgs e)
        {
            messageLabel.Visible = false;
            labelsTimer.Stop();
        }
        
        //funcja kontrolująca timer widoczności Zombie1 na planszy
        private void firstZombieVisibleTimer_Tick(object sender, EventArgs e)
        {
            zombie1.Visible = false;
            firstZombieVisibleTimer.Stop();
        }

        //funcja kontrolująca timer widoczności Zombie2 na planszy
        private void secondZombieVisibleTimer_Tick(object sender, EventArgs e)
        {
            zombie2.Visible = false;
            secondZombieVisibleTimer.Stop();
        }

        //funcja kontrolująca timer widoczności nietoperza na planszy
        private void batVisibleTimer_Tick(object sender, EventArgs e)
        {
            bat.Visible = false;
            batVisibleTimer.Stop();
        }

        //przycisk resetu; resetuje wszystkie zmienne (time, score itd.) 
        private void restartButton_Click(object sender, EventArgs e)
        {
            time = 0;
            score = 0;
            missed_shots = 0;
            total_shots = 0;
            missedShotLabel.Text = "Missed shots: " + missed_shots;
            scoreLabel.Text = "Score: " + score;
            totalShotsLabel.Text = "Total shots: " + total_shots;
            badShotLabel.Text = "Puppers: " + puppers;

            //restart timerów
            labelsTimer.Start();
            gameTimer.Start();
            secondZombieTimer.Start();
            firstZombieTimer.Start();
            batTimer.Start();
            pupperTimer.Start();

            //ponowne wywołanie komponentów na planszy
            foreach (Control c in this.Controls)
                if(c.GetType() != typeof(PictureBox))
                    c.Show();

            //schowanie informacji o końcu gry
            gameOverLabel.Visible = false;
            messageLabel.Visible = false;

            //wznowienie muzyki
            audio.Play();
        } 
    }
}
