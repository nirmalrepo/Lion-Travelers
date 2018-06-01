using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LionTravelers
{
    public partial class FrmTour : Form
    {
        private const string VEHICLE = "Vehicle";
        private const string STAFF = "Staff";
        private const string STAFF_TYPE_DRIVER = "Driver";
        private ClsTour _Tour;
        private ClsTour _InitialTour;
        private ColumnHeader SortingColumn = null;
        public FrmTour()
        {
            InitializeComponent();
        }

        public bool ShowDialog(ClsTour prTour)
        {
            _Tour = prTour;    
            _InitialTour = prTour;
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
            lblTourPrice.Text = Convert.ToString(_Tour.PricePerPassenger);
            comboBoxCostType.Text = VEHICLE;
            UpdateCostListDisplayAndCostTotal();
        }


        private void btnAddTourOk_Click(object sender, EventArgs e)
        {
           
            if (IsValidForm())
            {
                pushData();
                DialogResult = DialogResult.OK;
            }
            
           

        }

        private bool IsValidForm()
        {
            if (txtCode.Text == "" & txtName.Text == "")
            {
                ShowErrorMessage("Please provide all the required fields.", "Required Fields");
                return false;
            }else if (ClsSystem.TourList.ContainsKey(txtCode.Text))
            {
                ShowErrorMessage("Please provide another code.", "Code Already Exists");
                txtCode.Clear();
                return false;
            }
            else if (listViewTourCost.Items.Count == 0)
            {

                ShowErrorMessage("Please add a tour cost.", "No Tour Costs Found.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ShowErrorMessage(string detail, string title)
        {
            MessageBox.Show(detail, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _Tour.PricePerPassenger = Convert.ToDecimal(lblTourPrice.Text.Remove(0,1));
        }

        private void btnAddTourCancel_Click(object sender, EventArgs e)
        {
           _Tour = _InitialTour;
            this.Close();
        }

        private void btnAddTourCost_Click(object sender, EventArgs e)
        {
            var TourData = getTourDataForCostAmountCalculation();
            ClsCost lcTourCost = ClsCost.NewCost(comboBoxCostType.SelectedIndex, TourData);
            if (lcTourCost != null && lcTourCost.ViewEdit())
            {
                _Tour.TourCostList.Add(lcTourCost.ID, lcTourCost);
                UpdateCostListDisplayAndCostTotal();
                CalculatePricePerPassenger();
            }
        }
        private Dictionary<string, string> getTourDataForCostAmountCalculation()
        {
            var TourData = new Dictionary<string, string>();
            var Duration = dateTimeEndDate.Value.Subtract(dateTimeStartDate.Value).Days.ToString();
            var NoOfDays = (Duration == "0") ? "1" : Duration;
            TourData.Add("distance", Convert.ToString(numericUpDownDistance.Value));
            TourData.Add("noOfDays", NoOfDays);
            return TourData;
        }
        private void UpdateCostListDisplayAndCostTotal()
        {
            decimal TotalCost = 0;
            listViewTourCost.Items.Clear();
            List<ClsCost> tourCostDetails = _Tour.TourCostList.Values.ToList<ClsCost>();
            foreach (var ClsCost in tourCostDetails)
            {
                ListViewItem cost = new ListViewItem();
                cost.Text = ClsCost.Name;
                cost.SubItems.Add(ClsCost.typeOfCost());
                cost.SubItems.Add("$" + ClsCost.Cost.ToString());
                cost.Tag = ClsCost;
                listViewTourCost.Items.Add(cost);
                TotalCost += ClsCost.Cost;
                Console.WriteLine("Items {0}", ClsCost.ID);
            }
            lblTotalCost.Text = Convert.ToString(TotalCost);
        }

        private void CalculatePricePerPassenger()
        {
            if (listViewTourCost.Items.Count > 0)
            {
                var MaximumNoOFPeople = numericUpDownMaxPassengers.Value;
                var TotalCost = Convert.ToDecimal(lblTotalCost.Text);
                var MarkUp = numericUpDownMarkup.Value;
                var PricePerPassengerWithoutMarkUp = (TotalCost / MaximumNoOFPeople);
                var PricePerPassenger = PricePerPassengerWithoutMarkUp + (PricePerPassengerWithoutMarkUp * (MarkUp / 100));
                lblTourPrice.Text = "$" + Convert.ToString(PricePerPassenger);
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
                UpdateCostListDisplayAndCostTotal();
                CalculatePricePerPassenger();
            }
        }

        private void numericUpDownMaxPassengers_ValueChanged(object sender, EventArgs e)
        {
           
            CalculatePricePerPassenger();

        }

        private void numericUpDownMarkup_ValueChanged(object sender, EventArgs e)
        {
           
            CalculatePricePerPassenger();
        }

        private void numericUpDownDistance_ValueChanged(object sender, EventArgs e)
        {
           ReUpdatingTourVehicleCostList();
            CalculatePricePerPassenger();
        }

        private void ReUpdatingTourVehicleCostList()
        {
            if (listViewTourCost.Items.Count > 0)
            {
                decimal TotalCost = 0;
                List<ClsCost> tourCostOldDetails = _Tour.TourCostList.Values.ToList<ClsCost>();
                foreach (ListViewItem item in listViewTourCost.Items)
                {
                    if (VEHICLE == item.SubItems[1].Text)
                    {
                        var NewDistance = numericUpDownDistance.Value;
                        ClsVehicleCost lcCost = (ClsVehicleCost)item.Tag;
                        item.SubItems[2].Text = "$" + Convert.ToString(NewDistance * lcCost.KmCharge);
                        lcCost.Distance = Convert.ToDecimal(NewDistance);
                    }
                    TotalCost += Convert.ToDecimal(item.SubItems[2].Text.Remove(0, 1));
                }
                lblTotalCost.Text = Convert.ToString(TotalCost);
            }
               
        }

        private void ReUpdatingTourStaffCostList()
        {
            if (listViewTourCost.Items.Count > 0)
            {
                List<ClsCost> tourCostOldDetails = _Tour.TourCostList.Values.ToList<ClsCost>();
                decimal TotalCost = 0;
                foreach (ListViewItem item in listViewTourCost.Items)
                {
                    if (STAFF == item.SubItems[1].Text)
                    {
                        ClsStaffCost lcCost = (ClsStaffCost)item.Tag;
                        var NewDuration = (dateTimeEndDate.Value.Subtract(dateTimeStartDate.Value).Days.ToString());
                        var NewNoOfDays = (NewDuration == "0") ? Convert.ToDecimal(1) : Convert.ToDecimal(NewDuration);
                        var BasePriceAccordingToStaffType = (lcCost.StaffType == STAFF_TYPE_DRIVER) ? Convert.ToDecimal(200) : Convert.ToDecimal(100);
                        item.SubItems[2].Text = "$" + (NewNoOfDays * BasePriceAccordingToStaffType);
                        lcCost.NoOfDays = NewNoOfDays;
                    }
                    TotalCost += Convert.ToDecimal(item.SubItems[2].Text.Remove(0,1));
                }
                lblTotalCost.Text = Convert.ToString(TotalCost);
            }

        }

        

        private void dateTimeStartDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimeEndDate.MinDate = dateTimeStartDate.Value;
        }

        private void dateTimeEndDate_ValueChanged(object sender, EventArgs e)
        {
            ReUpdatingTourStaffCostList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteTourCost_Click(object sender, EventArgs e)
        {
            ClsCost lcCost = (ClsCost)listViewTourCost.FocusedItem.Tag;
            if (lcCost != null)
            {
                DialogResult result = MessageBox.Show("Are you sure to Delete ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _Tour.TourCostList.Remove(lcCost.ID);
                    UpdateCostListDisplayAndCostTotal();
                    CalculatePricePerPassenger();
                }
            }
        }

        private void FrmTour_Load(object sender, EventArgs e)
        {

        }

        private void listViewTourCost_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = listViewTourCost.Columns[e.Column];

            // Figure out the new sorting order.
            SortOrder sort_order;
            if (SortingColumn == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn.Text.StartsWith("▼ "))
                    {
                        sort_order = SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // New column. Sort ascending.
                    sort_order = SortOrder.Ascending;
                }

                // Remove the old sort indicator.
                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn.Text = "▼ " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "▲ " + SortingColumn.Text;
            }

            // Create a comparer.
            listViewTourCost.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            listViewTourCost.Sort();
        }
    }
}
