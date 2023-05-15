using Microsoft.AspNetCore.Components;
using NPO.Model;

namespace NPO.Pages
{
    public partial class MapComponent
    {
        [Parameter] public IEnumerable<CameraModel> Cameras { get; set; } = new List<CameraModel>();

        int zoom = 10;




    }
}
