using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class SudokuSolver
    {
        //Purpose: Solves and validates puzzles

        private Cell[,] Grid { get; }

        //All lists represent a 3x3 section in the puzzle
        private List<Cell> TopLeft { get; }
        private List<Cell> TopMid { get; }
        private List<Cell> TopRight { get; }
        private List<Cell> MidLeft { get; }
        private List<Cell> Mid { get; }
        private List<Cell> MidRight { get; }
        private List<Cell> BottomLeft { get; }
        private List<Cell> BottomMid { get; }
        private List<Cell> BottomRight { get; }

        public SudokuSolver(string row1Column1, string row1Column2, string row1Column3, string row1Column4, string row1Column5, string row1Column6, string row1Column7, string row1Column8, string row1Column9,
                            string row2Column1, string row2Column2, string row2Column3, string row2Column4, string row2Column5, string row2Column6, string row2Column7, string row2Column8, string row2Column9,
                            string row3Column1, string row3Column2, string row3Column3, string row3Column4, string row3Column5, string row3Column6, string row3Column7, string row3Column8, string row3Column9,
                            string row4Column1, string row4Column2, string row4Column3, string row4Column4, string row4Column5, string row4Column6, string row4Column7, string row4Column8, string row4Column9,
                            string row5Column1, string row5Column2, string row5Column3, string row5Column4, string row5Column5, string row5Column6, string row5Column7, string row5Column8, string row5Column9,
                            string row6Column1, string row6Column2, string row6Column3, string row6Column4, string row6Column5, string row6Column6, string row6Column7, string row6Column8, string row6Column9,
                            string row7Column1, string row7Column2, string row7Column3, string row7Column4, string row7Column5, string row7Column6, string row7Column7, string row7Column8, string row7Column9,
                            string row8Column1, string row8Column2, string row8Column3, string row8Column4, string row8Column5, string row8Column6, string row8Column7, string row8Column8, string row8Column9,
                            string row9Column1, string row9Column2, string row9Column3, string row9Column4, string row9Column5, string row9Column6, string row9Column7, string row9Column8, string row9Column9)
        {
            Grid = new Cell[,]
            {

            };
        }

        private bool ValidPuzzle()
        { 
            
        }

        /// <summary>
        /// Represents a square on the puzzle
        /// </summary>
        private class Cell
        {
            int num;

            public Cell(int num)
            {
                this.num = num;
            }
        }
    }
}
