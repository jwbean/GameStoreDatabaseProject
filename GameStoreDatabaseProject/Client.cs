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
        List<Models.Review> reviews;
        UserAccess userAccess;
        GameAccess gameAccess;
        public Client()
        {
            InitializeComponent();
            userAccess = new UserAccess();
            listOfUsers = userAccess.AllUsers();
            foreach (var user in listOfUsers)
            {
                UserList.Items.Add(user.UserName);
            }
            gameAccess = new GameAccess();
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
            ReleaseDate.Text = game.ReleaseDate.ToShortDateString();
            Price.Text = (game.Price).ToString();
            reviews = userAccess.GetReviews(game.GameName);
            ReviewBox.Items.Clear();
            foreach (var review in reviews)
            {
                ReviewBox.Items.Add((review.FiveStarScore).ToString() + ": "+review.Description);
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (LessThanFive.Checked)
            {
                Low2High.Checked = false;
                High2Low.Checked = false;
                FilterRelease.Checked = false;
            }
        }

        private void High2Low_CheckedChanged(object sender, EventArgs e)
        {
            if (High2Low.Checked)
            {
                Low2High.Checked = false;
                LessThanFive.Checked = false;
                FilterRelease.Checked = false;
            }
        }

        private void Low2High_CheckedChanged(object sender, EventArgs e)
        {
            if (Low2High.Checked)
            {
                High2Low.Checked = false;
                LessThanFive.Checked = false;
                FilterRelease.Checked = false;
            }
        }


        private void Name_Search_Click(object sender, EventArgs e)
        {
            GameBox.Items.Clear();
            GenreBox.SelectedItem = null;
            DeveloperList.SelectedItem = null;
            High2Low.Checked = false;
            Low2High.Checked = false;
            LessThanFive.Checked = false;
            FilterRelease.Checked = false;
            listOfGames = gameAccess.GetGame(GameNameSearch.Text);
            foreach (var game in listOfGames)
            {
                GameBox.Items.Add(game.GameName);
            }
        }

        private void Review_Submit_Click(object sender, EventArgs e)
        {
            string userName = UserList.Text;
            foreach (var user in listOfUsers)
            {
                if (String.Compare(user.UserName, userName) == 0)
                {
                    userAccess.CreateReview(user.UserId, LibraryBox.Text, ReviewDescription.Text,Int32.Parse(RatingScore.Text));
                    UserList_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void HighScore_CheckedChanged(object sender, EventArgs e)
        {
            if (HighScore.Checked)
            {
                ReviewBox.Items.Clear();
                LowScore.Checked = false;
                Recent.Checked = false;
                YourReview.Checked = false;
                reviews = userAccess.GetReviewsHigh(GameBox.Text);
                foreach (var review in reviews)
                {
                    ReviewBox.Items.Add((review.FiveStarScore).ToString() + ": " + review.Description);
                }
            }
            
        }

        private void LowScore_CheckedChanged(object sender, EventArgs e)
        {
            if (LowScore.Checked)
            {
                ReviewBox.Items.Clear();
                HighScore.Checked = false;
                Recent.Checked = false;
                YourReview.Checked = false;
                reviews = userAccess.GetReviewsLow(GameBox.Text);
                foreach (var review in reviews)
                {
                    ReviewBox.Items.Add((review.FiveStarScore).ToString() + ": " + review.Description);
                }
            }
            
        }

        private void Recent_CheckedChanged(object sender, EventArgs e)
        {
            if (Recent.Checked)
            {
                ReviewBox.Items.Clear();
                LowScore.Checked = false;
                HighScore.Checked = false;
                YourReview.Checked = false;
                reviews = userAccess.GetReviewsRecent(GameBox.Text);
                foreach (var review in reviews)
                {
                    ReviewBox.Items.Add((review.FiveStarScore).ToString() + ": " + review.Description);
                }
            }
            
        }

        private void Hours_Played_Button_Click(object sender, EventArgs e)
        {
            string userName = UserList.Text;
            foreach (var user in listOfUsers)
            {
                if (String.Compare(user.UserName, userName) == 0)
                {
                    userAccess.CreateSession(user.UserId, LibraryBox.Text, Int32.Parse(Hours.Text));
                    userAccess.UpdateLastActive(user.UserId);
                    UserList_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void FilterRelease_CheckedChanged(object sender, EventArgs e)
        {
            if (FilterRelease.Checked)
            {
                Low2High.Checked = false;
                High2Low.Checked = false;
                LessThanFive.Checked = false;
            }
        }

        private void YourReview_CheckedChanged(object sender, EventArgs e)
        {
            if (YourReview.Checked)
            {
                ReviewBox.Items.Clear();
                HighScore.Checked = false;
                LowScore.Checked = false;
                Recent.Checked = false;
                string userName = UserList.Text;
                foreach (var user in listOfUsers)
                {
                    if (String.Compare(user.UserName, userName) == 0)
                    {
                        reviews = userAccess.GetUserReviews(GameBox.Text, user.UserId);
                        foreach (var review in reviews)
                        {
                            ReviewBox.Items.Add((review.FiveStarScore).ToString() + ": " + review.Description);
                        }
                        break;
                    }
                }
            }
        }

        private void Filter_Button_Click(object sender, EventArgs e)
        {
            GameBox.Items.Clear();
            if(GenreBox.SelectedItem != null && DeveloperList.SelectedItem != null)
            {
                if (LessThanFive.Checked)
                {
                    listOfGames = gameAccess.GetGamesCheepGenreDeveloper(GenreBox.Text, DeveloperList.Text);
                }
                else if (High2Low.Checked)
                {
                    listOfGames = gameAccess.GetGamesHigh2LowGenreDeveloper(DeveloperList.Text,GenreBox.Text);
                }
                else if (Low2High.Checked)
                {
                    listOfGames = gameAccess.GetGamesLow2HighDeveloperGenre(DeveloperList.Text, GenreBox.Text);
                }
                else if (FilterRelease.Checked)
                {
                    listOfGames = gameAccess.GetGamesReleaseDateGenreDeveloper(GenreBox.Text, DeveloperList.Text);
                }
                else
                {
                    listOfGames = gameAccess.GetGamesDeveloperGenre(DeveloperList.Text, GenreBox.Text);
                }
                    
            }
            else if(GenreBox.SelectedItem != null && DeveloperList.SelectedItem == null)
            {
                if (LessThanFive.Checked)
                {
                    listOfGames = gameAccess.GetGamesCheepGenre(GenreBox.Text);
                }
                else if (High2Low.Checked)
                {
                    listOfGames = gameAccess.GetGamesHigh2LowGenre(GenreBox.Text);
                }
                else if (Low2High.Checked)
                {
                    listOfGames = gameAccess.GetGamesLow2HighGenre(GenreBox.Text);
                }
                else if (FilterRelease.Checked)
                {
                    listOfGames = gameAccess.GetGamesReleaseDateGenre(GenreBox.Text);
                }
                else
                {
                    listOfGames = gameAccess.GetGamesGenre(GenreBox.Text);
                }
            }
            else if (GenreBox.SelectedItem == null && DeveloperList.SelectedItem != null)
            {
                if (LessThanFive.Checked)
                {
                    listOfGames = gameAccess.GetGamesCheepDeveloper(DeveloperList.Text);
                }
                else if (High2Low.Checked)
                {
                    listOfGames = gameAccess.GetGamesHigh2LowDeveloper(DeveloperList.Text);
                }
                else if (Low2High.Checked)
                {
                    listOfGames = gameAccess.GetGamesLow2HighDeveloper(DeveloperList.Text);
                }
                else if (FilterRelease.Checked)
                {
                    listOfGames = gameAccess.GetGamesReleaseDateDeveloper(DeveloperList.Text);
                }
                else
                {
                    listOfGames = gameAccess.GetGamesDeveloper(DeveloperList.Text);
                }
            }
            else
            {
                if (LessThanFive.Checked)
                {
                    listOfGames = gameAccess.GetGamesCheep();
                }
                else if (High2Low.Checked)
                {
                    listOfGames = gameAccess.GetGamesHigh2Low();
                }
                else if (Low2High.Checked)
                {
                    listOfGames = gameAccess.GetGamesLow2High();
                }
                else if (FilterRelease.Checked)
                {
                    listOfGames = gameAccess.GetGamesReleaseDate();
                }
                else
                {
                    listOfGames = gameAccess.AllGames();
                }
            }
            foreach (var game in listOfGames)
            {
                GameBox.Items.Add(game.GameName);
            }
        }
    }
}
