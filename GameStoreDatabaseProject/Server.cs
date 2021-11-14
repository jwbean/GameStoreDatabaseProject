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
        public Server()
        {
            InitializeComponent();
            UserAccess userAccess = new UserAccess();
            GameAccess gameAccess = new GameAccess();
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

        }

        private void Add_User_Button_Click(object sender, EventArgs e)
        {
            UserAccess useraccess = new UserAccess();
            useraccess.CreateUser(UserName.Text, LastName.Text, FirstName.Text);
        }

        private void Add_Game_Button_Click(object sender, EventArgs e)
        {
            GameAccess gameAccess = new GameAccess();
            gameAccess.CreateGame(GameName.Text, Developer.Text, GenreName.Text, Int32.Parse(Price.Text));
        }

        private void Server_Load(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}
