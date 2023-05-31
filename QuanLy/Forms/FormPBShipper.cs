using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GoogleMapsApi.StaticMaps.Entities;

namespace FormMainMenu.Forms
{
    public partial class FormPBShipper : Form
    {
        private GMapControl gmap;

        public FormPBShipper()
        {
            InitializeComponent();
        }

        private void FormPBShipper_Load(object sender, EventArgs e)
        {
            // Khởi tạo Control GMap
            gmap = new GMapControl();

            // Cấu hình bản đồ
            gmap.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            // Lấy tọa độ của thành phố Hà Nội
            PointLatLng haNoi = new PointLatLng(21.0285, 105.8542);

            gmap.Position = haNoi; // Thiết lập tọa độ trung tâm ban đầu là Hà Nội
            gmap.MinZoom = 1;
            gmap.MaxZoom = 18;
            gmap.Zoom = 10; // Mở rộng bản đồ lên mức zoom 10

            // Thêm bản đồ vào Control Panel
            mapContainer.Controls.Add(gmap);
            gmap.Dock = DockStyle.Fill;

            // Sự kiện SizeChanged của mapContainer
            mapContainer.SizeChanged += (s, args) =>
            {
                gmap.Size = mapContainer.Size;
            };

            // Sự kiện click trên bản đồ
            gmap.OnMarkerClick += Gmap_OnMarkerClick;

            // Sự kiện thay đổi tọa độ trung tâm bản đồ
            gmap.OnPositionChanged += Gmap_OnPositionChanged;
        }

        // Xử lý sự kiện click trên bản đồ
        private void Gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            // Lấy thông tin về đánh dấu
            string markerLabel = item.ToolTipText;

            // Hiển thị thông tin đánh dấu
            MessageBox.Show($"Clicked marker: {markerLabel}");
        }

        // Xử lý sự kiện thay đổi tọa độ trung tâm bản đồ
        private void Gmap_OnPositionChanged(PointLatLng point)
        {
            // Lấy tọa độ trung tâm hiện tại
            double latitude = point.Lat;
            double longitude = point.Lng;

            // Cập nhật thông tin tọa độ trung tâm
            lblCenterCoordinates.Text = $"Center Coordinates: {latitude}, {longitude}";
        }

        // Sự kiện nút "Add Marker" - Thêm đánh dấu vào bản đồ
        // Sự kiện nút "Add Marker" - Thêm đánh dấu vào bản đồ
        private void btnAddMarker_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLatitude.Text, out double latitude) && double.TryParse(txtLongitude.Text, out double longitude))
            {
                string markerLabel = txtMarkerLabel.Text;

                // Tạo một overlay mới
                GMapOverlay markersOverlay = new GMapOverlay("markersOverlay");

                // Tạo một đánh dấu mới
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.red);
                marker.ToolTipText = markerLabel;

                // Thêm đánh dấu vào overlay
                markersOverlay.Markers.Add(marker);

                // Thêm overlay vào bản đồ
                gmap.Overlays.Add(markersOverlay);
            }
            else
            {
                MessageBox.Show("Giá trị kinh độ hoặc vĩ độ không hợp lệ. Vui lòng nhập các giá trị số hợp lệ.");
            }
        }


        // Sự kiện nút "Clear Markers" - Xóa tất cả đánh dấu trên bản đồ
        private void btnClearMarkers_Click(object sender, EventArgs e)
        {
            gmap.Overlays.Clear();
        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}