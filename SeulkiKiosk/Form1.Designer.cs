namespace SeulkiKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerControl1 = new SeulkiKiosk.Components.HeaderControl();
            productCard1 = new SeulkiKiosk.Components.Products.ProductCard();
            SuspendLayout();
            // 
            // headerControl1
            // 
            headerControl1.BackColor = SystemColors.Control;
            headerControl1.Description = "저희 음식점은 국내산만 사용합니다.\r\n누구나 즐길 수 있는 합리적인 가격으로 모시겠습니다.";
            headerControl1.Dock = DockStyle.Top;
            headerControl1.ForeColor = Color.Black;
            headerControl1.Location = new Point(0, 0);
            headerControl1.Margin = new Padding(2);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(701, 141);
            headerControl1.TabIndex = 0;
            headerControl1.Title = "슬기의 음식점에 오신 걸 환영합니다.";
            headerControl1.Load += headerControl1_Load;
            // 
            // productCard1
            // 
            productCard1.BackColor = Color.Transparent;
            productCard1.Location = new Point(44, 135);
            productCard1.Name = "productCard1";
            productCard1.Size = new Size(150, 150);
            productCard1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 544);
            Controls.Add(productCard1);
            Controls.Add(headerControl1);
            ForeColor = Color.CornflowerBlue;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Components.HeaderControl headerControl1;
        private Components.Products.ProductCard productCard1;
    }
}
