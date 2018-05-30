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
        private ClsTour _Tour;
        public FrmTour()
        {
            InitializeComponent();
        }

        public bool ShowDialog(ClsTour prTour)
        {
            _Tour = prTour;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }
        private void updateDisplay()
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

        private void btnAddTourCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTourCost_Click(object sender, EventArgs e)
        {
            ClsCost lcTourCost = ClsCost.NewCost(comboBoxCostType.SelectedIndex);

            if (lcTourCost != null && lcTourCost.ViewEdit())

            {

                ClsTour.TourCostList.Add(lcTourCost.ID, lcTourCost);

                UpdateCostListDisplay();

            }
        }
        private void UpdateCostListDisplay()
        {

            listViewTourCost.Items.Clear();

            //Populate the ListView Control with Dictionary items.
            List<ClsCost> tourCostDetails = ClsTour.TourCostList.Values.ToList<ClsCost>();

            foreach (var ClsCost in tourCostDetails)
            {
                ListViewItem cost = new ListViewItem();
                cost.Text = ClsCost.Name;
                cost.SubItems.Add(ClsCost.typeOfStudent());
                cost.SubItems.Add("$" + ClsCost.Cost.ToString());
                cost.Tag = ClsCost;

                listViewTourCost.Items.Add(cost);
            }
        }

        private void btnEditTourCost_Click(object sender, EventArgs e)
        {
            if (listViewTourCost.SelectedItems.Count <= 0)
            {

            }
            else
            {
                EditTourCostDetails();
            }
        }
        private void EditTourCostDetails()
        {
            ClsCost lcCost = (ClsCost)listViewTourCost.FocusedItem.Tag;
            if (lcCost != null && lcCost.ViewEdit())
            {
                UpdateCostListDisplay();
            }
        }
    }
}
