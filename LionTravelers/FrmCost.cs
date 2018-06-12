using System;
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
            if (_Cost.ID != null)
                txtID.Enabled = false;

            txtName.Text = _Cost.Name;

            lblAmountValue.Text = Convert.ToString(_Cost.Cost);

        }

        private void btnAddTourCostOk_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {

                pushData();

                DialogResult = DialogResult.OK;
            }

        }

        protected virtual bool IsValidForm()
        {
            if (txtID.Text == "" & txtName.Text == "")
            {
                ShowErrorMessage("Please provide all the required fields.", "Required Fields");
                return false;
            }
            else if (_Cost.TourCostList != null && _Cost.TourCostList.ContainsKey(txtID.Text))
            {
                ShowErrorMessage("Please provide another code.", "Code Already Exists");

                txtID.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }

        protected virtual void ShowErrorMessage(string detail, string title)
        {
            MessageBox.Show(detail, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        protected virtual void pushData()
        {
            _Cost.ID = txtID.Text;

            _Cost.Name = txtName.Text;

            _Cost.Cost = Convert.ToDecimal(lblAmountValue.Text);
        }

        protected virtual string CalculateTotalCostAmount(char costToCalculate)
        {
            return lblAmountValue.Text;
        }
    }
}
