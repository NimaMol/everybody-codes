using Microsoft.AspNetCore.Components;
using NPO.Model;
using NPO.Service;

namespace NPO.Pages
{
    public partial class Index
    {
        [Inject] private ICameraService CameraService { get; set; }
        public IEnumerable<CameraModel>? Cameras { get; set; }
        protected override async Task OnInitializedAsync()
        {

            Cameras = await CameraService.GetAllCamerasAsync();


        }
    }
}
