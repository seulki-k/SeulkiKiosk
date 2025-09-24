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
    public partial class ProductList : UserControl
    {
        public ProductList()
        {
            InitializeComponent();

            Items.CollectionChanged += Items_CollectionChanged;
        }

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
                flpnl.Controls.Add(productCard);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<Product> Items { get; set; } = [];

    }
}
