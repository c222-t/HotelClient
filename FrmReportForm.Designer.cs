namespace HotelClient
{
    partial class FrmReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblroomNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmoney = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSpendingTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalConsumption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间号";
            // 
            // lblroomNumber
            // 
            this.lblroomNumber.AutoSize = true;
            this.lblroomNumber.Location = new System.Drawing.Point(48, 57);
            this.lblroomNumber.Name = "lblroomNumber";
            this.lblroomNumber.Size = new System.Drawing.Size(41, 12);
            this.lblroomNumber.TabIndex = 1;
            this.lblroomNumber.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "身份证";
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Location = new System.Drawing.Point(160, 57);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(41, 12);
            this.lblIDCard.TabIndex = 1;
            this.lblIDCard.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "金额";
            // 
            // lblmoney
            // 
            this.lblmoney.AccessibleDescription = "";
            this.lblmoney.AutoSize = true;
            this.lblmoney.Location = new System.Drawing.Point(48, 126);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(41, 12);
            this.lblmoney.TabIndex = 1;
            this.lblmoney.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "消费时间";
            // 
            // lblSpendingTime
            // 
            this.lblSpendingTime.AutoSize = true;
            this.lblSpendingTime.Location = new System.Drawing.Point(160, 126);
            this.lblSpendingTime.Name = "lblSpendingTime";
            this.lblSpendingTime.Size = new System.Drawing.Size(41, 12);
            this.lblSpendingTime.TabIndex = 1;
            this.lblSpendingTime.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "商品描述";
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Location = new System.Drawing.Point(48, 194);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(41, 12);
            this.lblDescribe.TabIndex = 1;
            this.lblDescribe.Text = "label2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "总消费";
            // 
            // lblTotalConsumption
            // 
            this.lblTotalConsumption.AutoSize = true;
            this.lblTotalConsumption.Location = new System.Drawing.Point(160, 194);
            this.lblTotalConsumption.Name = "lblTotalConsumption";
            this.lblTotalConsumption.Size = new System.Drawing.Size(41, 12);
            this.lblTotalConsumption.TabIndex = 1;
            this.lblTotalConsumption.Text = "label2";
            // 
            // FrmReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 400);
            this.Controls.Add(this.lblTotalConsumption);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblSpendingTime);
            this.Controls.Add(this.lblmoney);
            this.Controls.Add(this.lblIDCard);
            this.Controls.Add(this.lblroomNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmReportForm";
            this.Text = "报表中心";
            this.Load += new System.EventHandler(this.FrmReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblroomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSpendingTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalConsumption;
    }
}