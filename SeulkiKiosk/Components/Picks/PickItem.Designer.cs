﻿namespace SeulkiKiosk.Components.Picks
{
    partial class PickItem
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            picBox = new PictureBox();
            lblTitle = new Label();
            btnDown = new Button();
            lblCount = new Label();
            btnUp = new Button();
            lblSumPrice = new Label();
            btnDel = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(picBox);
            flowLayoutPanel1.Controls.Add(lblTitle);
            flowLayoutPanel1.Controls.Add(btnDown);
            flowLayoutPanel1.Controls.Add(lblCount);
            flowLayoutPanel1.Controls.Add(btnUp);
            flowLayoutPanel1.Controls.Add(lblSumPrice);
            flowLayoutPanel1.Controls.Add(btnDel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(549, 48);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // picBox
            // 
            picBox.Location = new Point(3, 3);
            picBox.Name = "picBox";
            picBox.Size = new Size(75, 45);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(84, 3);
            lblTitle.Margin = new Padding(3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "lblTitle";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(215, 3);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(35, 45);
            btnDown.TabIndex = 2;
            btnDown.Text = "<";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // lblCount
            // 
            lblCount.Location = new Point(256, 3);
            lblCount.Margin = new Padding(3);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(56, 45);
            lblCount.TabIndex = 3;
            lblCount.Text = "lblCount";
            lblCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(318, 3);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(41, 45);
            btnUp.TabIndex = 4;
            btnUp.Text = ">";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // lblSumPrice
            // 
            lblSumPrice.Location = new Point(365, 3);
            lblSumPrice.Margin = new Padding(3);
            lblSumPrice.Name = "lblSumPrice";
            lblSumPrice.Size = new Size(88, 45);
            lblSumPrice.TabIndex = 5;
            lblSumPrice.Text = "lblSumPrice";
            lblSumPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(459, 3);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(41, 45);
            btnDel.TabIndex = 6;
            btnDel.Text = "X";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // PickItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "PickItem";
            Size = new Size(549, 48);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox picBox;
        private Label lblTitle;
        private Button btnDown;
        private Label lblCount;
        private Button btnUp;
        private Label lblSumPrice;
        private Button btnDel;
    }
}
