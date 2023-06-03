namespace HoanThien.FormChildCustomer
{
    partial class FormCthd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rjPanel1 = new QuanLyShipper.RJControls.RJPanel();
            this.rjPanel3 = new QuanLyShipper.RJControls.RJPanel();
            this.rjPanel2 = new QuanLyShipper.RJControls.RJPanel();
            this.rjLogin4 = new QuanLyShipper.RJControls.RJLogin();
            this.rjLogin3 = new QuanLyShipper.RJControls.RJLogin();
            this.rjButton1 = new QuanLyShipper.RJControls.RJButton();
            this.dgvdonhang = new System.Windows.Forms.DataGridView();
            this.rjLogin1 = new QuanLyShipper.RJControls.RJLogin();
            this.rjLogin2 = new QuanLyShipper.RJControls.RJLogin();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnOkCustomDate = new QuanLyShipper.RJControls.RJLogin();
            this.btnToday = new QuanLyShipper.RJControls.RJLogin();
            this.btnLast30Days = new QuanLyShipper.RJControls.RJLogin();
            this.btnThisMonth = new QuanLyShipper.RJControls.RJLogin();
            this.btnLast7Days = new QuanLyShipper.RJControls.RJLogin();
            //this.quanLyShipperDataSet = new HoanThien.QuanLyShipperDataSet();
            this.quanLyShipperDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rjPanel1.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdonhang)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.quanLyShipperDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyShipperDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.Transparent;
            this.rjPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjPanel1.BorderColor = System.Drawing.Color.White;
            this.rjPanel1.BorderRadius = 20;
            this.rjPanel1.BorderSize = 3;
            this.rjPanel1.Controls.Add(this.rjPanel3);
            this.rjPanel1.Controls.Add(this.rjPanel2);
            this.rjPanel1.Cursor = System.Windows.Forms.Cursors.No;
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(53, 154);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(958, 537);
            this.rjPanel1.TabIndex = 20;
            this.rjPanel1.TextColor = System.Drawing.Color.White;
            this.rjPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel1_Paint);
            // 
            // rjPanel3
            // 
            this.rjPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.rjPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.rjPanel3.BorderColor = System.Drawing.Color.Cyan;
            this.rjPanel3.BorderRadius = 20;
            this.rjPanel3.BorderSize = 3;
            this.rjPanel3.ForeColor = System.Drawing.Color.White;
            this.rjPanel3.Location = new System.Drawing.Point(516, 3);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(440, 531);
            this.rjPanel3.TabIndex = 4;
            this.rjPanel3.TextColor = System.Drawing.Color.White;
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.rjPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.rjPanel2.BorderColor = System.Drawing.Color.Cyan;
            this.rjPanel2.BorderRadius = 20;
            this.rjPanel2.BorderSize = 3;
            this.rjPanel2.Controls.Add(this.rjLogin4);
            this.rjPanel2.Controls.Add(this.rjLogin3);
            this.rjPanel2.Controls.Add(this.rjButton1);
            this.rjPanel2.Controls.Add(this.dgvdonhang);
            this.rjPanel2.ForeColor = System.Drawing.Color.White;
            this.rjPanel2.Location = new System.Drawing.Point(3, 3);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(514, 531);
            this.rjPanel2.TabIndex = 3;
            this.rjPanel2.TextColor = System.Drawing.Color.White;
            this.rjPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel2_Paint);
            // 
            // rjLogin4
            // 
            this.rjLogin4.BackColor = System.Drawing.Color.Lavender;
            this.rjLogin4.BackgroundColor = System.Drawing.Color.Lavender;
            this.rjLogin4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin4.BorderRadius = 15;
            this.rjLogin4.BorderSize = 3;
            this.rjLogin4.FlatAppearance.BorderSize = 0;
            this.rjLogin4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjLogin4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjLogin4.Location = new System.Drawing.Point(333, 463);
            this.rjLogin4.Name = "rjLogin4";
            this.rjLogin4.Size = new System.Drawing.Size(161, 50);
            this.rjLogin4.TabIndex = 39;
            this.rjLogin4.Text = "Xem chi tiết";
            this.rjLogin4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rjLogin4.UseVisualStyleBackColor = false;
            // 
            // rjLogin3
            // 
            this.rjLogin3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin3.BorderRadius = 20;
            this.rjLogin3.BorderSize = 0;
            this.rjLogin3.FlatAppearance.BorderSize = 0;
            this.rjLogin3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rjLogin3.ForeColor = System.Drawing.Color.White;
            this.rjLogin3.Location = new System.Drawing.Point(333, 44);
            this.rjLogin3.Name = "rjLogin3";
            this.rjLogin3.Size = new System.Drawing.Size(92, 40);
            this.rjLogin3.TabIndex = 21;
            this.rjLogin3.Text = "Tìm kiếm";
            this.rjLogin3.TextColor = System.Drawing.Color.White;
            this.rjLogin3.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.SystemColors.Window;
            this.rjButton1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton1.Location = new System.Drawing.Point(20, 49);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rjButton1.Multiline = false;
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjButton1.PasswordChar = false;
            this.rjButton1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjButton1.PlaceholderText = "";
            this.rjButton1.Size = new System.Drawing.Size(306, 31);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Texts = "";
            this.rjButton1.UnderlinedStyle = false;
            // 
            // dgvdonhang
            // 
            this.dgvdonhang.AllowUserToOrderColumns = true;
            this.dgvdonhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdonhang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvdonhang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.dgvdonhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdonhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdonhang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdonhang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.dgvdonhang.Location = new System.Drawing.Point(15, 98);
            this.dgvdonhang.Name = "dgvdonhang";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdonhang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdonhang.RowHeadersWidth = 51;
            this.dgvdonhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdonhang.Size = new System.Drawing.Size(481, 359);
            this.dgvdonhang.TabIndex = 2;
            this.dgvdonhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rjLogin1
            // 
            this.rjLogin1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin1.BorderRadius = 15;
            this.rjLogin1.BorderSize = 0;
            this.rjLogin1.FlatAppearance.BorderSize = 0;
            this.rjLogin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjLogin1.ForeColor = System.Drawing.Color.White;
            this.rjLogin1.Location = new System.Drawing.Point(222, 110);
            this.rjLogin1.Name = "rjLogin1";
            this.rjLogin1.Size = new System.Drawing.Size(150, 40);
            this.rjLogin1.TabIndex = 0;
            this.rjLogin1.Text = "Thống kê";
            this.rjLogin1.TextColor = System.Drawing.Color.White;
            this.rjLogin1.UseVisualStyleBackColor = false;
            // 
            // rjLogin2
            // 
            this.rjLogin2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin2.BorderRadius = 15;
            this.rjLogin2.BorderSize = 0;
            this.rjLogin2.FlatAppearance.BorderSize = 0;
            this.rjLogin2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjLogin2.ForeColor = System.Drawing.Color.White;
            this.rjLogin2.Location = new System.Drawing.Point(711, 110);
            this.rjLogin2.Name = "rjLogin2";
            this.rjLogin2.Size = new System.Drawing.Size(150, 40);
            this.rjLogin2.TabIndex = 1;
            this.rjLogin2.Text = "Chi tiết đơn hàng";
            this.rjLogin2.TextColor = System.Drawing.Color.White;
            this.rjLogin2.UseVisualStyleBackColor = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpEndDate.Location = new System.Drawing.Point(326, 18);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(201, 26);
            this.dtpEndDate.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(301, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 18);
            this.label21.TabIndex = 18;
            this.label21.Text = "-";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpStartDate.Location = new System.Drawing.Point(87, 18);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(201, 26);
            this.dtpStartDate.TabIndex = 11;
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.BackColor = System.Drawing.Color.Lavender;
            this.btnOkCustomDate.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnOkCustomDate.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOkCustomDate.BorderRadius = 15;
            this.btnOkCustomDate.BorderSize = 3;
            this.btnOkCustomDate.FlatAppearance.BorderSize = 0;
            this.btnOkCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkCustomDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOkCustomDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOkCustomDate.Location = new System.Drawing.Point(541, 17);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(37, 27);
            this.btnOkCustomDate.TabIndex = 40;
            this.btnOkCustomDate.Text = "OK";
            this.btnOkCustomDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOkCustomDate.UseVisualStyleBackColor = false;
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.Lavender;
            this.btnToday.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnToday.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnToday.BorderRadius = 15;
            this.btnToday.BorderSize = 3;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnToday.Location = new System.Drawing.Point(584, 17);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(106, 27);
            this.btnToday.TabIndex = 43;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnToday.UseVisualStyleBackColor = false;
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.BackColor = System.Drawing.Color.Lavender;
            this.btnLast30Days.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnLast30Days.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLast30Days.BorderRadius = 15;
            this.btnLast30Days.BorderSize = 3;
            this.btnLast30Days.FlatAppearance.BorderSize = 0;
            this.btnLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30Days.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast30Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast30Days.Location = new System.Drawing.Point(810, 16);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(108, 27);
            this.btnLast30Days.TabIndex = 44;
            this.btnLast30Days.Text = "30 ngày trước";
            this.btnLast30Days.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast30Days.UseVisualStyleBackColor = false;
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.BackColor = System.Drawing.Color.Lavender;
            this.btnThisMonth.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnThisMonth.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThisMonth.BorderRadius = 15;
            this.btnThisMonth.BorderSize = 3;
            this.btnThisMonth.FlatAppearance.BorderSize = 0;
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThisMonth.Location = new System.Drawing.Point(924, 16);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(108, 27);
            this.btnThisMonth.TabIndex = 45;
            this.btnThisMonth.Text = "Tháng này";
            this.btnThisMonth.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThisMonth.UseVisualStyleBackColor = false;
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.BackColor = System.Drawing.Color.Lavender;
            this.btnLast7Days.BackgroundColor = System.Drawing.Color.Lavender;
            this.btnLast7Days.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLast7Days.BorderRadius = 15;
            this.btnLast7Days.BorderSize = 3;
            this.btnLast7Days.FlatAppearance.BorderSize = 0;
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast7Days.Location = new System.Drawing.Point(696, 17);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(108, 27);
            this.btnLast7Days.TabIndex = 46;
            this.btnLast7Days.Text = "7 ngày trước";
            this.btnLast7Days.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast7Days.UseVisualStyleBackColor = false;
            /*
            // quanLyShipperDataSet
            // 
            this.quanLyShipperDataSet.DataSetName = "QuanLyShipperDataSet";
            this.quanLyShipperDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyShipperDataSetBindingSource
            // 
            this.quanLyShipperDataSetBindingSource.DataSource = this.quanLyShipperDataSet;
            this.quanLyShipperDataSetBindingSource.Position = 0;
            */ 
            // FormCthd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 701);
            this.Controls.Add(this.btnOkCustomDate);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.rjLogin2);
            this.Controls.Add(this.rjLogin1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dtpStartDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCthd";
            this.Text = "History";
            this.Load += new System.EventHandler(this.FormCthd_Load);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdonhang)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.quanLyShipperDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyShipperDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuanLyShipper.RJControls.RJPanel rjPanel1;
        private QuanLyShipper.RJControls.RJLogin rjLogin1;
        private QuanLyShipper.RJControls.RJLogin rjLogin2;
        private QuanLyShipper.RJControls.RJPanel rjPanel2;
        private System.Windows.Forms.DataGridView dgvdonhang;
        private QuanLyShipper.RJControls.RJPanel rjPanel3;
        private QuanLyShipper.RJControls.RJButton rjButton1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private QuanLyShipper.RJControls.RJLogin rjLogin3;
        private QuanLyShipper.RJControls.RJLogin rjLogin4;
        private QuanLyShipper.RJControls.RJLogin btnOkCustomDate;
        private QuanLyShipper.RJControls.RJLogin btnToday;
        private QuanLyShipper.RJControls.RJLogin btnLast30Days;
        private QuanLyShipper.RJControls.RJLogin btnThisMonth;
        private QuanLyShipper.RJControls.RJLogin btnLast7Days;
        private System.Windows.Forms.BindingSource quanLyShipperDataSetBindingSource;
        //private QuanLyShipperDataSet quanLyShipperDataSet;
    }
}