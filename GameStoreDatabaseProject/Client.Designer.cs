﻿namespace GameStoreDatabaseProject
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
            this.label4 = new System.Windows.Forms.Label();
            this.RatingTrackBar = new System.Windows.Forms.TrackBar();
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
            ((System.ComponentModel.ISupportInitialize)(this.RatingTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(1366, 22);
            this.UserList.Margin = new System.Windows.Forms.Padding(4);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(160, 24);
            this.UserList.TabIndex = 0;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
            // 
            // GameBox
            // 
            this.GameBox.FormattingEnabled = true;
            this.GameBox.ItemHeight = 16;
            this.GameBox.Location = new System.Drawing.Point(16, 132);
            this.GameBox.Margin = new System.Windows.Forms.Padding(4);
            this.GameBox.Name = "GameBox";
            this.GameBox.Size = new System.Drawing.Size(278, 404);
            this.GameBox.TabIndex = 1;
            this.GameBox.SelectedIndexChanged += new System.EventHandler(this.GameBox_SelectedIndexChanged);
            // 
            // GameDetails
            // 
            this.GameDetails.AutoSize = true;
            this.GameDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDetails.Location = new System.Drawing.Point(312, 132);
            this.GameDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameDetails.Name = "GameDetails";
            this.GameDetails.Size = new System.Drawing.Size(110, 17);
            this.GameDetails.TabIndex = 2;
            this.GameDetails.Text = "Game Details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Developer: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Release Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Five Star Rating:";
            // 
            // RatingTrackBar
            // 
            this.RatingTrackBar.LargeChange = 10;
            this.RatingTrackBar.Location = new System.Drawing.Point(801, 240);
            this.RatingTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.RatingTrackBar.Maximum = 50;
            this.RatingTrackBar.Name = "RatingTrackBar";
            this.RatingTrackBar.Size = new System.Drawing.Size(139, 56);
            this.RatingTrackBar.TabIndex = 7;
            this.RatingTrackBar.Value = 25;
            this.RatingTrackBar.Scroll += new System.EventHandler(this.RatingTrackBar_Scroll);
            // 
            // RatingScore
            // 
            this.RatingScore.Location = new System.Drawing.Point(889, 208);
            this.RatingScore.Margin = new System.Windows.Forms.Padding(4);
            this.RatingScore.Name = "RatingScore";
            this.RatingScore.Size = new System.Drawing.Size(49, 22);
            this.RatingScore.TabIndex = 8;
            this.RatingScore.Text = "2.5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(775, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rating out of 5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(779, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Create Review";
            // 
            // ReviewDescription
            // 
            this.ReviewDescription.Location = new System.Drawing.Point(776, 311);
            this.ReviewDescription.Margin = new System.Windows.Forms.Padding(4);
            this.ReviewDescription.Multiline = true;
            this.ReviewDescription.Name = "ReviewDescription";
            this.ReviewDescription.Size = new System.Drawing.Size(225, 24);
            this.ReviewDescription.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Genre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Store";
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Location = new System.Drawing.Point(400, 172);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(71, 17);
            this.Developer.TabIndex = 14;
            this.Developer.Text = "developer";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(375, 208);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(45, 17);
            this.Genre.TabIndex = 15;
            this.Genre.Text = "genre";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Location = new System.Drawing.Point(414, 244);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(36, 17);
            this.ReleaseDate.TabIndex = 16;
            this.ReleaseDate.Text = "date";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(371, 282);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(39, 17);
            this.Price.TabIndex = 17;
            this.Price.Text = "price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1291, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "User: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1289, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Library";
            // 
            // LibraryBox
            // 
            this.LibraryBox.FormattingEnabled = true;
            this.LibraryBox.ItemHeight = 16;
            this.LibraryBox.Location = new System.Drawing.Point(1248, 132);
            this.LibraryBox.Margin = new System.Windows.Forms.Padding(4);
            this.LibraryBox.Name = "LibraryBox";
            this.LibraryBox.Size = new System.Drawing.Size(278, 404);
            this.LibraryBox.TabIndex = 20;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 753);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameDetails);
            this.Controls.Add(this.GameBox);
            this.Controls.Add(this.UserList);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar RatingTrackBar;
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
    }
}

