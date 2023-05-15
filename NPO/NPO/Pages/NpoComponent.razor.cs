using Microsoft.AspNetCore.Components;
using NPO.Model;

namespace NPO.Pages
{
    public partial class NpoComponent
    {
        [Parameter]public IEnumerable<CameraModel> Cameras { get; set; } = new List<CameraModel>();
        public List<CameraModel> Cam3 { get; set; } = new();
        public List<CameraModel> Cam5 { get; set; } = new();
        public List<CameraModel> Cam35 { get; set; } = new();
        public List<CameraModel> CamNo35 { get; set; } = new();


        protected override  void OnParametersSet()
        {

            if (Cameras != null)
            {
                foreach (CameraModel cam in Cameras)
                {
                    if (cam.CameraNumber % 3 == 0)
                    {
                        Cam3.Add(cam);
                    }
                    else if (cam.CameraNumber % 5 == 0)
                    {
                        Cam5.Add(cam);
                    }
                    else if (cam.CameraNumber % 5 == 0 && cam.CameraNumber % 3 == 0)
                    {
                        Cam35.Add(cam);
                    }
                    else if (cam.CameraNumber % 5 != 0 && cam.CameraNumber % 3 != 0)
                    {
                        CamNo35.Add(cam);
                    }
                }
            }
        }
    }
}
    

