using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Animation1
{
    public partial class Form1 : Form
    {
        Matador game;
        Graphics g, g1, g2;
        
        List<Car> availableCars = new List<Car> { new Car { Name = "Ford" }, new Car { Name = "BMW" },
                new Car { Name = "Toyota" }, new Car { Name = "Ferrari" }, new Car { Name = "Volkswagen" } };

        public Form1()
        {
            InitializeComponent();

            // build game
            game = new Matador();
            game.AddStreet("Rådhusplads", 420, 110);
            game.AddStreet("Fængsel", 520, 170);
            game.AddStreet("Hjørring", 420, 230);
            game.AddStreet("Viborg", 320, 290);
            game.AddStreet("Ålborg", 220, 230);
            game.AddStreet("Vejle", 120, 170);
            game.AddStreet("Århus", 220, 110);

        }

        private void ChangePlayer_MouseClick(object sender, MouseEventArgs e)
        {
            var nextIndex = game.Cars.IndexOf(game.currentPlayer) + 1;
            if (nextIndex == game.Cars.Count) nextIndex = 0;
            game.currentPlayer = game.Cars[nextIndex];
            Player.Text = game.currentPlayer.Name;
        }

        private void DiceRoll_MouseClick(object sender, MouseEventArgs e)
        {
            rolledValue.Text = "";
            Random rand = new Random();
            var rolled = rand.Next(1, 7);
            rolledValue.Text = rolled.ToString();
            //game.MoveCar(game.currentPlayer.Name, rolled);
        }

        //private void playerNumber_KeyUp(object sender, KeyEventArgs e)
        //{
        //    ErrorMessage.Text = "";
        //    var valid = int.TryParse(playerNumber.Text, out int nrPlayers);
        //    Console.WriteLine(nrPlayers);

        //    // Check valid number of players
        //    if (!valid || nrPlayers < 1 || nrPlayers > 5)
        //    {
        //        ErrorMessage.Text = "Not a valid number!";
        //    }
        //    else
        //    {
        //        // assign cars to players
        //        for (int i = 0; i < nrPlayers; i++)
        //        {
        //            game.Cars.Add(availableCars[i]);
        //        }
        //        // put cars on Start
        //        game.CarsToStart();
        //        game.PrintBoard(g);
        //    }
        //}

        private async void Form1_Shown(object sender, EventArgs e)
        {
            await Task.Delay(500);

            g = pictureBox1.CreateGraphics();
            g.Clear(Color.LightGoldenrodYellow);

            g1 = TotalCars.CreateGraphics();
            g1.Clear(Color.LightGoldenrodYellow);

            g2 = DiceRoll.CreateGraphics();

            game.PrintBoard(g);
            game.PrintTotalCars(g1);
            game.PrintDie(g2);
        }
    }
}
