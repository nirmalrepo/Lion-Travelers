using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LionTravelers
{
    public partial class FrmMain : Form
    {
        private ColumnHeader SortingColumn = null;
        private FrmTour _AddTour = new FrmTour();
        public FrmMain()
        {
            InitializeComponent();
            try
            {
                ClsSystem.Retrieve();
                updateDisplay();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void updateDisplay()
        {
            
            listViewTourList.Items.Clear();

            //Populate the ListView Control with Dictionary items.
            List<ClsTour> tourDetails = ClsSystem.TourList.Values.ToList<ClsTour>();

            foreach (var ClsTour in tourDetails)
            {
                ListViewItem tour = new ListViewItem();
                tour.Text = ClsTour.Name;
                tour.SubItems.Add(ClsTour.StartDate.ToString("dd/MM/yyyy"));
                tour.SubItems.Add("$" + ClsTour.PricePerPassenger);
                tour.Tag = ClsTour;

                listViewTourList.Items.Add(tour);
            }

            //Set Column width to fit data
            foreach (ColumnHeader col in listViewTourList.Columns)
                col.Width = -2;
        }

        private void btnEditTour_Click(object sender, EventArgs e)
        {
            
            if (listViewTourList.SelectedItems.Count <= 0)
            {

            }
            else {
                editTourDetails();
            }
        }

        private void editTourDetails()
        {
            ClsTour lcTour = (ClsTour)listViewTourList.FocusedItem.Tag;
            if (lcTour != null && lcTour.viewEdit())
            {
                updateDisplay();  
            }
        }

        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            ClsTour lcTour = (ClsTour)listViewTourList.FocusedItem.Tag;
            if (lcTour != null)
            {
                DialogResult result = MessageBox.Show("Are you sure to Delete ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ClsSystem.TourList.Remove(lcTour.Code);
                    updateDisplay();
                }
            }
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            ClsTour lcTour = ClsTour.newTour();
            if (lcTour != null && lcTour.viewEdit())
            {
                ClsSystem.TourList.Add(lcTour.Code, lcTour);
                updateDisplay();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClsSystem.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listViewTourList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = listViewTourList.Columns[e.Column];

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
            listViewTourList.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            listViewTourList.Sort();
        }

    }
}
