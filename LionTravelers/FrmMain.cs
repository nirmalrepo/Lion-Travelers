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
            clsTour lcTour = clsTour.newTour();
            if (lcTour != null && lcTour.viewEdit())
            {
                clsSystem.TourList.Add(lcTour.Code, lcTour);
                updatedisplay();
                
            }
        }
        private void updatedisplay()
        {
            lstTours.DataSource = null;
            lstTours.DataSource = clsSystem.TourList.Values.ToList<clsTour>();
            //clsCompany.save();
        }
    }
}
