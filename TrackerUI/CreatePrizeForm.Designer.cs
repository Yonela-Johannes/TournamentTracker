namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            createTeamLabel = new Label();
            placeNumberInputValue = new TextBox();
            placeNumberLabel = new Label();
            createPrizeButton = new Button();
            placeNameInputValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountInputValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageInputValue = new TextBox();
            pricePercentageLabel = new Label();
            orLabel = new Label();
            SuspendLayout();
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = Color.DimGray;
            createTeamLabel.Location = new Point(47, 22);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(116, 25);
            createTeamLabel.TabIndex = 29;
            createTeamLabel.Text = "Create Team";
            // 
            // placeNumberInputValue
            // 
            placeNumberInputValue.Location = new Point(186, 83);
            placeNumberInputValue.Name = "placeNumberInputValue";
            placeNumberInputValue.Size = new Size(123, 23);
            placeNumberInputValue.TabIndex = 31;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNumberLabel.ForeColor = Color.DimGray;
            placeNumberLabel.Location = new Point(47, 83);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(108, 21);
            placeNumberLabel.TabIndex = 30;
            placeNumberLabel.Text = "Place Number";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = Color.FromArgb(64, 64, 64);
            createPrizeButton.Location = new Point(89, 320);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(179, 31);
            createPrizeButton.TabIndex = 32;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // placeNameInputValue
            // 
            placeNameInputValue.Location = new Point(186, 126);
            placeNameInputValue.Name = "placeNameInputValue";
            placeNameInputValue.Size = new Size(123, 23);
            placeNameInputValue.TabIndex = 34;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameLabel.ForeColor = Color.DimGray;
            placeNameLabel.Location = new Point(47, 126);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(92, 21);
            placeNameLabel.TabIndex = 33;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountInputValue
            // 
            prizeAmountInputValue.Location = new Point(186, 171);
            prizeAmountInputValue.Name = "prizeAmountInputValue";
            prizeAmountInputValue.Size = new Size(123, 23);
            prizeAmountInputValue.TabIndex = 36;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeAmountLabel.ForeColor = Color.DimGray;
            prizeAmountLabel.Location = new Point(47, 171);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(104, 21);
            prizeAmountLabel.TabIndex = 35;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageInputValue
            // 
            prizePercentageInputValue.Location = new Point(186, 247);
            prizePercentageInputValue.Name = "prizePercentageInputValue";
            prizePercentageInputValue.Size = new Size(123, 23);
            prizePercentageInputValue.TabIndex = 38;
            // 
            // pricePercentageLabel
            // 
            pricePercentageLabel.AutoSize = true;
            pricePercentageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pricePercentageLabel.ForeColor = Color.DimGray;
            pricePercentageLabel.Location = new Point(47, 247);
            pricePercentageLabel.Name = "pricePercentageLabel";
            pricePercentageLabel.Size = new Size(124, 21);
            pricePercentageLabel.TabIndex = 37;
            pricePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLabel.ForeColor = Color.Gray;
            orLabel.Location = new Point(147, 209);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(37, 21);
            orLabel.TabIndex = 39;
            orLabel.Text = "-or-";
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(386, 413);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageInputValue);
            Controls.Add(pricePercentageLabel);
            Controls.Add(prizeAmountInputValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameInputValue);
            Controls.Add(placeNameLabel);
            Controls.Add(createTeamLabel);
            Controls.Add(placeNumberInputValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTeamLabel;
        private TextBox placeNumberInputValue;
        private Label placeNumberLabel;
        private Button createPrizeButton;
        private TextBox placeNameInputValue;
        private Label placeNameLabel;
        private TextBox prizeAmountInputValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageInputValue;
        private Label pricePercentageLabel;
        private Label orLabel;
    }
}