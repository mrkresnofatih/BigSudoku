using System;
using BigSudoku.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigSudoku.Services
{
    [NonController]
    public class SdkCreatorService: ControllerBase
    {
        public SdkCreatorService(){}

        public string BuildSdkPuzzle()
        {
            var draft = new Draft();
            draft.PrintDraft();
            return "jsdlfkjsldkf";
        }
    }
}