using SeulkiKiosk.Components.Picks;
using SeulkiKiosk.Dialogs;

namespace SeulkiKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void productList1_ItemClicked(object sender, SeulkiKiosk.Models.Product e)
        {
            pickList.AddItem(e);
        }

        private void pickList_Load(object sender, EventArgs e)
        {

        }

        private void pickList_ItemValueChanged(List<PickItem> pickItems)
        {
            int totalCount = pickItems.Sum(item => item.Count);
            decimal totalPrice = pickItems.Sum(item => item.Count * item.DefaultPrice);
            orderSummaryControl1.Count = totalCount;
            orderSummaryControl1.TotalPrice = (int)totalPrice;
        }

        private void orderSummaryControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogBox.ShowReceipDialog(this, pickList.GetItems());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pickList.Clear();
        }
    }
}
