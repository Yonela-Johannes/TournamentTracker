namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            addTeamMemberButton = new Button();
            roundDropDown = new ComboBox();
            teamOneScoreValue = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            selectTeamMemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            firstNameInput = new TextBox();
            firstNameLabel = new Label();
            lastNameInput = new TextBox();
            lastNameLabel = new Label();
            emailInput = new TextBox();
            emailLabel = new Label();
            cellphoneInput = new TextBox();
            cellphoneLabel = new Label();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteTeamMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addTeamMemberButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTeamMemberButton.ForeColor = SystemColors.ControlDarkDark;
            addTeamMemberButton.Location = new Point(158, 203);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(123, 31);
            addTeamMemberButton.TabIndex = 23;
            addTeamMemberButton.Text = "Add Member";
            addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // roundDropDown
            // 
            roundDropDown.DropDownHeight = 80;
            roundDropDown.FormattingEnabled = true;
            roundDropDown.IntegralHeight = false;
            roundDropDown.Location = new Point(26, 163);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(272, 23);
            roundDropDown.TabIndex = 22;
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(26, 97);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(272, 23);
            teamOneScoreValue.TabIndex = 21;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamNameLabel.ForeColor = Color.DimGray;
            teamNameLabel.Location = new Point(26, 73);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(92, 21);
            teamNameLabel.TabIndex = 20;
            teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = Color.DimGray;
            createTeamLabel.Location = new Point(26, 29);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(116, 25);
            createTeamLabel.TabIndex = 19;
            createTeamLabel.Text = "Create Team";
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.ForeColor = Color.DimGray;
            selectTeamMemberLabel.Location = new Point(26, 139);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(154, 21);
            selectTeamMemberLabel.TabIndex = 24;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneInput);
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(emailInput);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameInput);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameInput);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Location = new Point(26, 251);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(272, 275);
            addNewMemberGroupBox.TabIndex = 25;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(131, 43);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(123, 23);
            firstNameInput.TabIndex = 27;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = Color.DimGray;
            firstNameLabel.Location = new Point(16, 43);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(86, 21);
            firstNameLabel.TabIndex = 26;
            firstNameLabel.Text = "First Name";
            firstNameLabel.Click += teamOneScoreLabel_Click;
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(131, 85);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(123, 23);
            lastNameInput.TabIndex = 29;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.DimGray;
            lastNameLabel.Location = new Point(16, 85);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(84, 21);
            lastNameLabel.TabIndex = 28;
            lastNameLabel.Text = "Last Name";
            // 
            // emailInput
            // 
            emailInput.Location = new Point(132, 126);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(123, 23);
            emailInput.TabIndex = 31;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.DimGray;
            emailLabel.Location = new Point(17, 126);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(48, 21);
            emailLabel.TabIndex = 30;
            emailLabel.Text = "Email";
            // 
            // cellphoneInput
            // 
            cellphoneInput.Location = new Point(132, 165);
            cellphoneInput.Name = "cellphoneInput";
            cellphoneInput.Size = new Size(123, 23);
            cellphoneInput.TabIndex = 33;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellphoneLabel.ForeColor = Color.DimGray;
            cellphoneLabel.Location = new Point(17, 165);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(80, 21);
            cellphoneLabel.TabIndex = 32;
            cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMemberButton.ForeColor = SystemColors.ControlDarkDark;
            createMemberButton.Location = new Point(131, 218);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(124, 31);
            createMemberButton.TabIndex = 26;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 15;
            teamMembersListBox.Location = new Point(358, 97);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(272, 379);
            teamMembersListBox.TabIndex = 26;
            // 
            // deleteTeamMemberButton
            // 
            deleteTeamMemberButton.FlatStyle = FlatStyle.Flat;
            deleteTeamMemberButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteTeamMemberButton.ForeColor = SystemColors.ControlDarkDark;
            deleteTeamMemberButton.Location = new Point(507, 495);
            deleteTeamMemberButton.Name = "deleteTeamMemberButton";
            deleteTeamMemberButton.Size = new Size(123, 31);
            deleteTeamMemberButton.TabIndex = 27;
            deleteTeamMemberButton.Text = "Delete Member";
            deleteTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamButton.ForeColor = Color.FromArgb(64, 64, 64);
            createTeamButton.Location = new Point(230, 545);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(179, 31);
            createTeamButton.TabIndex = 28;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(683, 598);
            Controls.Add(createTeamButton);
            Controls.Add(deleteTeamMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(addTeamMemberButton);
            Controls.Add(roundDropDown);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTeamForm";
            Text = " ";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addTeamMemberButton;
        private ComboBox roundDropDown;
        private TextBox teamOneScoreValue;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox firstNameInput;
        private Label firstNameLabel;
        private Button createMemberButton;
        private TextBox cellphoneInput;
        private Label cellphoneLabel;
        private TextBox emailInput;
        private Label emailLabel;
        private TextBox lastNameInput;
        private Label lastNameLabel;
        private ListBox teamMembersListBox;
        private Button deleteTeamMemberButton;
        private Button createTeamButton;
    }
}