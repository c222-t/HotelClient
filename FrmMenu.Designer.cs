namespace HotelClient
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.tmAime = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddShoppingCart = new System.Windows.Forms.ToolStripMenuItem();
            this.购买ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblTotalConsumption = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbWeather2 = new System.Windows.Forms.PictureBox();
            this.lblWeather = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmAime
            // 
            this.tmAime.Enabled = true;
            this.tmAime.Tick += new System.EventHandler(this.TmAime_Tick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblName.Location = new System.Drawing.Point(7, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 21);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "|欢迎XXX光临";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(97, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "歪嘴大酒店";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnShoppingCart);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(243, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 553);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "酒店服务";
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.Location = new System.Drawing.Point(643, 514);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(75, 33);
            this.btnShoppingCart.TabIndex = 1;
            this.btnShoppingCart.Text = "购物车";
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.Click += new System.EventHandler(this.BtnShoppingCart_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(3, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(727, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "便利店";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(721, 447);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "图片";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CommodityName";
            this.Column1.HeaderText = "商品名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CommodityUnit";
            this.Column2.HeaderText = "商品单位";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Retail";
            this.Column3.HeaderText = "商品售价";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PicturePath";
            this.Column5.HeaderText = "图片路径";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Number";
            this.Column6.HeaderText = "编号";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddShoppingCart,
            this.购买ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // tsmiAddShoppingCart
            // 
            this.tsmiAddShoppingCart.Name = "tsmiAddShoppingCart";
            this.tsmiAddShoppingCart.Size = new System.Drawing.Size(136, 22);
            this.tsmiAddShoppingCart.Text = "加入购物车";
            this.tsmiAddShoppingCart.Click += new System.EventHandler(this.TsmiAddShoppingCart_Click);
            // 
            // 购买ToolStripMenuItem
            // 
            this.购买ToolStripMenuItem.Name = "购买ToolStripMenuItem";
            this.购买ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.购买ToolStripMenuItem.Text = "购买";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "餐厅";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(66, 85);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(6, 525);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 25);
            this.lblTime.TabIndex = 21;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomNumber.Location = new System.Drawing.Point(20, 80);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(0, 21);
            this.lblRoomNumber.TabIndex = 25;
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomStatus.Location = new System.Drawing.Point(20, 146);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(0, 21);
            this.lblRoomStatus.TabIndex = 24;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomType.Location = new System.Drawing.Point(150, 80);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(0, 21);
            this.lblRoomType.TabIndex = 23;
            // 
            // lblTotalConsumption
            // 
            this.lblTotalConsumption.AutoSize = true;
            this.lblTotalConsumption.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalConsumption.Location = new System.Drawing.Point(20, 219);
            this.lblTotalConsumption.Name = "lblTotalConsumption";
            this.lblTotalConsumption.Size = new System.Drawing.Size(0, 21);
            this.lblTotalConsumption.TabIndex = 24;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFloor.Location = new System.Drawing.Point(150, 146);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(0, 21);
            this.lblFloor.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(20, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "房间号";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBalance.Location = new System.Drawing.Point(150, 219);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 21);
            this.lblBalance.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(20, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "房间状态";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(150, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "房间类型";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(20, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "总消费";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(150, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "楼层";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(150, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "余额";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(9, 311);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(210, 212);
            this.textBox2.TabIndex = 31;
            // 
            // lblda
            // 
            this.lblda.AutoSize = true;
            this.lblda.Location = new System.Drawing.Point(41, 282);
            this.lblda.Name = "lblda";
            this.lblda.Size = new System.Drawing.Size(0, 21);
            this.lblda.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pbWeather2);
            this.groupBox1.Controls.Add(this.lblWeather);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblda);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblFloor);
            this.groupBox1.Controls.Add(this.lblTotalConsumption);
            this.groupBox1.Controls.Add(this.lblRoomType);
            this.groupBox1.Controls.Add(this.lblRoomStatus);
            this.groupBox1.Controls.Add(this.lblRoomNumber);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 553);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "房间信息及状态";
            // 
            // pbWeather2
            // 
            this.pbWeather2.Location = new System.Drawing.Point(69, 282);
            this.pbWeather2.Name = "pbWeather2";
            this.pbWeather2.Size = new System.Drawing.Size(26, 24);
            this.pbWeather2.TabIndex = 42;
            this.pbWeather2.TabStop = false;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWeather.Location = new System.Drawing.Point(119, 256);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(42, 21);
            this.lblWeather.TabIndex = 41;
            this.lblWeather.Text = "刷新";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 21);
            this.label10.TabIndex = 40;
            this.label10.Text = "当前天气情况";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmAime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddShoppingCart;
        private System.Windows.Forms.ToolStripMenuItem 购买ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblTotalConsumption;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbWeather2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}