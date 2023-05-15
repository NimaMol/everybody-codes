namespace CamerasApi
{
    public class CameraModel
    {
        public CameraModel(int cameraNumber, string cameraName, string lat, string lon)
        {
            CameraNumber = cameraNumber;
            CameraName = cameraName;
            this.lat = lat;
            this.lon = lon;
        }

        public int CameraNumber { get; set; }
        public string CameraName { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
    }
}
