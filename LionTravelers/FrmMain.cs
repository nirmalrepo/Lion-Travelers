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
    public partial class Form1 : Form
    {
        private FrmTour _AddTour = new FrmTour();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsTour lcTour = ClsTour.newTour();
            if (lcTour != null && lcTour.viewEdit())
            {
                ClsSystem.TourList.Add(lcTour.Code, lcTour);
                updateDisplay();
                
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
                tour.SubItems.Add("$" + ClsTour.PricePerPassenger.ToString());
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
    }
}
