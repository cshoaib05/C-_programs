using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private List<body> snake = new List<body>();
        private body food = new body();

        public Form1()
        {
            InitializeComponent();

            new Prop();

            gametime.Interval = 1000 / Prop.speed;
            gametime.Tick += updateScreen;
            gametime.Start();


            startGame();
        }
        private void startGame()
        {
            labelgameover.Visible = false;

            new Prop();
            snake.Clear();
            body head = new body();
            head.x = 10;
            head.y = 5;
            snake.Add(head);

            labelScore.Text = Prop.score.ToString();
            GenerateFood();

        }
        private void GenerateFood()
        {
            int maxXpos = pbCanvas.Size.Width / Prop.width;
            int maxYpos = pbCanvas.Size.Width / Prop.height;

            Random randon = new Random();

            food = new body();
            food.x = randon.Next(0, maxXpos);
            food.y = randon.Next(0, maxYpos);
        }

        private void updateScreen(object sender,EventArgs e)
        {
            
            if (Prop.gameover == true)
            {
                if (input.keypressed(Keys.Enter))
                {
                    startGame();
                }
            }
            else
            {
                if (input.keypressed(Keys.Right) && Prop.navigate != Navigation.left)
                    Prop.navigate = Navigation.right;
                else if (input.keypressed(Keys.Left) && Prop.navigate != Navigation.left)
                    Prop.navigate = Navigation.left;
                else if (input.keypressed(Keys.Up) && Prop.navigate != Navigation.left)
                    Prop.navigate = Navigation.up;
                else if (input.keypressed(Keys.Down) && Prop.navigate != Navigation.left)
                    Prop.navigate = Navigation.down;

                moveplayer();

            }

            pbCanvas.Invalidate();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (Prop.gameover != false)
            {
                Brush snakeColour;
                for (int i = 0; i < snake.Count; i++)
                {
                    if (i == 0)
                        snakeColour = Brushes.Black;
                    else
                        snakeColour = Brushes.Green;

                    canvas.FillEllipse(snakeColour, new Rectangle(snake[i].x * Prop.width, snake[i].y * Prop.height, Prop.width, Prop.height));


                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.x * Prop.width, food.y * Prop.height, Prop.width, Prop.height));
                }
            }
            else
            {
                String gameover = "Game over\n your Score is : " + Prop.score;
                labelgameover.Text = gameover;
                labelgameover.Visible = true;

            }
        }


        private void moveplayer()
        {
            for (int i = snake.Count - 1; i > 0; i++)
            {
                if (i == 0)
                {
                    switch (Prop.navigate)
                    {
                        case Navigation.right:
                            snake[i].x++;
                            break;
                        case Navigation.left:
                            snake[i].y++;
                            break;
                        case Navigation.up:
                            snake[i].y--;
                            break;

                        case Navigation.down:
                            snake[i].x--;
                            break;
                    }
                }
                else
                {
                    snake[i].x = snake[i - 1].x;
                    snake[i].y = snake[i - 1].y;
                }
            }

        }
    }
}