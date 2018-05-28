using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LionTravelers
{
    public partial class FrmTour : Form
    {
        private clsTour _Tour;
        public FrmTour()
        {
            InitializeComponent();
        }

        public bool ShowDialog(clsTour prTour)
        {
            _Tour = prTour;
            UpdateDisplay();
            return ShowDialog() == DialogResult.OK;
        }
        private void UpdateDisplay()
        {
            txtCode.Text = _Tour.Code;
            txtName.Text = _Tour.Name;
            dateTimeStartDate.Value = _Tour.StartDate;
            dateTimeEndDate.Value = _Tour.EndDate;
            numericUpDownMaxPassengers.Value = _Tour.NoOfPassengers;
            numericUpDownDistance.Value = _Tour.Distance;
            numericUpDownMarkup.Value = _Tour.Markup;
            labelTotalCost.Text = Convert.ToString(_Tour.PricePerPassenger);
        }
        private void btnAddTourOk_Click(object sender, EventArgs e)
        {
            pushData();
            DialogResult = DialogResult.OK;
        }
        private void pushData()
        {
            _Tour.Code = txtCode.Text;
            _Tour.Name = txtName.Text;
            _Tour.StartDate = dateTimeStartDate.Value;
            _Tour.EndDate = dateTimeEndDate.Value;
            _Tour.NoOfPassengers = Convert.ToInt16(numericUpDownMaxPassengers.Value);
            _Tour.Distance = Convert.ToInt16(numericUpDownDistance.Value);
            _Tour.Markup = Convert.ToInt16(numericUpDownMarkup.Value);
            _Tour.PricePerPassenger = Convert.ToDecimal(labelTotalCost.Text);
        }
    }
}
