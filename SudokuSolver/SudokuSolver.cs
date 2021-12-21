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
                 { InitializeCell(row1Column1), InitializeCell(row1Column2), InitializeCell(row1Column3), InitializeCell(row1Column4), InitializeCell(row1Column5), InitializeCell(row1Column6), InitializeCell(row1Column7), InitializeCell(row1Column8), InitializeCell(row1Column9)},
                 { InitializeCell(row2Column1), InitializeCell(row2Column2), InitializeCell(row2Column3), InitializeCell(row2Column4), InitializeCell(row2Column5), InitializeCell(row2Column6), InitializeCell(row2Column7), InitializeCell(row2Column8), InitializeCell(row2Column9)},
                 { InitializeCell(row3Column1), InitializeCell(row3Column2), InitializeCell(row3Column3), InitializeCell(row3Column4), InitializeCell(row3Column5), InitializeCell(row3Column6), InitializeCell(row3Column7), InitializeCell(row3Column8), InitializeCell(row3Column9)},
                 { InitializeCell(row4Column1), InitializeCell(row4Column2), InitializeCell(row4Column3), InitializeCell(row4Column4), InitializeCell(row4Column5), InitializeCell(row4Column6), InitializeCell(row4Column7), InitializeCell(row4Column8), InitializeCell(row4Column9)},
                 { InitializeCell(row5Column1), InitializeCell(row5Column2), InitializeCell(row5Column3), InitializeCell(row5Column4), InitializeCell(row5Column5), InitializeCell(row5Column6), InitializeCell(row5Column7), InitializeCell(row5Column8), InitializeCell(row5Column9)},
                 { InitializeCell(row6Column1), InitializeCell(row6Column2), InitializeCell(row6Column3), InitializeCell(row6Column4), InitializeCell(row6Column5), InitializeCell(row6Column6), InitializeCell(row6Column7), InitializeCell(row6Column8), InitializeCell(row6Column9)},
                 { InitializeCell(row7Column1), InitializeCell(row7Column2), InitializeCell(row7Column3), InitializeCell(row7Column4), InitializeCell(row7Column5), InitializeCell(row7Column6), InitializeCell(row7Column7), InitializeCell(row7Column8), InitializeCell(row7Column9)},
                 { InitializeCell(row8Column1), InitializeCell(row8Column2), InitializeCell(row8Column3), InitializeCell(row8Column4), InitializeCell(row8Column5), InitializeCell(row8Column6), InitializeCell(row8Column7), InitializeCell(row8Column8), InitializeCell(row8Column9)},
                 { InitializeCell(row9Column1), InitializeCell(row9Column2), InitializeCell(row9Column3), InitializeCell(row9Column4), InitializeCell(row9Column5), InitializeCell(row9Column6), InitializeCell(row9Column7), InitializeCell(row9Column8), InitializeCell(row9Column9)}
            };

            TopLeft = new List<Cell>();
            TopMid = new List<Cell>();
            TopRight = new List<Cell>();
            MidLeft = new List<Cell>();
            Mid = new List<Cell>();
            MidRight = new List<Cell>();
            BottomLeft = new List<Cell>();
            BottomMid = new List<Cell>();
            BottomRight = new List<Cell>();

            TopLeft.Add(Grid[0, 0]);
            TopLeft.Add(Grid[0, 1]);
            TopLeft.Add(Grid[0, 2]);
            TopLeft.Add(Grid[1, 0]);
            TopLeft.Add(Grid[1, 1]);
            TopLeft.Add(Grid[1, 2]);
            TopLeft.Add(Grid[2, 0]);
            TopLeft.Add(Grid[2, 1]);
            TopLeft.Add(Grid[2, 2]);

            TopMid.Add(Grid[0, 3]);
            TopMid.Add(Grid[0, 4]);
            TopMid.Add(Grid[0, 5]);
            TopMid.Add(Grid[1, 3]);
            TopMid.Add(Grid[1, 4]);
            TopMid.Add(Grid[1, 5]);
            TopMid.Add(Grid[2, 3]);
            TopMid.Add(Grid[2, 4]);
            TopMid.Add(Grid[2, 5]);

            TopRight.Add(Grid[0, 6]);
            TopRight.Add(Grid[0, 7]);
            TopRight.Add(Grid[0, 8]);
            TopRight.Add(Grid[1, 6]);
            TopRight.Add(Grid[1, 7]);
            TopRight.Add(Grid[1, 8]);
            TopRight.Add(Grid[2, 6]);
            TopRight.Add(Grid[2, 7]);
            TopRight.Add(Grid[2, 8]);

            MidLeft.Add(Grid[3, 0]);
            MidLeft.Add(Grid[3, 1]);
            MidLeft.Add(Grid[3, 2]);
            MidLeft.Add(Grid[4, 0]);
            MidLeft.Add(Grid[4, 1]);
            MidLeft.Add(Grid[4, 2]);
            MidLeft.Add(Grid[5, 0]);
            MidLeft.Add(Grid[5, 1]);
            MidLeft.Add(Grid[5, 2]);

            Mid.Add(Grid[3, 3]);
            Mid.Add(Grid[3, 4]);
            Mid.Add(Grid[3, 5]);
            Mid.Add(Grid[4, 3]);
            Mid.Add(Grid[4, 4]);
            Mid.Add(Grid[4, 5]);
            Mid.Add(Grid[5, 3]);
            Mid.Add(Grid[5, 4]);
            Mid.Add(Grid[5, 5]);

            MidRight.Add(Grid[3, 6]);
            MidRight.Add(Grid[3, 7]);
            MidRight.Add(Grid[3, 8]);
            MidRight.Add(Grid[4, 6]);
            MidRight.Add(Grid[4, 7]);
            MidRight.Add(Grid[4, 8]);
            MidRight.Add(Grid[5, 6]);
            MidRight.Add(Grid[5, 7]);
            MidRight.Add(Grid[5, 8]);

            BottomLeft.Add(Grid[6, 0]);
            BottomLeft.Add(Grid[6, 1]);
            BottomLeft.Add(Grid[6, 2]);
            BottomLeft.Add(Grid[7, 0]);
            BottomLeft.Add(Grid[7, 1]);
            BottomLeft.Add(Grid[7, 2]);
            BottomLeft.Add(Grid[8, 0]);
            BottomLeft.Add(Grid[8, 1]);
            BottomLeft.Add(Grid[8, 2]);

            BottomMid.Add(Grid[6, 3]);
            BottomMid.Add(Grid[6, 4]);
            BottomMid.Add(Grid[6, 5]);
            BottomMid.Add(Grid[7, 3]);
            BottomMid.Add(Grid[7, 4]);
            BottomMid.Add(Grid[7, 5]);
            BottomMid.Add(Grid[8, 3]);
            BottomMid.Add(Grid[8, 4]);
            BottomMid.Add(Grid[8, 5]);

            BottomRight.Add(Grid[6, 6]);
            BottomRight.Add(Grid[6, 7]);
            BottomRight.Add(Grid[6, 8]);
            BottomRight.Add(Grid[7, 6]);
            BottomRight.Add(Grid[7, 7]);
            BottomRight.Add(Grid[7, 8]);
            BottomRight.Add(Grid[8, 6]);
            BottomRight.Add(Grid[8, 7]);
            BottomRight.Add(Grid[8, 8]);

        }

        /// <summary>
        /// Creates a cell given a number
        /// </summary>
        /// <param name="str">the number that will be placed in that cell</param>
        /// <returns>a cell with the given number. (The number will be 0 if the string is empty)</returns>
        private Cell InitializeCell(string str)
        {
            if (str.Length == 0)
            {
                return new Cell(0);
            }

            return new Cell(int.Parse(str));
        }

        /// <summary>
        /// Checks to see if the puzzle is 
        /// valid and slowly fills it in
        /// </summary>
        public void Solve()
        {
            PrintGrid();

            //check to see if the puzzle is valid
            if (!ValidPuzzle())
            {
                return;
            }

            FindPossibleNumbers();
        }

        /// <summary>
        /// Will find all possible numbers each cell could be
        /// </summary>
        private void FindPossibleNumbers()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    //no need to find possible numbers for non blank cells
                    if (Grid[row, column].Num != 0)
                    {
                        continue;
                    }

                    //check in each row, column, and category what numbers are missing
                    int[] rowArr = GetRow(row);
                    int[] colArr = GetColumn(column);
                    int[] catArr = GetCategory(FindCategory(row, column));

                    for (int target = 1; target < 10; target++)
                    {
                        if (TargetNum(rowArr, target) == 0)
                        {
                            Grid[row, column].PossibleNumbers.Add(target);
                        }

                        if (TargetNum(colArr, target) == 0)
                        {
                            Grid[row, column].PossibleNumbers.Add(target);
                        }

                        if (TargetNum(catArr, target) == 0)
                        {
                            Grid[row, column].PossibleNumbers.Add(target);
                        }
                    }

                    //make sure there are no duplicates
                    Grid[row, column].PossibleNumbers = Grid[row, column].PossibleNumbers.Distinct().ToList();
                }

            }
        }

        /// <summary>
        /// Tells if a puzzle has any mistakes
        /// </summary>
        /// <returns>false if an invalid move has been found</returns>
        private bool ValidPuzzle()
        {
            //a puzzle is invalid if:

            //there is a duplicate number in a row or column
            for (int i = 0; i < 9; i++)
            {
                if (!ValidSpace(GetRow(i)))
                {
                    return false;
                }

                if (!ValidSpace(GetColumn(i)))
                {
                    return false;
                }
            }

            //there is a duplicate number in a category
            if (!ValidSpace(GetCategory(TopLeft)))
            {
                return false;
            }

            if (!ValidSpace(GetCategory(TopMid)))
            {
                return false;
            }

            if (!ValidSpace(GetCategory(TopRight)))
            {
                return false;
            }

            if (!ValidSpace(GetCategory(MidLeft)))
            {
                return false;
            }

            if (!ValidSpace(GetCategory(Mid)))
            {
                return false;
            }

            if (!ValidSpace(GetCategory(MidRight)))
            {
                return false;
            }

            if (!ValidSpace(GetCategory(BottomLeft)))
            {
                return false;
            }

            if (!ValidSpace(GetCategory(BottomMid)))
            {
                return false;
            }

            if (!ValidSpace(GetCategory(BottomRight)))
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// Tells if an array of numbers is valid
        /// </summary>
        /// <param name="arr">the set of numbers that is being checked</param>
        /// <returns>false if there are any duplicate numbers between 1-9</returns>
        private bool ValidSpace(int[] arr)
        {
            if (TargetNum(arr, 1) > 1)
            {
                return false;
            }

            if (TargetNum(arr, 2) > 1)
            {
                return false;
            }

            if (TargetNum(arr, 3) > 1)
            {
                return false;
            }

            if (TargetNum(arr, 4) > 1)
            {
                return false;
            }

            if (TargetNum(arr, 5) > 1)
            {
                return false;
            }

            if (TargetNum(arr, 6) > 1)
            {
                return false;
            }

            if (TargetNum(arr, 7) > 1)
            {
                return false;
            }


            if (TargetNum(arr, 8) > 1)
            {
                return false;
            }

            if (TargetNum(arr, 9) > 1)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets an array of integers from a certain category
        /// </summary>
        /// <param name="cellCategory">the category that the numbers will be pulled from</param>
        /// <returns>An array of the number</returns>
        private int[] GetCategory(List<Cell> cellCategory)
        {
            List<int> numberCategory = new List<int>();

            foreach (Cell c in cellCategory)
            {
                numberCategory.Add(c.Num);
            }

            return numberCategory.ToArray();
        }

        /// <summary>
        ///  Tells which category a cell belongs to
        /// </summary>
        /// <param name="row">the row to the cell</param>
        /// <param name="column">the column to the cell</param>
        /// <returns></returns>
        private List<Cell> FindCategory(int row, int column)
        {
            if (TopLeft.IndexOf(Grid[row, column]) != -1)
            {
                return TopLeft;
            }

            if (TopMid.IndexOf(Grid[row, column]) != -1)
            {
                return TopMid;
            }

            if (TopRight.IndexOf(Grid[row, column]) != -1)
            {
                return TopRight;
            }

            if (MidLeft.IndexOf(Grid[row, column]) != -1)
            {
                return MidLeft;
            }

            if (Mid.IndexOf(Grid[row, column]) != -1)
            {
                return Mid;
            }

            if (MidRight.IndexOf(Grid[row, column]) != -1)
            {
                return MidRight;
            }

            if (BottomLeft.IndexOf(Grid[row, column]) != -1)
            {
                return BottomLeft;
            }

            if (BottomMid.IndexOf(Grid[row, column]) != -1)
            {
                return BottomMid;
            }

            return BottomRight;
        }

        /// <summary>
        /// Gets a row from the puzzle
        /// </summary>
        /// <param name="row">the row that will be gotten</param>
        /// <returns>An array of the number</returns>
        private int[] GetRow(int row)
        {
            return new int[] {Grid[row, 0].Num, Grid[row, 1].Num, Grid[row, 2].Num,
                              Grid[row, 3].Num, Grid[row, 4].Num, Grid[row, 5].Num,
                              Grid[row, 6].Num, Grid[row, 7].Num, Grid[row, 8].Num};
        }

        /// <summary>
        /// Gets a row in the puzzle
        /// </summary>
        /// <param name="column">the row that will be gotten</param>
        /// <returns>An array of the number</returns>
        private int[] GetColumn(int column)
        {
            return new int[] {Grid[0, column].Num, Grid[1, column].Num, Grid[2, column].Num,
                              Grid[3, column].Num, Grid[4, column].Num, Grid[5, column].Num,
                              Grid[6, column].Num, Grid[7, column].Num, Grid[8, column].Num };
        }

        /// <summary>
        /// Finds how many times a number is found in an array
        /// </summary>
        /// <param name="row">the array of numbers</param>
        /// <param name="target">the number we are looking for</param>
        /// <returns>the number of times target is found in an array</returns>
        private int TargetNum(int[] arr, int target)
        {
            int num = 0;

            foreach (int n in arr)
            {
                if (n == target)
                {
                    num++;
                }
            }

            return num;
        }

        
        /// <summary>
        /// Prints a representation of a grid with a 0 repersenting an emtpy cell
        /// </summary>
        private void PrintGrid()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (Grid[row, column].Num == 0)
                    {
                        Console.Write("- ");
                    }

                    else
                    { 
                        Console.Write(Grid[row, column].Num + " ");
                    }
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Represents a square on the puzzle
        /// </summary>
        public class Cell
        {
            public int Num { get; set; }

            //the possible numbers that can go in this cell
            public List<int> PossibleNumbers { get; set; }

            public Cell(int num)
            {
                Num = num;
                PossibleNumbers = new List<int>();
            }
        }
    }
}
