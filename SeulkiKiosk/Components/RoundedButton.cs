using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeulkiKiosk.Components
{
    [DefaultEvent("Click")]
    public partial class RoundedButton : UserControl
    {
        private Color _originalBackColor;

        public RoundedButton()
        {
            InitializeComponent();
            base.BackColor = Color.Transparent;
            lblText.MouseEnter += LblText_MouseEnter;
            lblText.MouseLeave += LblText_MouseLeave;
            lblText.Click += lblText_Click;
        }

        public new event EventHandler? Click;
        private void lblText_Click(object? sender, EventArgs e)
        {
            Click?.Invoke(this, e);
        }

        private void LblText_MouseLeave(object? sender, EventArgs e)
        {
            roundedPanel1.InnerBackgroundColor = _originalBackColor;
        }

        private void LblText_MouseEnter(object? sender, EventArgs e)
        {
            roundedPanel1.InnerBackgroundColor = Color.FromArgb((int)(225*0.9), _originalBackColor);
        }

        public int BorderWidth { get => roundedPanel1.BorderWidth; set => roundedPanel1.BorderWidth = value; }
        public Color BorderColor { get => roundedPanel1.BorderColor; set => roundedPanel1.BorderColor = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text { get => lblText.Text; set => lblText.Text = value; }

        public new Color BackColor 
        { 
            get =>roundedPanel1.InnerBackgroundColor;
            set
            {
                _originalBackColor = value;
                roundedPanel1.InnerBackgroundColor = value;
            } 
        }
        
        public new Font Font { get => lblText.Font; set => lblText.Font = value; }

        // ShouldSerializeFont 메서드를 추가하여 기본값과 다른 경우에만 Font 속성을 직렬화하도록 설정
        private bool ShouldSerializeFont()
        {
            //같다(기본값 그대로) → false 반환 → 직렬화하지 않음
            //다르다(사용자가 바꿈) → true 반환 → 직렬화함
            return !lblText.Font.Equals(SystemFonts.DefaultFont);
        }
    }
}
