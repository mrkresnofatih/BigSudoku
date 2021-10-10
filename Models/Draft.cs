using System;
using System.Collections.Generic;

namespace BigSudoku.Models
{
    public class Draft
    {
        private List<BlockOptions> _listOfBlockOptions;

        public Draft()
        {
            _listOfBlockOptions = new List<BlockOptions>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    _listOfBlockOptions.Add(new BlockOptions(i, j));
                }
            }
        }

        public void PrintDraft()
        {
            foreach (var listOfBlockOption in _listOfBlockOptions)
            {
                var fillOptions = listOfBlockOption.GetFillOptions();
                foreach (var fillOption in fillOptions)
                {
                    Console.Write(fillOption+" ");
                }
                Console.WriteLine();
            }
        }

        public void RemoveOptionAtIndices(int rowIndex, int colIndex, int option)
        {
            var foundBlockOptions =
                _listOfBlockOptions
                    .Find(p => p.GetColIndex() == colIndex && p.GetRowIndex() == rowIndex);
            if (foundBlockOptions != null)
            {
                foundBlockOptions.RemoveOption(option);
            }
        }
    }
}