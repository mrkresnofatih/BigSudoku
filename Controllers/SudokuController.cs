using Microsoft.AspNetCore.Mvc;
using BigSudoku.Services;

namespace BigSudoku.Controllers
{
    [Route("")]
    public class SudokuController    :   ControllerBase
    {
        private SdkCreatorService _sdkCreatorService;
        public SudokuController(SdkCreatorService sdkCreatorService)
        {
            _sdkCreatorService = sdkCreatorService;
        }

        [HttpGet("/")]
        public string helloWorld()
        {
            return _sdkCreatorService.buildSdkPuzzle();
        }
    }
}