namespace TournamentViewer
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TournamentLabel = new Label();
            TournamentNameLabel = new Label();
            RoundLabel = new Label();
            RoundDropDown = new ComboBox();
            UnplayedOnlyCheckBox = new CheckBox();
            MatchUpListBox = new ListBox();
            TeamOneLabel = new Label();
            ScoreOneLabel = new Label();
            ScoreOneTextBox = new TextBox();
            ScoreTwoTextBox = new TextBox();
            ScoreTwoLabel = new Label();
            TeamTwoLabel = new Label();
            VSLabel = new Label();
            ScoreButton = new Button();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // TournamentLabel
            // 
            TournamentLabel.AutoSize = true;
            TournamentLabel.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TournamentLabel.Location = new Point(28, 46);
            TournamentLabel.Name = "TournamentLabel";
            TournamentLabel.Size = new Size(213, 42);
            TournamentLabel.TabIndex = 0;
            TournamentLabel.Text = "Tournament :";
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Calibri", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentNameLabel.Location = new Point(245, 51);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(102, 36);
            TournamentNameLabel.TabIndex = 1;
            TournamentNameLabel.Text = "<none>";
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            RoundLabel.Location = new Point(45, 115);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(118, 39);
            RoundLabel.TabIndex = 2;
            RoundLabel.Text = "Round :";
            // 
            // RoundDropDown
            // 
            RoundDropDown.Cursor = Cursors.Hand;
            RoundDropDown.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            RoundDropDown.FormattingEnabled = true;
            RoundDropDown.Location = new Point(166, 112);
            RoundDropDown.Margin = new Padding(0);
            RoundDropDown.Name = "RoundDropDown";
            RoundDropDown.Size = new Size(147, 45);
            RoundDropDown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckBox
            // 
            UnplayedOnlyCheckBox.AutoSize = true;
            UnplayedOnlyCheckBox.Cursor = Cursors.Hand;
            UnplayedOnlyCheckBox.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            UnplayedOnlyCheckBox.Location = new Point(89, 181);
            UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            UnplayedOnlyCheckBox.Size = new Size(192, 37);
            UnplayedOnlyCheckBox.TabIndex = 4;
            UnplayedOnlyCheckBox.Text = "Unplayed Only";
            UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchUpListBox
            // 
            MatchUpListBox.Cursor = Cursors.No;
            MatchUpListBox.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            MatchUpListBox.FormattingEnabled = true;
            MatchUpListBox.ItemHeight = 26;
            MatchUpListBox.Location = new Point(28, 248);
            MatchUpListBox.Name = "MatchUpListBox";
            MatchUpListBox.Size = new Size(325, 316);
            MatchUpListBox.TabIndex = 5;
            // 
            // TeamOneLabel
            // 
            TeamOneLabel.AutoSize = true;
            TeamOneLabel.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TeamOneLabel.Location = new Point(435, 276);
            TeamOneLabel.Name = "TeamOneLabel";
            TeamOneLabel.Size = new Size(151, 33);
            TeamOneLabel.TabIndex = 6;
            TeamOneLabel.Text = "<Team One>";
            // 
            // ScoreOneLabel
            // 
            ScoreOneLabel.AutoSize = true;
            ScoreOneLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ScoreOneLabel.Location = new Point(435, 322);
            ScoreOneLabel.Name = "ScoreOneLabel";
            ScoreOneLabel.Size = new Size(68, 29);
            ScoreOneLabel.TabIndex = 7;
            ScoreOneLabel.Text = "Score";
            // 
            // ScoreOneTextBox
            // 
            ScoreOneTextBox.BorderStyle = BorderStyle.FixedSingle;
            ScoreOneTextBox.Cursor = Cursors.IBeam;
            ScoreOneTextBox.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreOneTextBox.Location = new Point(509, 322);
            ScoreOneTextBox.Name = "ScoreOneTextBox";
            ScoreOneTextBox.Size = new Size(100, 33);
            ScoreOneTextBox.TabIndex = 8;
            // 
            // ScoreTwoTextBox
            // 
            ScoreTwoTextBox.BorderStyle = BorderStyle.FixedSingle;
            ScoreTwoTextBox.Cursor = Cursors.IBeam;
            ScoreTwoTextBox.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreTwoTextBox.Location = new Point(509, 492);
            ScoreTwoTextBox.Name = "ScoreTwoTextBox";
            ScoreTwoTextBox.Size = new Size(100, 33);
            ScoreTwoTextBox.TabIndex = 11;
            // 
            // ScoreTwoLabel
            // 
            ScoreTwoLabel.AutoSize = true;
            ScoreTwoLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ScoreTwoLabel.Location = new Point(435, 492);
            ScoreTwoLabel.Name = "ScoreTwoLabel";
            ScoreTwoLabel.Size = new Size(68, 29);
            ScoreTwoLabel.TabIndex = 10;
            ScoreTwoLabel.Text = "Score";
            // 
            // TeamTwoLabel
            // 
            TeamTwoLabel.AutoSize = true;
            TeamTwoLabel.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TeamTwoLabel.Location = new Point(435, 446);
            TeamTwoLabel.Name = "TeamTwoLabel";
            TeamTwoLabel.Size = new Size(151, 33);
            TeamTwoLabel.TabIndex = 9;
            TeamTwoLabel.Text = "<Team Two>";
            // 
            // VSLabel
            // 
            VSLabel.AutoSize = true;
            VSLabel.Font = new Font("Calibri", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            VSLabel.Location = new Point(481, 384);
            VSLabel.Name = "VSLabel";
            VSLabel.Size = new Size(91, 39);
            VSLabel.TabIndex = 12;
            VSLabel.Text = "--VS--";
            // 
            // ScoreButton
            // 
            ScoreButton.Cursor = Cursors.Hand;
            ScoreButton.FlatAppearance.BorderColor = Color.Silver;
            ScoreButton.FlatAppearance.BorderSize = 2;
            ScoreButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            ScoreButton.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            ScoreButton.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ScoreButton.Location = new Point(607, 384);
            ScoreButton.Name = "ScoreButton";
            ScoreButton.Size = new Size(137, 67);
            ScoreButton.TabIndex = 13;
            ScoreButton.Text = "Submit Score";
            ScoreButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.Cursor = Cursors.Hand;
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.BorderSize = 2;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            CreateTournamentButton.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTournamentButton.Location = new Point(435, 62);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(263, 95);
            CreateTournamentButton.TabIndex = 14;
            CreateTournamentButton.Text = "Create New Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(783, 601);
            Controls.Add(CreateTournamentButton);
            Controls.Add(ScoreButton);
            Controls.Add(VSLabel);
            Controls.Add(ScoreTwoTextBox);
            Controls.Add(ScoreTwoLabel);
            Controls.Add(TeamTwoLabel);
            Controls.Add(ScoreOneTextBox);
            Controls.Add(ScoreOneLabel);
            Controls.Add(TeamOneLabel);
            Controls.Add(MatchUpListBox);
            Controls.Add(UnplayedOnlyCheckBox);
            Controls.Add(RoundDropDown);
            Controls.Add(RoundLabel);
            Controls.Add(TournamentNameLabel);
            Controls.Add(TournamentLabel);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "TournamentViewerForm";
            Text = "s";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentLabel;
        private Label TournamentNameLabel;
        private Label RoundLabel;
        private ComboBox RoundDropDown;
        private CheckBox UnplayedOnlyCheckBox;
        private ListBox MatchUpListBox;
        private Label TeamOneLabel;
        private Label ScoreOneLabel;
        private TextBox ScoreOneTextBox;
        private TextBox ScoreTwoTextBox;
        private Label ScoreTwoLabel;
        private Label TeamTwoLabel;
        private Label VSLabel;
        private Button ScoreButton;
        private Button CreateTournamentButton;
    }
}