﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e, PrizeModel prizeModel)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel();
                model.PlaceName = placeNameInputValue.Text;
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberInputValue.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameInputValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountInputValue.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(prizePercentageInputValue.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
