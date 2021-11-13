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
        public Client()
        {
            InitializeComponent();
            List<String> listOfUsers = new List<string> { "User1", "User2", "user3", "user4", "user5" };
            foreach (String user in listOfUsers)
            {
                UserList.Items.Add(user);
            }
        }

        private void RatingTrackBar_Scroll(object sender, System.EventArgs e)
        {
            // Display the trackbar value in the text box.
            RatingScore.Text = "" + ((double)RatingTrackBar.Value / 10);
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
    }
}
