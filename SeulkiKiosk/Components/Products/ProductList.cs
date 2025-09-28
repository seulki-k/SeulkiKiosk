using SeulkiKiosk.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeulkiKiosk.Components.Products
{
    [DefaultEvent("ItemClicked")]
    public partial class ProductList : UserControl
    {
        public event EventHandler<Product>? ItemClicked;
        public ProductList()
        {
            InitializeComponent();

            Items.CollectionChanged += Items_CollectionChanged;
        }
        public int BorderWidth { get => roundedPanel1.BorderWidth; set => roundedPanel1.BorderWidth = value; }
        public Color BorderColor { get => roundedPanel1.BorderColor; set => roundedPanel1.BorderColor = value; }
        private void Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            flpnl.Controls.Clear();
            foreach (var item in Items)
            {
                var productCard = new ProductCard
                {
                    ID = item.ID,
                    Price = item.Price,
                    Title = item.Title,
                    Image = item.Image!,
                };
                productCard.Clicked += ProductCard_Clicked;
                flpnl.Controls.Add(productCard);
            }
        }

        private void ProductCard_Clicked(object? sender, IProductCard e)
        {
            ItemClicked?.Invoke(this, e.ToProduct());
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<Product> Items { get; set; } = [];

    }
}
