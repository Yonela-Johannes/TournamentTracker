namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            tournamentPlayerListBox = new ListBox();
            selectTeamMemberLabel = new Label();
            addTeamButton = new Button();
            teamDropDown = new ComboBox();
            tournamentNameValue = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            entryFeeInput = new TextBox();
            firstNameLabel = new Label();
            createPrizeButton = new Button();
            deleteTournamentPlayer = new Button();
            deleteTournamentPrizeButton = new Button();
            prizesListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tournamentPlayerListBox
            // 
            tournamentPlayerListBox.FormattingEnabled = true;
            tournamentPlayerListBox.ItemHeight = 15;
            tournamentPlayerListBox.Location = new Point(346, 83);
            tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            tournamentPlayerListBox.Size = new Size(272, 109);
            tournamentPlayerListBox.TabIndex = 34;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.ForeColor = Color.DimGray;
            selectTeamMemberLabel.Location = new Point(23, 177);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(91, 21);
            selectTeamMemberLabel.TabIndex = 33;
            selectTeamMemberLabel.Text = "Select Team";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTeamButton.ForeColor = SystemColors.ControlDarkDark;
            addTeamButton.Location = new Point(23, 252);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(123, 31);
            addTeamButton.TabIndex = 32;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // teamDropDown
            // 
            teamDropDown.DropDownHeight = 80;
            teamDropDown.FormattingEnabled = true;
            teamDropDown.IntegralHeight = false;
            teamDropDown.Location = new Point(23, 201);
            teamDropDown.Name = "teamDropDown";
            teamDropDown.Size = new Size(272, 23);
            teamDropDown.TabIndex = 31;
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(23, 83);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(272, 23);
            tournamentNameValue.TabIndex = 30;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamNameLabel.ForeColor = Color.DimGray;
            teamNameLabel.Location = new Point(23, 59);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(139, 21);
            teamNameLabel.TabIndex = 29;
            teamNameLabel.Text = "Tournament Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = Color.DimGray;
            createTeamLabel.Location = new Point(23, 23);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(173, 25);
            createTeamLabel.TabIndex = 28;
            createTeamLabel.Text = "Create Tournament";
            // 
            // entryFeeInput
            // 
            entryFeeInput.Location = new Point(171, 131);
            entryFeeInput.Name = "entryFeeInput";
            entryFeeInput.Size = new Size(123, 23);
            entryFeeInput.TabIndex = 36;
            entryFeeInput.Text = "0";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = Color.DimGray;
            firstNameLabel.Location = new Point(23, 133);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(74, 21);
            firstNameLabel.TabIndex = 35;
            firstNameLabel.Text = "Entry Fee";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = SystemColors.ControlDarkDark;
            createPrizeButton.Location = new Point(172, 252);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(123, 31);
            createPrizeButton.TabIndex = 37;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // deleteTournamentPlayer
            // 
            deleteTournamentPlayer.FlatStyle = FlatStyle.Flat;
            deleteTournamentPlayer.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteTournamentPlayer.ForeColor = SystemColors.ControlDarkDark;
            deleteTournamentPlayer.Location = new Point(495, 201);
            deleteTournamentPlayer.Name = "deleteTournamentPlayer";
            deleteTournamentPlayer.Size = new Size(123, 31);
            deleteTournamentPlayer.TabIndex = 38;
            deleteTournamentPlayer.Text = "Delete";
            deleteTournamentPlayer.UseVisualStyleBackColor = true;
            // 
            // deleteTournamentPrizeButton
            // 
            deleteTournamentPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteTournamentPrizeButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteTournamentPrizeButton.ForeColor = SystemColors.ControlDarkDark;
            deleteTournamentPrizeButton.Location = new Point(495, 370);
            deleteTournamentPrizeButton.Name = "deleteTournamentPrizeButton";
            deleteTournamentPrizeButton.Size = new Size(123, 31);
            deleteTournamentPrizeButton.TabIndex = 40;
            deleteTournamentPrizeButton.Text = "Delete";
            deleteTournamentPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 15;
            prizesListBox.Location = new Point(346, 252);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(272, 109);
            prizesListBox.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(346, 228);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 41;
            label1.Text = "Teams / Player";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(346, 59);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 42;
            label2.Text = "Teams / Player";
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteTournamentPrizeButton);
            Controls.Add(prizesListBox);
            Controls.Add(deleteTournamentPlayer);
            Controls.Add(createPrizeButton);
            Controls.Add(tournamentPlayerListBox);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(addTeamButton);
            Controls.Add(teamDropDown);
            Controls.Add(tournamentNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Controls.Add(entryFeeInput);
            Controls.Add(firstNameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox tournamentPlayerListBox;
        private Label selectTeamMemberLabel;
        private Button addTeamButton;
        private ComboBox teamDropDown;
        private TextBox tournamentNameValue;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private TextBox entryFeeInput;
        private Label firstNameLabel;
        private Button createPrizeButton;
        private Button deleteTournamentPlayer;
        private Button deleteTournamentPrizeButton;
        private ListBox prizesListBox;
        private Label label1;
        private Label label2;
    }
}