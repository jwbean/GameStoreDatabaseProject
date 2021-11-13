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
    }
}
