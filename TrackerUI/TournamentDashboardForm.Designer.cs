namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            createTeamButton = new Button();
            selectTeamMemberLabel = new Label();
            roundDropDown = new ComboBox();
            createTeamLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // createTeamButton
            // 
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamButton.ForeColor = Color.FromArgb(64, 64, 64);
            createTeamButton.Location = new Point(236, 210);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(133, 39);
            createTeamButton.TabIndex = 32;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.ForeColor = Color.DimGray;
            selectTeamMemberLabel.Location = new Point(66, 121);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(188, 21);
            selectTeamMemberLabel.TabIndex = 31;
            selectTeamMemberLabel.Text = "Load Existing Tournament";
            // 
            // roundDropDown
            // 
            roundDropDown.DropDownHeight = 80;
            roundDropDown.FormattingEnabled = true;
            roundDropDown.IntegralHeight = false;
            roundDropDown.Location = new Point(66, 159);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(303, 23);
            roundDropDown.TabIndex = 30;
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = Color.DimGray;
            createTeamLabel.Location = new Point(51, 49);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(353, 45);
            createTeamLabel.TabIndex = 29;
            createTeamLabel.Text = "Tournament Dashboard";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(66, 210);
            button1.Name = "button1";
            button1.Size = new Size(155, 39);
            button1.TabIndex = 33;
            button1.Text = "Load Tournament";
            button1.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 324);
            Controls.Add(button1);
            Controls.Add(createTeamButton);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(roundDropDown);
            Controls.Add(createTeamLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createTeamButton;
        private Label selectTeamMemberLabel;
        private ComboBox roundDropDown;
        private Label createTeamLabel;
        private Button button1;
    }
}