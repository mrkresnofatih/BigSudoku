using System.Collections.Generic;

namespace BigSudoku.Models
{
    public class BlockOptions
    {
        private int _rowIndex;
        private int _colIndex;
        private List<int> _fillOptions;

        public BlockOptions(int rowIndex, int colIndex)
        {
            _rowIndex = rowIndex;
            _colIndex = colIndex;
            _fillOptions = new List<int>();
            for (int i = 1; i <= 9; i++)
            {
                _fillOptions.Add(i);
            }
        }

        public void RemoveOption(int option)
        {
            _fillOptions.Remove(option);
        }

        public List<int> GetFillOptions()
        {
            return _fillOptions;
        }

        public int GetRowIndex()
        {
            return _rowIndex;
        }

        public int GetColIndex()
        {
            return _colIndex;
        }
    }
}