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
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.quanLyShipperDataSet = new KhachHang.QuanLyShipperDataSet();
            this.quanLyShipperDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOkCustomDate = new QuanLyShipper.RJControls.RJLogin();
            this.btnLast7Days = new QuanLyShipper.RJControls.RJLogin();
            this.btnThisMonth = new QuanLyShipper.RJControls.RJLogin();
            this.btnLast30Days = new QuanLyShipper.RJControls.RJLogin();
            this.btnToday = new QuanLyShipper.RJControls.RJLogin();
            this.rjPanel1 = new QuanLyShipper.RJControls.RJPanel();
            this.rjPanel3 = new QuanLyShipper.RJControls.RJPanel();
            this.TxtDiaChiNhanHang = new QuanLyShipper.RJControls.RJTextBox();
            this.TxtMaSP = new QuanLyShipper.RJControls.RJTextBox();
            this.TxtGiaTri = new QuanLyShipper.RJControls.RJTextBox();
            this.TxtLoaiHang = new QuanLyShipper.RJControls.RJTextBox();
            this.TxtTenHang = new QuanLyShipper.RJControls.RJTextBox();
            this.TxtMaDon = new QuanLyShipper.RJControls.RJTextBox();
            this.rjLogin11 = new QuanLyShipper.RJControls.RJLogin();
            this.rjLogin9 = new QuanLyShipper.RJControls.RJLogin();
            this.rjLogin7 = new QuanLyShipper.RJControls.RJLogin();
            this.ThoiDiemNhanHang = new System.Windows.Forms.DateTimePicker();
            this.rjLogin10 = new QuanLyShipper.RJControls.RJLogin();
            this.rjLogin6 = new QuanLyShipper.RJControls.RJLogin();
            this.rjLogin5 = new QuanLyShipper.RJControls.RJLogin();
            this.rjLogin8 = new QuanLyShipper.RJControls.RJLogin();
            this.rjPanel2 = new QuanLyShipper.RJControls.RJPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rjLogin4 = new QuanLyShipper.RJControls.RJLogin();
            this.rjLogin3 = new QuanLyShipper.RJControls.RJLogin();
            this.rjButton1 = new QuanLyShipper.RJControls.RJButton();
            this.rjLogin2 = new QuanLyShipper.RJControls.RJLogin();
            this.rjLogin1 = new QuanLyShipper.RJControls.RJLogin();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyShipperDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyShipperDataSetBindingSource)).BeginInit();
            this.rjPanel1.SuspendLayout();
            this.rjPanel3.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpEndDate.Location = new System.Drawing.Point(435, 22);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(267, 30);
            this.dtpEndDate.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(401, 23);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 23);
            this.label21.TabIndex = 18;
            this.label21.Text = "-";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpStartDate.Location = new System.Drawing.Point(116, 22);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(267, 30);
            this.dtpStartDate.TabIndex = 11;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // quanLyShipperDataSet
            // 
            this.quanLyShipperDataSet.DataSetName = "QuanLyShipperDataSet";
            this.quanLyShipperDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyShipperDataSetBindingSource
            // 
            this.quanLyShipperDataSetBindingSource.DataSource = this.quanLyShipperDataSet;
            this.quanLyShipperDataSetBindingSource.Position = 0;
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
            this.btnOkCustomDate.Location = new System.Drawing.Point(721, 21);
            this.btnOkCustomDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(49, 33);
            this.btnOkCustomDate.TabIndex = 40;
            this.btnOkCustomDate.Text = "OK";
            this.btnOkCustomDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOkCustomDate.UseVisualStyleBackColor = false;
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
            this.btnLast7Days.Location = new System.Drawing.Point(928, 21);
            this.btnLast7Days.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(144, 33);
            this.btnLast7Days.TabIndex = 46;
            this.btnLast7Days.Text = "7 ngày trước";
            this.btnLast7Days.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast7Days.UseVisualStyleBackColor = false;
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
            this.btnThisMonth.Location = new System.Drawing.Point(1232, 20);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(144, 33);
            this.btnThisMonth.TabIndex = 45;
            this.btnThisMonth.Text = "Tháng này";
            this.btnThisMonth.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThisMonth.UseVisualStyleBackColor = false;
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
            this.btnLast30Days.Location = new System.Drawing.Point(1080, 20);
            this.btnLast30Days.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(144, 33);
            this.btnLast30Days.TabIndex = 44;
            this.btnLast30Days.Text = "30 ngày trước";
            this.btnLast30Days.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLast30Days.UseVisualStyleBackColor = false;
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
            this.btnToday.Location = new System.Drawing.Point(779, 21);
            this.btnToday.Margin = new System.Windows.Forms.Padding(4);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(141, 33);
            this.btnToday.TabIndex = 43;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnToday.UseVisualStyleBackColor = false;
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
            this.rjPanel1.Location = new System.Drawing.Point(71, 190);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(1277, 661);
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
            this.rjPanel3.Controls.Add(this.TxtDiaChiNhanHang);
            this.rjPanel3.Controls.Add(this.TxtMaSP);
            this.rjPanel3.Controls.Add(this.TxtGiaTri);
            this.rjPanel3.Controls.Add(this.TxtLoaiHang);
            this.rjPanel3.Controls.Add(this.TxtTenHang);
            this.rjPanel3.Controls.Add(this.TxtMaDon);
            this.rjPanel3.Controls.Add(this.rjLogin11);
            this.rjPanel3.Controls.Add(this.rjLogin9);
            this.rjPanel3.Controls.Add(this.rjLogin7);
            this.rjPanel3.Controls.Add(this.ThoiDiemNhanHang);
            this.rjPanel3.Controls.Add(this.rjLogin10);
            this.rjPanel3.Controls.Add(this.rjLogin6);
            this.rjPanel3.Controls.Add(this.rjLogin5);
            this.rjPanel3.Controls.Add(this.rjLogin8);
            this.rjPanel3.ForeColor = System.Drawing.Color.White;
            this.rjPanel3.Location = new System.Drawing.Point(688, 4);
            this.rjPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.rjPanel3.Name = "rjPanel3";
            this.rjPanel3.Size = new System.Drawing.Size(587, 654);
            this.rjPanel3.TabIndex = 4;
            this.rjPanel3.TextColor = System.Drawing.Color.White;
            // 
            // TxtDiaChiNhanHang
            // 
            this.TxtDiaChiNhanHang.BackColor = System.Drawing.Color.AliceBlue;
            this.TxtDiaChiNhanHang.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.TxtDiaChiNhanHang.BorderColor = System.Drawing.Color.HotPink;
            this.TxtDiaChiNhanHang.BorderRadius = 15;
            this.TxtDiaChiNhanHang.BorderSize = 3;
            this.TxtDiaChiNhanHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TxtDiaChiNhanHang.ForeColor = System.Drawing.Color.White;
            this.TxtDiaChiNhanHang.Location = new System.Drawing.Point(200, 438);
            this.TxtDiaChiNhanHang.Name = "TxtDiaChiNhanHang";
            this.TxtDiaChiNhanHang.Size = new System.Drawing.Size(376, 34);
            this.TxtDiaChiNhanHang.TabIndex = 46;
            this.TxtDiaChiNhanHang.TextColor = System.Drawing.Color.White;
            // 
            // TxtMaSP
            // 
            this.TxtMaSP.BackColor = System.Drawing.Color.AliceBlue;
            this.TxtMaSP.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.TxtMaSP.BorderColor = System.Drawing.Color.HotPink;
            this.TxtMaSP.BorderRadius = 15;
            this.TxtMaSP.BorderSize = 3;
            this.TxtMaSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TxtMaSP.ForeColor = System.Drawing.Color.White;
            this.TxtMaSP.Location = new System.Drawing.Point(200, 355);
            this.TxtMaSP.Name = "TxtMaSP";
            this.TxtMaSP.Size = new System.Drawing.Size(365, 34);
            this.TxtMaSP.TabIndex = 45;
            this.TxtMaSP.TextColor = System.Drawing.Color.White;
            // 
            // TxtGiaTri
            // 
            this.TxtGiaTri.BackColor = System.Drawing.Color.AliceBlue;
            this.TxtGiaTri.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.TxtGiaTri.BorderColor = System.Drawing.Color.HotPink;
            this.TxtGiaTri.BorderRadius = 15;
            this.TxtGiaTri.BorderSize = 3;
            this.TxtGiaTri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TxtGiaTri.ForeColor = System.Drawing.Color.White;
            this.TxtGiaTri.Location = new System.Drawing.Point(200, 259);
            this.TxtGiaTri.Name = "TxtGiaTri";
            this.TxtGiaTri.Size = new System.Drawing.Size(365, 34);
            this.TxtGiaTri.TabIndex = 44;
            this.TxtGiaTri.TextColor = System.Drawing.Color.White;
            // 
            // TxtLoaiHang
            // 
            this.TxtLoaiHang.BackColor = System.Drawing.Color.AliceBlue;
            this.TxtLoaiHang.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.TxtLoaiHang.BorderColor = System.Drawing.Color.HotPink;
            this.TxtLoaiHang.BorderRadius = 15;
            this.TxtLoaiHang.BorderSize = 3;
            this.TxtLoaiHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TxtLoaiHang.ForeColor = System.Drawing.Color.White;
            this.TxtLoaiHang.Location = new System.Drawing.Point(200, 184);
            this.TxtLoaiHang.Name = "TxtLoaiHang";
            this.TxtLoaiHang.Size = new System.Drawing.Size(365, 34);
            this.TxtLoaiHang.TabIndex = 43;
            this.TxtLoaiHang.TextColor = System.Drawing.Color.White;
            // 
            // TxtTenHang
            // 
            this.TxtTenHang.BackColor = System.Drawing.Color.AliceBlue;
            this.TxtTenHang.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.TxtTenHang.BorderColor = System.Drawing.Color.HotPink;
            this.TxtTenHang.BorderRadius = 15;
            this.TxtTenHang.BorderSize = 3;
            this.TxtTenHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TxtTenHang.ForeColor = System.Drawing.Color.White;
            this.TxtTenHang.Location = new System.Drawing.Point(200, 112);
            this.TxtTenHang.Name = "TxtTenHang";
            this.TxtTenHang.Size = new System.Drawing.Size(365, 34);
            this.TxtTenHang.TabIndex = 42;
            this.TxtTenHang.TextColor = System.Drawing.Color.White;
            // 
            // TxtMaDon
            // 
            this.TxtMaDon.BackColor = System.Drawing.Color.AliceBlue;
            this.TxtMaDon.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.TxtMaDon.BorderColor = System.Drawing.Color.HotPink;
            this.TxtMaDon.BorderRadius = 15;
            this.TxtMaDon.BorderSize = 3;
            this.TxtMaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TxtMaDon.ForeColor = System.Drawing.Color.White;
            this.TxtMaDon.Location = new System.Drawing.Point(200, 28);
            this.TxtMaDon.Name = "TxtMaDon";
            this.TxtMaDon.Size = new System.Drawing.Size(365, 34);
            this.TxtMaDon.TabIndex = 41;
            this.TxtMaDon.TextColor = System.Drawing.Color.White;
            // 
            // rjLogin11
            // 
            this.rjLogin11.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin11.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin11.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin11.BorderRadius = 20;
            this.rjLogin11.BorderSize = 0;
            this.rjLogin11.FlatAppearance.BorderSize = 0;
            this.rjLogin11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rjLogin11.ForeColor = System.Drawing.Color.White;
            this.rjLogin11.Location = new System.Drawing.Point(38, 169);
            this.rjLogin11.Margin = new System.Windows.Forms.Padding(4);
            this.rjLogin11.Name = "rjLogin11";
            this.rjLogin11.Size = new System.Drawing.Size(123, 49);
            this.rjLogin11.TabIndex = 28;
            this.rjLogin11.Text = "Loại hàng";
            this.rjLogin11.TextColor = System.Drawing.Color.White;
            this.rjLogin11.UseVisualStyleBackColor = false;
            // 
            // rjLogin9
            // 
            this.rjLogin9.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin9.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin9.BorderRadius = 20;
            this.rjLogin9.BorderSize = 0;
            this.rjLogin9.FlatAppearance.BorderSize = 0;
            this.rjLogin9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rjLogin9.ForeColor = System.Drawing.Color.White;
            this.rjLogin9.Location = new System.Drawing.Point(95, 514);
            this.rjLogin9.Margin = new System.Windows.Forms.Padding(4);
            this.rjLogin9.Name = "rjLogin9";
            this.rjLogin9.Size = new System.Drawing.Size(198, 49);
            this.rjLogin9.TabIndex = 26;
            this.rjLogin9.Text = "Thời điểm nhân hàng";
            this.rjLogin9.TextColor = System.Drawing.Color.White;
            this.rjLogin9.UseVisualStyleBackColor = false;
            // 
            // rjLogin7
            // 
            this.rjLogin7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin7.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin7.BorderRadius = 20;
            this.rjLogin7.BorderSize = 0;
            this.rjLogin7.FlatAppearance.BorderSize = 0;
            this.rjLogin7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rjLogin7.ForeColor = System.Drawing.Color.White;
            this.rjLogin7.Location = new System.Drawing.Point(12, 423);
            this.rjLogin7.Margin = new System.Windows.Forms.Padding(4);
            this.rjLogin7.Name = "rjLogin7";
            this.rjLogin7.Size = new System.Drawing.Size(170, 49);
            this.rjLogin7.TabIndex = 24;
            this.rjLogin7.Text = "Địa chỉ nhận hàng";
            this.rjLogin7.TextColor = System.Drawing.Color.White;
            this.rjLogin7.UseVisualStyleBackColor = false;
            // 
            // ThoiDiemNhanHang
            // 
            this.ThoiDiemNhanHang.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoiDiemNhanHang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoiDiemNhanHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ThoiDiemNhanHang.Location = new System.Drawing.Point(321, 521);
            this.ThoiDiemNhanHang.Name = "ThoiDiemNhanHang";
            this.ThoiDiemNhanHang.Size = new System.Drawing.Size(173, 38);
            this.ThoiDiemNhanHang.TabIndex = 8;
            this.ThoiDiemNhanHang.Value = new System.DateTime(2023, 6, 4, 18, 52, 23, 0);
            this.ThoiDiemNhanHang.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rjLogin10
            // 
            this.rjLogin10.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin10.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin10.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin10.BorderRadius = 20;
            this.rjLogin10.BorderSize = 0;
            this.rjLogin10.FlatAppearance.BorderSize = 0;
            this.rjLogin10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rjLogin10.ForeColor = System.Drawing.Color.White;
            this.rjLogin10.Location = new System.Drawing.Point(32, 340);
            this.rjLogin10.Margin = new System.Windows.Forms.Padding(4);
            this.rjLogin10.Name = "rjLogin10";
            this.rjLogin10.Size = new System.Drawing.Size(141, 49);
            this.rjLogin10.TabIndex = 27;
            this.rjLogin10.Text = "Mã sản phẩm";
            this.rjLogin10.TextColor = System.Drawing.Color.White;
            this.rjLogin10.UseVisualStyleBackColor = false;
            // 
            // rjLogin6
            // 
            this.rjLogin6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin6.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin6.BorderRadius = 20;
            this.rjLogin6.BorderSize = 0;
            this.rjLogin6.FlatAppearance.BorderSize = 0;
            this.rjLogin6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rjLogin6.ForeColor = System.Drawing.Color.White;
            this.rjLogin6.Location = new System.Drawing.Point(38, 97);
            this.rjLogin6.Margin = new System.Windows.Forms.Padding(4);
            this.rjLogin6.Name = "rjLogin6";
            this.rjLogin6.Size = new System.Drawing.Size(123, 49);
            this.rjLogin6.TabIndex = 23;
            this.rjLogin6.Text = "Tên hàng";
            this.rjLogin6.TextColor = System.Drawing.Color.White;
            this.rjLogin6.UseVisualStyleBackColor = false;
            // 
            // rjLogin5
            // 
            this.rjLogin5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin5.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin5.BorderRadius = 20;
            this.rjLogin5.BorderSize = 0;
            this.rjLogin5.FlatAppearance.BorderSize = 0;
            this.rjLogin5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rjLogin5.ForeColor = System.Drawing.Color.White;
            this.rjLogin5.Location = new System.Drawing.Point(38, 23);
            this.rjLogin5.Margin = new System.Windows.Forms.Padding(4);
            this.rjLogin5.Name = "rjLogin5";
            this.rjLogin5.Size = new System.Drawing.Size(123, 49);
            this.rjLogin5.TabIndex = 22;
            this.rjLogin5.Text = "Mã đơn";
            this.rjLogin5.TextColor = System.Drawing.Color.White;
            this.rjLogin5.UseVisualStyleBackColor = false;
            // 
            // rjLogin8
            // 
            this.rjLogin8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin8.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjLogin8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjLogin8.BorderRadius = 20;
            this.rjLogin8.BorderSize = 0;
            this.rjLogin8.FlatAppearance.BorderSize = 0;
            this.rjLogin8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjLogin8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rjLogin8.ForeColor = System.Drawing.Color.White;
            this.rjLogin8.Location = new System.Drawing.Point(38, 254);
            this.rjLogin8.Margin = new System.Windows.Forms.Padding(4);
            this.rjLogin8.Name = "rjLogin8";
            this.rjLogin8.Size = new System.Drawing.Size(123, 49);
            this.rjLogin8.TabIndex = 25;
            this.rjLogin8.Text = "Giá trị đơn";
            this.rjLogin8.TextColor = System.Drawing.Color.White;
            this.rjLogin8.UseVisualStyleBackColor = false;
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.rjPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.rjPanel2.BorderColor = System.Drawing.Color.Cyan;
            this.rjPanel2.BorderRadius = 20;
            this.rjPanel2.BorderSize = 3;
            this.rjPanel2.Controls.Add(this.dataGridView1);
            this.rjPanel2.Controls.Add(this.rjLogin4);
            this.rjPanel2.Controls.Add(this.rjLogin3);
            this.rjPanel2.Controls.Add(this.rjButton1);
            this.rjPanel2.ForeColor = System.Drawing.Color.White;
            this.rjPanel2.Location = new System.Drawing.Point(4, 4);
            this.rjPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(685, 654);
            this.rjPanel2.TabIndex = 3;
            this.rjPanel2.TextColor = System.Drawing.Color.White;
            this.rjPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 413);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.rjLogin4.Location = new System.Drawing.Point(444, 570);
            this.rjLogin4.Margin = new System.Windows.Forms.Padding(4);
            this.rjLogin4.Name = "rjLogin4";
            this.rjLogin4.Size = new System.Drawing.Size(215, 62);
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
            this.rjLogin3.Location = new System.Drawing.Point(444, 54);
            this.rjLogin3.Margin = new System.Windows.Forms.Padding(4);
            this.rjLogin3.Name = "rjLogin3";
            this.rjLogin3.Size = new System.Drawing.Size(123, 49);
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
            this.rjButton1.Location = new System.Drawing.Point(27, 60);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(5);
            this.rjButton1.Multiline = false;
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.rjButton1.PasswordChar = false;
            this.rjButton1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjButton1.PlaceholderText = "";
            this.rjButton1.Size = new System.Drawing.Size(408, 39);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Texts = "";
            this.rjButton1.UnderlinedStyle = false;
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
            this.rjLogin2.Location = new System.Drawing.Point(948, 135);
            this.rjLogin2.Margin = new System.Windows.Forms.Padding(4);
            this.rjLogin2.Name = "rjLogin2";
            this.rjLogin2.Size = new System.Drawing.Size(200, 49);
            this.rjLogin2.TabIndex = 1;
            this.rjLogin2.Text = "Chi tiết đơn hàng";
            this.rjLogin2.TextColor = System.Drawing.Color.White;
            this.rjLogin2.UseVisualStyleBackColor = false;
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
            this.rjLogin1.Location = new System.Drawing.Point(296, 135);
            this.rjLogin1.Margin = new System.Windows.Forms.Padding(4);
            this.rjLogin1.Name = "rjLogin1";
            this.rjLogin1.Size = new System.Drawing.Size(200, 49);
            this.rjLogin1.TabIndex = 0;
            this.rjLogin1.Text = "Thống kê";
            this.rjLogin1.TextColor = System.Drawing.Color.White;
            this.rjLogin1.UseVisualStyleBackColor = false;
            // 
            // FormCthd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1389, 863);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCthd";
            this.Text = "History";
            this.Load += new System.EventHandler(this.FormCthd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyShipperDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyShipperDataSetBindingSource)).EndInit();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel3.ResumeLayout(false);
            this.rjPanel3.PerformLayout();
            this.rjPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuanLyShipper.RJControls.RJPanel rjPanel1;
        private QuanLyShipper.RJControls.RJLogin rjLogin1;
        private QuanLyShipper.RJControls.RJLogin rjLogin2;
        private QuanLyShipper.RJControls.RJPanel rjPanel2;
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
        private QuanLyShipperDataSet quanLyShipperDataSet;
        private QuanLyShipper.RJControls.RJPanel rjPanel3;
        private QuanLyShipper.RJControls.RJLogin rjLogin11;
        private QuanLyShipper.RJControls.RJLogin rjLogin10;
        private QuanLyShipper.RJControls.RJLogin rjLogin9;
        private QuanLyShipper.RJControls.RJLogin rjLogin8;
        private QuanLyShipper.RJControls.RJLogin rjLogin7;
        private QuanLyShipper.RJControls.RJLogin rjLogin6;
        private QuanLyShipper.RJControls.RJLogin rjLogin5;
        private System.Windows.Forms.DateTimePicker ThoiDiemNhanHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyShipper.RJControls.RJTextBox TxtMaDon;
        private QuanLyShipper.RJControls.RJTextBox TxtGiaTri;
        private QuanLyShipper.RJControls.RJTextBox TxtLoaiHang;
        private QuanLyShipper.RJControls.RJTextBox TxtTenHang;
        private QuanLyShipper.RJControls.RJTextBox TxtDiaChiNhanHang;
        private QuanLyShipper.RJControls.RJTextBox TxtMaSP;
    }
}
