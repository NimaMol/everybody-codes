using CamerasApi;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using NPO.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NPO.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CameraApi : ControllerBase
    {
        private readonly DataService _dataService;
        public CameraApi(DataService dataService)
        {
            _dataService = dataService; 
        }

        [HttpGet]
        [Route("GetAll")]
        public List<CameraModel> GetAllCameras()
        {
                var cam = _dataService.ReadCsv("Data\\cameras-defb.csv");
                return cam;

        }

    }
}
