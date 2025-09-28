﻿using KaburiKiosk.Extensions;
using SeulkiKiosk.Components.Picks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeulkiKiosk.Dialogs
{
    public interface IReceipDiaglog
    {
        DialogResult ShowDialog(IWin32Window owner);
        void SetItems(List<PickItem> items);
    }

    public partial class ReceipDialog : Form,IReceipDiaglog
    {
        public ReceipDialog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void SetItems(List<PickItem> items)
        {
            txt.AppendText("---------------- 주문목록 ----------------\r\n");
            txt.AppendText("제품명              단가  수량        금액\r\n");
            foreach (var item in items)
            {
                string paddedTitle = item.Title.PadByteRight(16); // 동적으로 여백 조정
                double d = 3.3;
                d.ToCurrency();
                string paddedDefaultPrice = item.DefaultPrice.ToCurrency().PadByteLeft(8);
                string paddedCount = item.Count.ToString().PadByteLeft(6);
                string paddedSumPrice = (item.DefaultPrice * item.Count).ToCurrency().PadByteLeft(12);
                txt.AppendText($"{paddedTitle}{paddedDefaultPrice}{paddedCount}{paddedSumPrice}\r\n");
            }
            txt.AppendText("------------------------------------------\r\n");
            string paddedTotalPriceTitle = "총금액:".PadByteRight(10);
            decimal totalPrice = items.Sum(item => item.DefaultPrice * item.Count);
            string paddedTotalPrice = totalPrice.ToCurrency().PadByteLeft(32);
            txt.AppendText($"{paddedTotalPriceTitle}{paddedTotalPrice}\r\n");
            txt.AppendText("------------------------------------------\r\n");
            txt.AppendText($"총 {items.Sum(item => item.Count)}개의 상품을 주문하셨습니다.\r\n");
        }
    }
}
