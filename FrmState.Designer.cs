namespace HotelClient
{
    partial class FrmState
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
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(12, 41);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(41, 12);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "label1";
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Location = new System.Drawing.Point(12, 126);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(41, 12);
            this.lblRoomStatus.TabIndex = 0;
            this.lblRoomStatus.Text = "label1";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(12, 221);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(41, 12);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "label1";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(12, 315);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(41, 12);
            this.lblFloor.TabIndex = 0;
            this.lblFloor.Text = "label1";
            // 
            // FrmState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomStatus);
            this.Controls.Add(this.lblRoomNumber);
            this.Name = "FrmState";
            this.Text = "FrmState";
            this.Load += new System.EventHandler(this.FrmState_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblFloor;
    }
}