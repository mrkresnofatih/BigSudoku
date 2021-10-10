using Microsoft.AspNetCore.Mvc;

namespace BigSudoku.Services
{
    [NonController]
    public class SdkCreatorService: ControllerBase
    {
        public SdkCreatorService(){}

        public string buildSdkPuzzle()
        {
            int[,] puzzle = new int[9,9];
            for(int i=0; i<9; i++){
                for(int j=0; j<9; j++){
                    puzzle[i,j] = 3;
                }
            }
            return puzzle[2,3].ToString();
        }
    }
}