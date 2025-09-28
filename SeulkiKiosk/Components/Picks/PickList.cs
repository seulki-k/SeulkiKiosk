using SeulkiKiosk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeulkiKiosk.Components.Picks
{
    public delegate void ItemValueChangedHandler(List<PickItem> pickItems);
    
    [DefaultEvent("ItemValueChanged")]
    public partial class PickList : UserControl
    {
        private List<PickItem> _pickItems = new();

        private void RaiseItemValueChanged()
        {
            ItemValueChanged?.Invoke(_pickItems);
        }
        public PickList()
        {
            InitializeComponent();
        }
        public int BorderWidth { get => roundedPanel1.BorderWidth; set => roundedPanel1.BorderWidth = value; }
        public Color BorderColor { get => roundedPanel1.BorderColor; set => roundedPanel1.BorderColor = value; }
        public event ItemValueChangedHandler? ItemValueChanged;
        public void AddItem(Product product)
        {
            // PickItem이 이미 존재하는지 확인
            PickItem? pickItem = _pickItems.FirstOrDefault(Item => Item.ID == product.ID);
            if(pickItem != null)
            {
                pickItem.Count += 1;
                return;
            }


            // PickItem이 존재하지 않을 경우
            pickItem = new PickItem
            {
                ID = product.ID,
                Title = product.Title,
                Image = product.Image!,
                DefaultPrice = product.Price,
                Count = 1
            };
            pickItem.DeleteClicked += PickItem_DeleteClicked;
            pickItem.CountChanged += PickItem_CountChanged;
            _pickItems.Add(pickItem);
            flpnl.Controls.Add(pickItem);

            RaiseItemValueChanged();

        }

        private void PickItem_CountChanged(object? sender, EventArgs e)
        {
            RaiseItemValueChanged();
        }

        private void PickItem_DeleteClicked(object? sender, EventArgs e)
        {
            PickItem pickItem = (PickItem)sender!;
            _pickItems.Remove(pickItem);
            flpnl.Controls.Remove(pickItem);

            RaiseItemValueChanged();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        internal List<PickItem> GetItems()
        {
            return _pickItems;
        }

        internal void Clear()
        {
            _pickItems.Clear();
            flpnl.Controls.Clear();

            RaiseItemValueChanged();
        }
    }
}
