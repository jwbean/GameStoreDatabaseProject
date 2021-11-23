namespace GameStoreDatabaseProject
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserList = new System.Windows.Forms.ComboBox();
            this.GameBox = new System.Windows.Forms.ListBox();
            this.GameDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RatingScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReviewDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Developer = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LibraryBox = new System.Windows.Forms.ListBox();
            this.Buy_Button = new System.Windows.Forms.Button();
            this.GenreBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LessThanFive = new System.Windows.Forms.CheckBox();
            this.High2Low = new System.Windows.Forms.CheckBox();
            this.Low2High = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DeveloperList = new System.Windows.Forms.ComboBox();
            this.GameNameSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Name_Search = new System.Windows.Forms.Button();
            this.ReviewBox = new System.Windows.Forms.ListBox();
            this.RatingTrackBar = new System.Windows.Forms.TrackBar();
            this.Review_Submit = new System.Windows.Forms.Button();
            this.Recent = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.HighScore = new System.Windows.Forms.CheckBox();
            this.LowScore = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.TextBox();
            this.Hours_Played_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterRelease = new System.Windows.Forms.CheckBox();
            this.YourReview = new System.Windows.Forms.CheckBox();
            this.Filter_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RatingTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(1024, 18);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(121, 21);
            this.UserList.TabIndex = 0;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
            // 
            // GameBox
            // 
            this.GameBox.FormattingEnabled = true;
            this.GameBox.Location = new System.Drawing.Point(10, 80);
            this.GameBox.Name = "GameBox";
            this.GameBox.Size = new System.Drawing.Size(210, 329);
            this.GameBox.TabIndex = 1;
            this.GameBox.SelectedIndexChanged += new System.EventHandler(this.GameBox_SelectedIndexChanged);
            // 
            // GameDetails
            // 
            this.GameDetails.AutoSize = true;
            this.GameDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDetails.Location = new System.Drawing.Point(236, 86);
            this.GameDetails.Name = "GameDetails";
            this.GameDetails.Size = new System.Drawing.Size(86, 13);
            this.GameDetails.TabIndex = 2;
            this.GameDetails.Text = "Game Details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Developer: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Release Date:";
            // 
            // RatingScore
            // 
            this.RatingScore.Location = new System.Drawing.Point(852, 119);
            this.RatingScore.Name = "RatingScore";
            this.RatingScore.Size = new System.Drawing.Size(38, 20);
            this.RatingScore.TabIndex = 8;
            this.RatingScore.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(758, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rating out of 5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(796, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Create Review";
            // 
            // ReviewDescription
            // 
            this.ReviewDescription.Location = new System.Drawing.Point(760, 186);
            this.ReviewDescription.Multiline = true;
            this.ReviewDescription.Name = "ReviewDescription";
            this.ReviewDescription.Size = new System.Drawing.Size(170, 61);
            this.ReviewDescription.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Genre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Store";
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Location = new System.Drawing.Point(302, 119);
            this.Developer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(0, 13);
            this.Developer.TabIndex = 14;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(283, 148);
            this.Genre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(0, 13);
            this.Genre.TabIndex = 15;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Location = new System.Drawing.Point(312, 177);
            this.ReleaseDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(0, 13);
            this.ReleaseDate.TabIndex = 16;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(280, 208);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(0, 13);
            this.Price.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(968, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "User: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1010, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Library";
            // 
            // LibraryBox
            // 
            this.LibraryBox.FormattingEnabled = true;
            this.LibraryBox.Location = new System.Drawing.Point(937, 86);
            this.LibraryBox.Name = "LibraryBox";
            this.LibraryBox.Size = new System.Drawing.Size(208, 251);
            this.LibraryBox.TabIndex = 20;
            // 
            // Buy_Button
            // 
            this.Buy_Button.Location = new System.Drawing.Point(154, 420);
            this.Buy_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Buy_Button.Name = "Buy_Button";
            this.Buy_Button.Size = new System.Drawing.Size(56, 30);
            this.Buy_Button.TabIndex = 21;
            this.Buy_Button.Text = "Buy";
            this.Buy_Button.UseVisualStyleBackColor = true;
            this.Buy_Button.Click += new System.EventHandler(this.Buy_Button_Click);
            // 
            // GenreBox
            // 
            this.GenreBox.FormattingEnabled = true;
            this.GenreBox.Location = new System.Drawing.Point(322, 270);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(121, 21);
            this.GenreBox.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(236, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Filter:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(234, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Genre:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(250, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 25;
            // 
            // LessThanFive
            // 
            this.LessThanFive.AutoSize = true;
            this.LessThanFive.Location = new System.Drawing.Point(237, 320);
            this.LessThanFive.Margin = new System.Windows.Forms.Padding(2);
            this.LessThanFive.Name = "LessThanFive";
            this.LessThanFive.Size = new System.Drawing.Size(47, 17);
            this.LessThanFive.TabIndex = 26;
            this.LessThanFive.Text = "< $5";
            this.LessThanFive.UseVisualStyleBackColor = true;
            this.LessThanFive.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // High2Low
            // 
            this.High2Low.AutoSize = true;
            this.High2Low.Location = new System.Drawing.Point(341, 320);
            this.High2Low.Margin = new System.Windows.Forms.Padding(2);
            this.High2Low.Name = "High2Low";
            this.High2Low.Size = new System.Drawing.Size(108, 17);
            this.High2Low.TabIndex = 27;
            this.High2Low.Text = "Price HighToLow";
            this.High2Low.UseVisualStyleBackColor = true;
            this.High2Low.CheckedChanged += new System.EventHandler(this.High2Low_CheckedChanged);
            // 
            // Low2High
            // 
            this.Low2High.AutoSize = true;
            this.Low2High.Location = new System.Drawing.Point(236, 340);
            this.Low2High.Margin = new System.Windows.Forms.Padding(2);
            this.Low2High.Name = "Low2High";
            this.Low2High.Size = new System.Drawing.Size(108, 17);
            this.Low2High.TabIndex = 28;
            this.Low2High.Text = "Price LowToHigh";
            this.Low2High.UseVisualStyleBackColor = true;
            this.Low2High.CheckedChanged += new System.EventHandler(this.Low2High_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Developer:";
            // 
            // DeveloperList
            // 
            this.DeveloperList.FormattingEnabled = true;
            this.DeveloperList.Location = new System.Drawing.Point(322, 293);
            this.DeveloperList.Name = "DeveloperList";
            this.DeveloperList.Size = new System.Drawing.Size(121, 21);
            this.DeveloperList.TabIndex = 29;
            // 
            // GameNameSearch
            // 
            this.GameNameSearch.Location = new System.Drawing.Point(304, 397);
            this.GameNameSearch.Multiline = true;
            this.GameNameSearch.Name = "GameNameSearch";
            this.GameNameSearch.Size = new System.Drawing.Size(121, 19);
            this.GameNameSearch.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(234, 397);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Name:";
            // 
            // Name_Search
            // 
            this.Name_Search.Location = new System.Drawing.Point(369, 432);
            this.Name_Search.Margin = new System.Windows.Forms.Padding(2);
            this.Name_Search.Name = "Name_Search";
            this.Name_Search.Size = new System.Drawing.Size(56, 24);
            this.Name_Search.TabIndex = 33;
            this.Name_Search.Text = "Search";
            this.Name_Search.UseVisualStyleBackColor = true;
            this.Name_Search.Click += new System.EventHandler(this.Name_Search_Click);
            // 
            // ReviewBox
            // 
            this.ReviewBox.FormattingEnabled = true;
            this.ReviewBox.Location = new System.Drawing.Point(470, 86);
            this.ReviewBox.Name = "ReviewBox";
            this.ReviewBox.Size = new System.Drawing.Size(192, 160);
            this.ReviewBox.TabIndex = 34;
            // 
            // RatingTrackBar
            // 
            this.RatingTrackBar.LargeChange = 1;
            this.RatingTrackBar.Location = new System.Drawing.Point(785, 150);
            this.RatingTrackBar.Maximum = 5;
            this.RatingTrackBar.Name = "RatingTrackBar";
            this.RatingTrackBar.Size = new System.Drawing.Size(104, 45);
            this.RatingTrackBar.TabIndex = 7;
            this.RatingTrackBar.Value = 3;
            this.RatingTrackBar.Scroll += new System.EventHandler(this.RatingTrackBar_Scroll);
            // 
            // Review_Submit
            // 
            this.Review_Submit.Location = new System.Drawing.Point(873, 252);
            this.Review_Submit.Margin = new System.Windows.Forms.Padding(2);
            this.Review_Submit.Name = "Review_Submit";
            this.Review_Submit.Size = new System.Drawing.Size(56, 19);
            this.Review_Submit.TabIndex = 36;
            this.Review_Submit.Text = "Submit";
            this.Review_Submit.UseVisualStyleBackColor = true;
            this.Review_Submit.Click += new System.EventHandler(this.Review_Submit_Click);
            // 
            // Recent
            // 
            this.Recent.AutoSize = true;
            this.Recent.Location = new System.Drawing.Point(500, 335);
            this.Recent.Margin = new System.Windows.Forms.Padding(2);
            this.Recent.Name = "Recent";
            this.Recent.Size = new System.Drawing.Size(87, 17);
            this.Recent.TabIndex = 37;
            this.Recent.Text = "Most Recent";
            this.Recent.UseVisualStyleBackColor = true;
            this.Recent.CheckedChanged += new System.EventHandler(this.Recent_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(468, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Filter:";
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.Location = new System.Drawing.Point(500, 294);
            this.HighScore.Margin = new System.Windows.Forms.Padding(2);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(117, 17);
            this.HighScore.TabIndex = 39;
            this.HighScore.Text = "HighToLow Scores";
            this.HighScore.UseVisualStyleBackColor = true;
            this.HighScore.CheckedChanged += new System.EventHandler(this.HighScore_CheckedChanged);
            // 
            // LowScore
            // 
            this.LowScore.AutoSize = true;
            this.LowScore.Location = new System.Drawing.Point(500, 314);
            this.LowScore.Margin = new System.Windows.Forms.Padding(2);
            this.LowScore.Name = "LowScore";
            this.LowScore.Size = new System.Drawing.Size(117, 17);
            this.LowScore.TabIndex = 40;
            this.LowScore.Text = "LowToHigh Scores";
            this.LowScore.UseVisualStyleBackColor = true;
            this.LowScore.CheckedChanged += new System.EventHandler(this.LowScore_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(944, 362);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Hours Played:";
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(1024, 362);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(38, 20);
            this.Hours.TabIndex = 42;
            this.Hours.Text = "3";
            // 
            // Hours_Played_Button
            // 
            this.Hours_Played_Button.Location = new System.Drawing.Point(1004, 397);
            this.Hours_Played_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Hours_Played_Button.Name = "Hours_Played_Button";
            this.Hours_Played_Button.Size = new System.Drawing.Size(56, 19);
            this.Hours_Played_Button.TabIndex = 43;
            this.Hours_Played_Button.Text = "Submit";
            this.Hours_Played_Button.UseVisualStyleBackColor = true;
            this.Hours_Played_Button.Click += new System.EventHandler(this.Hours_Played_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Reviews:";
            // 
            // FilterRelease
            // 
            this.FilterRelease.AutoSize = true;
            this.FilterRelease.Location = new System.Drawing.Point(341, 340);
            this.FilterRelease.Margin = new System.Windows.Forms.Padding(2);
            this.FilterRelease.Name = "FilterRelease";
            this.FilterRelease.Size = new System.Drawing.Size(109, 17);
            this.FilterRelease.TabIndex = 45;
            this.FilterRelease.Text = "Newest Releases";
            this.FilterRelease.UseVisualStyleBackColor = true;
            this.FilterRelease.CheckedChanged += new System.EventHandler(this.FilterRelease_CheckedChanged);
            // 
            // YourReview
            // 
            this.YourReview.AutoSize = true;
            this.YourReview.Location = new System.Drawing.Point(500, 355);
            this.YourReview.Margin = new System.Windows.Forms.Padding(2);
            this.YourReview.Name = "YourReview";
            this.YourReview.Size = new System.Drawing.Size(92, 17);
            this.YourReview.TabIndex = 46;
            this.YourReview.Text = "Your Reviews";
            this.YourReview.UseVisualStyleBackColor = true;
            this.YourReview.CheckedChanged += new System.EventHandler(this.YourReview_CheckedChanged);
            // 
            // Filter_Button
            // 
            this.Filter_Button.Location = new System.Drawing.Point(369, 363);
            this.Filter_Button.Name = "Filter_Button";
            this.Filter_Button.Size = new System.Drawing.Size(56, 23);
            this.Filter_Button.TabIndex = 48;
            this.Filter_Button.Text = "Search";
            this.Filter_Button.UseVisualStyleBackColor = true;
            this.Filter_Button.Click += new System.EventHandler(this.Filter_Button_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 549);
            this.Controls.Add(this.Filter_Button);
            this.Controls.Add(this.YourReview);
            this.Controls.Add(this.FilterRelease);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hours_Played_Button);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.LowScore);
            this.Controls.Add(this.HighScore);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Recent);
            this.Controls.Add(this.Review_Submit);
            this.Controls.Add(this.ReviewBox);
            this.Controls.Add(this.Name_Search);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.GameNameSearch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DeveloperList);
            this.Controls.Add(this.Low2High);
            this.Controls.Add(this.High2Low);
            this.Controls.Add(this.LessThanFive);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.Buy_Button);
            this.Controls.Add(this.LibraryBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Developer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReviewDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RatingScore);
            this.Controls.Add(this.RatingTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameDetails);
            this.Controls.Add(this.GameBox);
            this.Controls.Add(this.UserList);
            this.Name = "Client";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RatingTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserList;
        private System.Windows.Forms.ListBox GameBox;
        private System.Windows.Forms.Label GameDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RatingScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReviewDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Developer;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label ReleaseDate;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox LibraryBox;
        private System.Windows.Forms.Button Buy_Button;
        private System.Windows.Forms.ComboBox GenreBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox LessThanFive;
        private System.Windows.Forms.CheckBox High2Low;
        private System.Windows.Forms.CheckBox Low2High;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox DeveloperList;
        private System.Windows.Forms.TextBox GameNameSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Name_Search;
        private System.Windows.Forms.ListBox ReviewBox;
        private System.Windows.Forms.TrackBar RatingTrackBar;
        private System.Windows.Forms.Button Review_Submit;
        private System.Windows.Forms.CheckBox Recent;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox HighScore;
        private System.Windows.Forms.CheckBox LowScore;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Hours;
        private System.Windows.Forms.Button Hours_Played_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox FilterRelease;
        private System.Windows.Forms.CheckBox YourReview;
        private System.Windows.Forms.Button Filter_Button;
    }
}

