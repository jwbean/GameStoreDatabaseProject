using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreDatabaseProject
{
    public partial class Client : Form
    {
        List<Models.User> listOfUsers;
        List<Models.Game> listOfGames;
        List<Models.Library> libraryGames;
        List<Models.Genre> genres;
        List<Models.Developer> developers;
        public Client()
        {
            InitializeComponent();
            UserAccess userAcess = new UserAccess();
            listOfUsers = userAcess.AllUsers();
            foreach (var user in listOfUsers)
            {
                UserList.Items.Add(user.UserName);
            }
            GameAccess gameAccess = new GameAccess();
            listOfGames = gameAccess.AllGames();
            foreach(var game in listOfGames)
            {
                GameBox.Items.Add(game.GameName);
            }
            genres = gameAccess.GetGenres();
            foreach(var genre in genres)
            {
                GenreBox.Items.Add(genre.GenreName);
            }
            developers = gameAccess.GetDeveloper();
            foreach (var developer in developers)
            {
                DeveloperList.Items.Add(developer.DeveloperName);
            }

        }

        private void RatingTrackBar_Scroll(object sender, System.EventArgs e)
        {
            // Display the trackbar value in the text box.
            RatingScore.Text = "" + ((double)RatingTrackBar.Value / 10);
        }


        private void GameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Game game = listOfGames[GameBox.SelectedIndex];
            Developer.Text = game.DeveloperName;
            Genre.Text = game.GenreName;
            ReleaseDate.Text = (game.ReleaseDate).ToString();
            Price.Text = (game.Price).ToString();
        }

        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LibraryBox.Items.Clear();
            LibraryAccess libraryAccess = new LibraryAccess();
            libraryGames = libraryAccess.GetLibrary(UserList.Text);
            foreach (var game in libraryGames)
            {
                LibraryBox.Items.Add(game.GameName);
            }
        }

        private void Buy_Button_Click(object sender, EventArgs e)
        {
            string userName = UserList.Text;
            foreach(var user in listOfUsers)
            {
                if (String.Compare(user.UserName, userName) == 0)
                {
                    LibraryAccess libraryAccess = new LibraryAccess();
                    libraryAccess.CreateLibrary(user.UserId, GameBox.Text);
                    UserList_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void GenreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameBox.Items.Clear();
            DeveloperList.SelectedItem = null;
            High2Low.Checked = false;
            Low2High.Checked = false;
            LessThanFive.Checked = false;
            GameAccess gameAccess = new GameAccess();
            listOfGames = gameAccess.GetGamesGenre(GenreBox.Text);
            foreach (var game in listOfGames)
            {
                GameBox.Items.Add(game.GameName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GameBox.Items.Clear();
            GameAccess gameAccess = new GameAccess();
            GenreBox.SelectedItem = null;
            Low2High.Checked = false;
            High2Low.Checked = false;
            if (LessThanFive.Checked)
            {
               
                listOfGames = gameAccess.GetGamesCheep();
                foreach (var game in listOfGames)
                {
                    GameBox.Items.Add(game.GameName);
                }
            }
            else
            {
                listOfGames = gameAccess.AllGames();
                foreach (var game in listOfGames)
                {
                    GameBox.Items.Add(game.GameName);
                }
            }
        }

        private void High2Low_CheckedChanged(object sender, EventArgs e)
        {
            GameBox.Items.Clear();
            GameAccess gameAccess = new GameAccess();
            GenreBox.SelectedItem = null;
            Low2High.Checked = false;
            LessThanFive.Checked = false;
            if (High2Low.Checked)
            {
                listOfGames = gameAccess.GetGamesHigh2Low();
                foreach (var game in listOfGames)
                {
                    GameBox.Items.Add(game.GameName);
                }
            }
            else
            {
                listOfGames = gameAccess.AllGames();
                foreach (var game in listOfGames)
                {
                    GameBox.Items.Add(game.GameName);
                }
            }
        }

        private void Low2High_CheckedChanged(object sender, EventArgs e)
        {
            GameBox.Items.Clear();
            GameAccess gameAccess = new GameAccess();
            GenreBox.SelectedItem = null;
            High2Low.Checked = false;
            LessThanFive.Checked = false;
            if (Low2High.Checked)
            {
                listOfGames = gameAccess.GetGamesLow2High();
                foreach (var game in listOfGames)
                {
                    GameBox.Items.Add(game.GameName);
                }
            }
            else
            {
                listOfGames = gameAccess.AllGames();
                foreach (var game in listOfGames)
                {
                    GameBox.Items.Add(game.GameName);
                }
            }
        }

        private void DeveloperList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameBox.Items.Clear();
            GenreBox.SelectedItem = null;
            High2Low.Checked = false;
            Low2High.Checked = false;
            LessThanFive.Checked = false;
            GameAccess gameAccess = new GameAccess();
            listOfGames = gameAccess.GetGamesDeveloper(DeveloperList.Text);
            foreach (var game in listOfGames)
            {
                GameBox.Items.Add(game.GameName);
            }
        }

        private void Name_Search_Click(object sender, EventArgs e)
        {
            GameBox.Items.Clear();
            GameAccess gameAccess = new GameAccess();
            listOfGames = gameAccess.GetGame(GameNameSearch.Text);
            foreach (var game in listOfGames)
            {
                GameBox.Items.Add(game.GameName);
            }
        }
    }
}
