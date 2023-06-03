﻿namespace HoanThien.Forms
{
    partial class FormPBShipper
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjPanel1 = new QuanLyShipper.RJControls.RJPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMarkerLabel = new System.Windows.Forms.TextBox();
            this.btnClearMarkers = new QuanLyShipper.RJControls.RJLogin();
            this.PnlMaSP = new System.Windows.Forms.Panel();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblCenterCoordinates = new System.Windows.Forms.Label();
            this.mapContainer = new System.Windows.Forms.Panel();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btnAddMarker = new QuanLyShipper.RJControls.RJLogin();
            this.panel1.SuspendLayout();
            this.rjPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PnlMaSP.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mapContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.rjPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 571);
            this.panel1.TabIndex = 1;
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.rjPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.rjPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjPanel1.BorderRadius = 20;
            this.rjPanel1.BorderSize = 0;
            this.rjPanel1.Controls.Add(this.panel3);
            this.rjPanel1.Controls.Add(this.btnClearMarkers);
            this.rjPanel1.Controls.Add(this.PnlMaSP);
            this.rjPanel1.Controls.Add(this.panel2);
            this.rjPanel1.Controls.Add(this.lblCenterCoordinates);
            this.rjPanel1.Controls.Add(this.mapContainer);
            this.rjPanel1.Controls.Add(this.btnAddMarker);
            this.rjPanel1.ForeColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(-1, 3);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(966, 565);
            this.rjPanel1.TabIndex = 0;
            this.rjPanel1.TextColor = System.Drawing.Color.White;
            this.rjPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.rjPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.txtMarkerLabel);
            this.panel3.Location = new System.Drawing.Point(443, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel3.Size = new System.Drawing.Size(111, 26);
            this.panel3.TabIndex = 4;
            // 
            // txtMarkerLabel
            // 
            this.txtMarkerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMarkerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkerLabel.Location = new System.Drawing.Point(0, 0);
            this.txtMarkerLabel.Multiline = true;
            this.txtMarkerLabel.Name = "txtMarkerLabel";
            this.txtMarkerLabel.Size = new System.Drawing.Size(111, 23);
            this.txtMarkerLabel.TabIndex = 0;
            // 
            // btnClearMarkers
            // 
            this.btnClearMarkers.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClearMarkers.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClearMarkers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClearMarkers.BorderRadius = 10;
            this.btnClearMarkers.BorderSize = 0;
            this.btnClearMarkers.FlatAppearance.BorderSize = 0;
            this.btnClearMarkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMarkers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMarkers.ForeColor = System.Drawing.Color.White;
            this.btnClearMarkers.Location = new System.Drawing.Point(668, 224);
            this.btnClearMarkers.Name = "btnClearMarkers";
            this.btnClearMarkers.Size = new System.Drawing.Size(119, 32);
            this.btnClearMarkers.TabIndex = 9;
            this.btnClearMarkers.Text = "Xóa";
            this.btnClearMarkers.TextColor = System.Drawing.Color.White;
            this.btnClearMarkers.UseVisualStyleBackColor = false;
            this.btnClearMarkers.Click += new System.EventHandler(this.btnClearMarkers_Click);
            // 
            // PnlMaSP
            // 
            this.PnlMaSP.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlMaSP.Controls.Add(this.txtLatitude);
            this.PnlMaSP.Location = new System.Drawing.Point(69, 22);
            this.PnlMaSP.Margin = new System.Windows.Forms.Padding(0);
            this.PnlMaSP.Name = "PnlMaSP";
            this.PnlMaSP.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PnlMaSP.Size = new System.Drawing.Size(111, 26);
            this.PnlMaSP.TabIndex = 3;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLatitude.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.Location = new System.Drawing.Point(0, 0);
            this.txtLatitude.Multiline = true;
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(111, 23);
            this.txtLatitude.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.txtLongitude);
            this.panel2.Location = new System.Drawing.Point(261, 22);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel2.Size = new System.Drawing.Size(111, 26);
            this.panel2.TabIndex = 10;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLongitude.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitude.Location = new System.Drawing.Point(0, 0);
            this.txtLongitude.Multiline = true;
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(111, 23);
            this.txtLongitude.TabIndex = 0;
            // 
            // lblCenterCoordinates
            // 
            this.lblCenterCoordinates.AutoSize = true;
            this.lblCenterCoordinates.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenterCoordinates.Location = new System.Drawing.Point(664, 13);
            this.lblCenterCoordinates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCenterCoordinates.Name = "lblCenterCoordinates";
            this.lblCenterCoordinates.Size = new System.Drawing.Size(126, 19);
            this.lblCenterCoordinates.TabIndex = 8;
            this.lblCenterCoordinates.Text = "Tọa độ trung tâm";
            // 
            // mapContainer
            // 
            this.mapContainer.Controls.Add(this.gmap);
            this.mapContainer.Location = new System.Drawing.Point(22, 52);
            this.mapContainer.Margin = new System.Windows.Forms.Padding(2);
            this.mapContainer.Name = "mapContainer";
            this.mapContainer.Size = new System.Drawing.Size(575, 493);
            this.mapContainer.TabIndex = 7;
            this.mapContainer.SizeChanged += new System.EventHandler(this.FormPBShipper_Load);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(7, 127);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(514, 229);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 0D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.Gmap_OnMarkerClick);
            this.gmap.OnPositionChanged += new GMap.NET.PositionChanged(this.Gmap_OnPositionChanged);
            // 
            // btnAddMarker
            // 
            this.btnAddMarker.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddMarker.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddMarker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddMarker.BorderRadius = 10;
            this.btnAddMarker.BorderSize = 0;
            this.btnAddMarker.FlatAppearance.BorderSize = 0;
            this.btnAddMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMarker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMarker.ForeColor = System.Drawing.Color.White;
            this.btnAddMarker.Location = new System.Drawing.Point(668, 125);
            this.btnAddMarker.Name = "btnAddMarker";
            this.btnAddMarker.Size = new System.Drawing.Size(119, 32);
            this.btnAddMarker.TabIndex = 6;
            this.btnAddMarker.Text = "Thêm";
            this.btnAddMarker.TextColor = System.Drawing.Color.White;
            this.btnAddMarker.UseVisualStyleBackColor = false;
            this.btnAddMarker.Click += new System.EventHandler(this.btnAddMarker_Click);
            // 
            // FormPBShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 571);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPBShipper";
            this.Text = "Phân bổ Shipper";
            this.Load += new System.EventHandler(this.FormPBShipper_Load);
            this.panel1.ResumeLayout(false);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PnlMaSP.ResumeLayout(false);
            this.PnlMaSP.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mapContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QuanLyShipper.RJControls.RJPanel rjPanel1;
        private QuanLyShipper.RJControls.RJLogin btnAddMarker;
        private System.Windows.Forms.Panel mapContainer;
        private QuanLyShipper.RJControls.RJLogin btnClearMarkers;
        private System.Windows.Forms.Label lblCenterCoordinates;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMarkerLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Panel PnlMaSP;
        private System.Windows.Forms.TextBox txtLatitude;
        private GMap.NET.WindowsForms.GMapControl gmap;
    }
}