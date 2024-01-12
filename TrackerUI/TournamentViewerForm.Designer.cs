namespace TrackerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            label1 = new Label();
            label2 = new Label();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoName = new Label();
            teamTwoScoreLabel = new Label();
            teamTwoScoreValue = new TextBox();
            versusLabel = new Label();
            scoreButton = new Button();
            label3 = new Label();
            roundDropDown = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Tournament:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(157, 29);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "<none>";
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckbox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unplayedOnlyCheckbox.ForeColor = Color.DimGray;
            unplayedOnlyCheckbox.Location = new Point(94, 127);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(109, 21);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 25;
            matchupListBox.Location = new Point(29, 164);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(198, 179);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneName.ForeColor = Color.DimGray;
            teamOneName.Location = new Point(278, 164);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(97, 21);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneScoreLabel.ForeColor = Color.DimGray;
            teamOneScoreLabel.Location = new Point(278, 197);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(49, 21);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(333, 191);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(100, 33);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamTwoName.ForeColor = Color.DimGray;
            teamTwoName.Location = new Point(278, 271);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(97, 21);
            teamTwoName.TabIndex = 6;
            teamTwoName.Text = "<team two>";
            teamTwoName.Click += label4_Click;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamTwoScoreLabel.ForeColor = Color.DimGray;
            teamTwoScoreLabel.Location = new Point(278, 304);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(49, 21);
            teamTwoScoreLabel.TabIndex = 7;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(333, 298);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(100, 33);
            teamTwoScoreValue.TabIndex = 8;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            versusLabel.ForeColor = Color.DimGray;
            versusLabel.Location = new Point(333, 239);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(33, 17);
            versusLabel.TabIndex = 6;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = SystemColors.ControlDarkDark;
            scoreButton.Location = new Point(461, 233);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(75, 38);
            scoreButton.TabIndex = 9;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(29, 88);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "Round:";
            // 
            // roundDropDown
            // 
            roundDropDown.DropDownHeight = 80;
            roundDropDown.FormattingEnabled = true;
            roundDropDown.IntegralHeight = false;
            roundDropDown.Location = new Point(94, 88);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(133, 33);
            roundDropDown.TabIndex = 3;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(639, 424);
            Controls.Add(scoreButton);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(versusLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "TournamentViewerForm";
            Text = "TournamentViewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private Label teamTwoName;
        private Label teamTwoScoreLabel;
        private TextBox teamTwoScoreValue;
        private Label versusLabel;
        private Button scoreButton;
        private Label label3;
        private ComboBox roundDropDown;
    }
}
