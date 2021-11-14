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
    public partial class Server : Form
    {
        List<Models.User> users;
        List<Models.Game> games;
        List<Models.AverageHours> averageHours;
        List<Models.FirstMonthSales> firstMonthSales;
        List<Models.BestDayOFSales> bestDayOFSales;
        List<Models.ActiveUser> activeUsers;
        List<Models.TopSpender> topSpenders;
        List<Models.TopPlayers> topPlayers;
        UserAccess userAccess;
        GameAccess gameAccess;
        public Server()
        {
            InitializeComponent();
            userAccess = new UserAccess();
            gameAccess = new GameAccess();
            games = gameAccess.AllGames();
            foreach (var item in games)
            {
                GameBox.Items.Add(item.GameName);
            }
            users = userAccess.AllUsers();
            foreach (var item in users)
            {
                UserBox.Items.Add(item.UserName);
            }
            averageHours = userAccess.AverageHoursPlayed();
            foreach(var item in averageHours)
            {
                AverageHoursPlayed.Items.Add(item.GameName + ": " + item.AverageHoursPlayed);
            }
            firstMonthSales = gameAccess.FirstMonthSales();
            foreach (var item in firstMonthSales)
            {
                FirstMonthSales.Items.Add(item.GameName + " Copies: "+item.GamesSold+ " Sales: " + item.TotalSales);
            }
            activeUsers = userAccess.ActiveUsers();
            foreach (var item in activeUsers)
            {
                ActiveUser.Text = item.ActiveUsers.ToString();
            }
            bestDayOFSales = gameAccess.BestDayofSales();
            foreach (var item in bestDayOFSales)
            {
                TopDay.Items.Add("Day: "+item.PurchasedDate + " Copies: "+item.GamesSold+" Sales: "+ item.TotalSales);
            }
            topSpenders = userAccess.TopSpender();
            foreach (var item in topSpenders)
            {
                TopSpenders.Items.Add(item.UserName+": " + item.TotalSpent);
            }

        }

        private void Add_User_Button_Click(object sender, EventArgs e)
        {
            userAccess.CreateUser(UserName.Text, LastName.Text, FirstName.Text);
        }

        private void Add_Game_Button_Click(object sender, EventArgs e)
        {
            gameAccess.CreateGame(GameName.Text, Developer.Text, GenreName.Text, Int32.Parse(Price.Text));
        }

        private void Server_Load(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            userAccess.EditUser(UserBox.Text, EditFirstName.Text, EditLastName.Text);
        }

        private void EditGame_Click(object sender, EventArgs e)
        {
            gameAccess.EditGame(GameBox.Text, Int32.Parse(EditPrice.Text));
        }

        private void GameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TopPlayTime.Items.Clear();
            topPlayers = gameAccess.TopPlayers(GameBox.Text);
            foreach (var item in topPlayers)
            {
                TopPlayTime.Items.Add(item.UserName+": "+item.TotalHours);
            }
        }
    }
}
