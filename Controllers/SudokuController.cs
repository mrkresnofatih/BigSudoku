using Microsoft.AspNetCore.Mvc;
using BigSudoku.Services;

namespace BigSudoku.Controllers
{
    [Route("")]
    public class SudokuController    :   ControllerBase
    {
        private readonly SdkCreatorService _sdkCreatorService;
        public SudokuController(SdkCreatorService sdkCreatorService)
        {
            _sdkCreatorService = sdkCreatorService;
        }

        [HttpGet("/")]
        public string HelloWorld()
        {
            return _sdkCreatorService.BuildSdkPuzzle();
        }
    }
}