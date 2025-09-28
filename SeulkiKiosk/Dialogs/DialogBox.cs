using SeulkiKiosk.Components.Picks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeulkiKiosk.Dialogs
{
    public class DialogBox
    {
        public static DialogResult ShowReceipDialog(IWin32Window owner, List<PickItem> items)
        {
            IReceipDiaglog dialog = new ReceipDialog();
            dialog.SetItems(items);
            return dialog.ShowDialog(owner);
        }
    }
}
