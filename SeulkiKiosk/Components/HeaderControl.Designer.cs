﻿namespace SeulkiKiosk.Components
{
    partial class HeaderControl
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
            lblTitle = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(39, 14);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "lblTitle";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Gray;
            lblDescription.Location = new Point(39, 58);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(112, 21);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "lblDescription";
            // 
            // HeaderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HeaderControl";
            Size = new Size(627, 89);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
    }
}
