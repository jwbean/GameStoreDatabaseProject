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
        public Server()
        {
            InitializeComponent();
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
    }
}
