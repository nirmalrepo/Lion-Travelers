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
    public partial class FrmCost : Form
    {
        protected ClsCost _Cost;
        protected ClsTour _Tour;
        public FrmCost()
        {
            InitializeComponent();
        }
        public DialogResult ShowDialog(ClsCost prCost)

        {

            _Cost = prCost;

            updateDisplay();

            return ShowDialog();

        }
        protected virtual void updateDisplay()

        {

            txtID.Text = _Cost.ID;

            txtName.Text = _Cost.Name;

            lblAmountValue.Text = Convert.ToString(_Cost.Cost);
        }

        private void btnAddTourCostOk_Click(object sender, EventArgs e)
        {
            pushData();

            DialogResult = DialogResult.OK;
        }

        protected virtual void pushData()
        {
            _Cost.ID = txtID.Text;

            _Cost.Name = txtName.Text;

            _Cost.Cost = Convert.ToDecimal(lblAmountValue.Text);
        }

        protected virtual string CalculateTotalCostAmount(char costToCalculate) {
            return lblAmountValue.Text; 
        }
    }
}
