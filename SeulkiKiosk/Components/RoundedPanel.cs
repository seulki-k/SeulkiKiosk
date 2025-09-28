using SeulkiKiosk.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeulkiKiosk.Components
{
    public class RoundedPanel : Panel
    {
		private int _borderWidth = 2;
		private int _borderRadius = 8;
		private Color _borderColor = Color.Black;
		private Color _innerBackgroundColor = Color.White;

		public RoundedPanel()
		{
			Resize += RoundedPanel_ReSize;
		}

		public void RoundedPanel_ReSize(object? sender, EventArgs e)
		{
			this.Invalidate();
        }

        [DefaultValue(2),Category("커스텀"),Description("보더 두께를 조절합니다.")]
		public int BorderWidth
		{
			get { return _borderWidth; }
			set { _borderWidth = value; this.Invalidate(); }
        }

		[DefaultValue(8), Category("커스텀"), Description("보더 둥글기를 조절합니다.")]
        public int BorderRadius
		{
			get { return _borderRadius; }
			set { _borderRadius = value; this.Invalidate(); }
		}

		[DefaultValue(typeof(Color), "Black"), Category("커스텀"), Description("보더 색상을 변경합니다.")]
        public Color BorderColor
		{
			get { return _borderColor; }
			set { _borderColor = value; this.Invalidate(); }
		}
		[DefaultValue(typeof(Color), "White"), Category("커스텀"), Description("보더 내부 색상을 변경합니다.")]
        public Color InnerBackgroundColor
		{
			get { return _innerBackgroundColor; }
			set { _innerBackgroundColor = value; this.Invalidate(); }
		}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;

			// 패널 경계 계산
			Rectangle rect = new Rectangle(_borderWidth, _borderWidth, this.Width - _borderWidth*2, this.Height - _borderWidth *2);

			GraphicsPath path =  GraphicsUtil.GetRoundedRectanglePath(rect, _borderRadius);

			// 내부 영역 채우기
			using (SolidBrush brush = new SolidBrush(_innerBackgroundColor))
			{
				graphics.FillPath(brush, path);
            }
			//보더 그리기
			using (Pen borderPen = new Pen(_borderColor, _borderWidth))
			{
                graphics.DrawPath(borderPen, path);
            }

        }
	}
}
