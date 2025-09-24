namespace SeulkiKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void headerControl1_Load(object sender, EventArgs e)
        {

        }

        private void productCard1_Clicked(object sender, SeulkiKiosk.Components.Products.IProductCard e)
        {
            MessageBox.Show($"{e.Title} {e.Price:0,000}원");
        }
    }
}
