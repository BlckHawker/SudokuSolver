using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class SudokuSolverForm : Form
    {
        public SudokuSolverForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string row1Column1 = Row1Column1TextBox.Text;
            string row1Column2 = Row1Column2TextBox.Text;
            string row1Column3 = Row1Column3TextBox.Text;
            string row1Column4 = Row1Column4TextBox.Text;
            string row1Column5 = Row1Column5TextBox.Text;
            string row1Column6 = Row1Column6TextBox.Text;
            string row1Column7 = Row1Column7TextBox.Text;
            string row1Column8 = Row1Column8TextBox.Text;
            string row1Column9 = Row1Column9TextBox.Text;

            string row2Column1 = Row2Column1TextBox.Text;
            string row2Column2 = Row2Column2TextBox.Text;
            string row2Column3 = Row2Column3TextBox.Text;
            string row2Column4 = Row2Column4TextBox.Text;
            string row2Column5 = Row2Column5TextBox.Text;
            string row2Column6 = Row2Column6TextBox.Text;
            string row2Column7 = Row2Column7TextBox.Text;
            string row2Column8 = Row2Column8TextBox.Text;
            string row2Column9 = Row2Column9TextBox.Text;

            string row3Column1 = Row3Column1TextBox.Text;
            string row3Column2 = Row3Column2TextBox.Text;
            string row3Column3 = Row3Column3TextBox.Text;
            string row3Column4 = Row3Column4TextBox.Text;
            string row3Column5 = Row3Column5TextBox.Text;
            string row3Column6 = Row3Column6TextBox.Text;
            string row3Column7 = Row3Column7TextBox.Text;
            string row3Column8 = Row3Column8TextBox.Text;
            string row3Column9 = Row3Column9TextBox.Text;

            string row4Column1 = Row4Column1TextBox.Text;
            string row4Column2 = Row4Column2TextBox.Text;
            string row4Column3 = Row4Column3TextBox.Text;
            string row4Column4 = Row4Column4TextBox.Text;
            string row4Column5 = Row4Column5TextBox.Text;
            string row4Column6 = Row4Column6TextBox.Text;
            string row4Column7 = Row4Column7TextBox.Text;
            string row4Column8 = Row4Column8TextBox.Text;
            string row4Column9 = Row4Column9TextBox.Text;

            string row5Column1 = Row5Column1TextBox.Text;
            string row5Column2 = Row5Column2TextBox.Text;
            string row5Column3 = Row5Column3TextBox.Text;
            string row5Column4 = Row5Column4TextBox.Text;
            string row5Column5 = Row5Column5TextBox.Text;
            string row5Column6 = Row5Column6TextBox.Text;
            string row5Column7 = Row5Column7TextBox.Text;
            string row5Column8 = Row5Column8TextBox.Text;
            string row5Column9 = Row5Column9TextBox.Text;

            string row6Column1 = Row6Column1TextBox.Text;
            string row6Column2 = Row6Column2TextBox.Text;
            string row6Column3 = Row6Column3TextBox.Text;
            string row6Column4 = Row6Column4TextBox.Text;
            string row6Column5 = Row6Column5TextBox.Text;
            string row6Column6 = Row6Column6TextBox.Text;
            string row6Column7 = Row6Column7TextBox.Text;
            string row6Column8 = Row6Column8TextBox.Text;
            string row6Column9 = Row6Column9TextBox.Text;

            string row7Column1 = Row7Column1TextBox.Text;
            string row7Column2 = Row7Column2TextBox.Text;
            string row7Column3 = Row7Column3TextBox.Text;
            string row7Column4 = Row7Column4TextBox.Text;
            string row7Column5 = Row7Column5TextBox.Text;
            string row7Column6 = Row7Column6TextBox.Text;
            string row7Column7 = Row7Column7TextBox.Text;
            string row7Column8 = Row7Column8TextBox.Text;
            string row7Column9 = Row7Column9TextBox.Text;

            string row8Column1 = Row8Column1TextBox.Text;
            string row8Column2 = Row8Column2TextBox.Text;
            string row8Column3 = Row8Column3TextBox.Text;
            string row8Column4 = Row8Column4TextBox.Text;
            string row8Column5 = Row8Column5TextBox.Text;
            string row8Column6 = Row8Column6TextBox.Text;
            string row8Column7 = Row8Column7TextBox.Text;
            string row8Column8 = Row8Column8TextBox.Text;
            string row8Column9 = Row8Column9TextBox.Text;

            string row9Column1 = Row9Column1TextBox.Text;
            string row9Column2 = Row9Column2TextBox.Text;
            string row9Column3 = Row9Column3TextBox.Text;
            string row9Column4 = Row9Column4TextBox.Text;
            string row9Column5 = Row9Column5TextBox.Text;
            string row9Column6 = Row9Column6TextBox.Text;
            string row9Column7 = Row9Column7TextBox.Text;
            string row9Column8 = Row9Column8TextBox.Text;
            string row9Column9 = Row9Column9TextBox.Text;

            //make sure there is only one character in each string
            if(!(OneChar(row1Column1) && OneChar(row1Column2) && OneChar(row1Column3) && OneChar(row1Column4) && OneChar(row1Column5) && OneChar(row1Column6) && OneChar(row1Column7) && OneChar(row1Column8) && OneChar(row1Column9) &&
                 OneChar(row2Column1) && OneChar(row2Column2) && OneChar(row2Column3) && OneChar(row2Column4) && OneChar(row2Column5) && OneChar(row2Column6) && OneChar(row2Column7) && OneChar(row2Column8) && OneChar(row2Column9) &&
                 OneChar(row3Column1) && OneChar(row3Column2) && OneChar(row3Column3) && OneChar(row3Column4) && OneChar(row3Column5) && OneChar(row3Column6) && OneChar(row3Column7) && OneChar(row3Column8) && OneChar(row3Column9) &&
                 OneChar(row4Column1) && OneChar(row4Column2) && OneChar(row4Column3) && OneChar(row4Column4) && OneChar(row4Column5) && OneChar(row4Column6) && OneChar(row4Column7) && OneChar(row4Column8) && OneChar(row4Column9) &&
                 OneChar(row5Column1) && OneChar(row5Column2) && OneChar(row5Column3) && OneChar(row5Column4) && OneChar(row5Column5) && OneChar(row5Column6) && OneChar(row5Column7) && OneChar(row5Column8) && OneChar(row5Column9) &&
                 OneChar(row6Column1) && OneChar(row6Column2) && OneChar(row6Column3) && OneChar(row6Column4) && OneChar(row6Column5) && OneChar(row6Column6) && OneChar(row6Column7) && OneChar(row6Column8) && OneChar(row6Column9) &&
                 OneChar(row7Column1) && OneChar(row7Column2) && OneChar(row7Column3) && OneChar(row7Column4) && OneChar(row7Column5) && OneChar(row7Column6) && OneChar(row7Column7) && OneChar(row7Column8) && OneChar(row7Column9) &&
                 OneChar(row8Column1) && OneChar(row8Column2) && OneChar(row8Column3) && OneChar(row8Column4) && OneChar(row8Column5) && OneChar(row8Column6) && OneChar(row8Column7) && OneChar(row8Column8) && OneChar(row8Column9) &&
                 OneChar(row9Column1) && OneChar(row9Column2) && OneChar(row9Column3) && OneChar(row9Column4) && OneChar(row9Column5) && OneChar(row9Column6) && OneChar(row9Column7) && OneChar(row9Column8) && OneChar(row9Column9)))
            {
                MessageBox.Show("Text boxes can only have one character", "Unable to solve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //make sure each textbox only has numbers
            if (!(OneChar(row1Column1) && OneChar(row1Column2) && OneChar(row1Column3) && OneChar(row1Column4) && OneChar(row1Column5) && OneChar(row1Column6) && OneChar(row1Column7) && OneChar(row1Column8) && OneChar(row1Column9) &&
                  OneChar(row2Column1) && OneChar(row2Column2) && OneChar(row2Column3) && OneChar(row2Column4) && OneChar(row2Column5) && OneChar(row2Column6) && OneChar(row2Column7) && OneChar(row2Column8) && OneChar(row2Column9) &&
                  OneChar(row3Column1) && OneChar(row3Column2) && OneChar(row3Column3) && OneChar(row3Column4) && OneChar(row3Column5) && OneChar(row3Column6) && OneChar(row3Column7) && OneChar(row3Column8) && OneChar(row3Column9) &&
                  OneChar(row4Column1) && OneChar(row4Column2) && OneChar(row4Column3) && OneChar(row4Column4) && OneChar(row4Column5) && OneChar(row4Column6) && OneChar(row4Column7) && OneChar(row4Column8) && OneChar(row4Column9) &&
                  OneChar(row5Column1) && OneChar(row5Column2) && OneChar(row5Column3) && OneChar(row5Column4) && OneChar(row5Column5) && OneChar(row5Column6) && OneChar(row5Column7) && OneChar(row5Column8) && OneChar(row5Column9) &&
                  OneChar(row6Column1) && OneChar(row6Column2) && OneChar(row6Column3) && OneChar(row6Column4) && OneChar(row6Column5) && OneChar(row6Column6) && OneChar(row6Column7) && OneChar(row6Column8) && OneChar(row6Column9) &&
                  OneChar(row7Column1) && OneChar(row7Column2) && OneChar(row7Column3) && OneChar(row7Column4) && OneChar(row7Column5) && OneChar(row7Column6) && OneChar(row7Column7) && OneChar(row7Column8) && OneChar(row7Column9) &&
                  OneChar(row8Column1) && OneChar(row8Column2) && OneChar(row8Column3) && OneChar(row8Column4) && OneChar(row8Column5) && OneChar(row8Column6) && OneChar(row8Column7) && OneChar(row8Column8) && OneChar(row8Column9) &&
                  OneChar(row9Column1) && OneChar(row9Column2) && OneChar(row9Column3) && OneChar(row9Column4) && OneChar(row9Column5) && OneChar(row9Column6) && OneChar(row9Column7) && OneChar(row9Column8) && OneChar(row9Column9)))
            {
                MessageBox.Show("Text boxes can only have one character", "Unable to solve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(NumberOnly(row1Column1) && NumberOnly(row1Column2) && NumberOnly(row1Column3) && NumberOnly(row1Column4) && NumberOnly(row1Column5) && NumberOnly(row1Column6) && NumberOnly(row1Column7) && NumberOnly(row1Column8) && NumberOnly(row1Column9) &&
                  NumberOnly(row2Column1) && NumberOnly(row2Column2) && NumberOnly(row2Column3) && NumberOnly(row2Column4) && NumberOnly(row2Column5) && NumberOnly(row2Column6) && NumberOnly(row2Column7) && NumberOnly(row2Column8) && NumberOnly(row2Column9) &&
                  NumberOnly(row3Column1) && NumberOnly(row3Column2) && NumberOnly(row3Column3) && NumberOnly(row3Column4) && NumberOnly(row3Column5) && NumberOnly(row3Column6) && NumberOnly(row3Column7) && NumberOnly(row3Column8) && NumberOnly(row3Column9) &&
                  NumberOnly(row4Column1) && NumberOnly(row4Column2) && NumberOnly(row4Column3) && NumberOnly(row4Column4) && NumberOnly(row4Column5) && NumberOnly(row4Column6) && NumberOnly(row4Column7) && NumberOnly(row4Column8) && NumberOnly(row4Column9) &&
                  NumberOnly(row5Column1) && NumberOnly(row5Column2) && NumberOnly(row5Column3) && NumberOnly(row5Column4) && NumberOnly(row5Column5) && NumberOnly(row5Column6) && NumberOnly(row5Column7) && NumberOnly(row5Column8) && NumberOnly(row5Column9) &&
                  NumberOnly(row6Column1) && NumberOnly(row6Column2) && NumberOnly(row6Column3) && NumberOnly(row6Column4) && NumberOnly(row6Column5) && NumberOnly(row6Column6) && NumberOnly(row6Column7) && NumberOnly(row6Column8) && NumberOnly(row6Column9) &&
                  NumberOnly(row7Column1) && NumberOnly(row7Column2) && NumberOnly(row7Column3) && NumberOnly(row7Column4) && NumberOnly(row7Column5) && NumberOnly(row7Column6) && NumberOnly(row7Column7) && NumberOnly(row7Column8) && NumberOnly(row7Column9) &&
                  NumberOnly(row8Column1) && NumberOnly(row8Column2) && NumberOnly(row8Column3) && NumberOnly(row8Column4) && NumberOnly(row8Column5) && NumberOnly(row8Column6) && NumberOnly(row8Column7) && NumberOnly(row8Column8) && NumberOnly(row8Column9) &&
                  NumberOnly(row9Column1) && NumberOnly(row9Column2) && NumberOnly(row9Column3) && NumberOnly(row9Column4) && NumberOnly(row9Column5) && NumberOnly(row9Column6) && NumberOnly(row9Column7) && NumberOnly(row9Column8) && NumberOnly(row9Column9)))
            {
                MessageBox.Show("Text boxes can only be numbers", "Unable to solve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SudokuSolver solver = new SudokuSolver(
                row1Column1, row1Column2, row1Column3, row1Column4, row1Column5, row1Column6, row1Column7, row1Column8, row1Column9,
                row2Column1, row2Column2, row2Column3, row2Column4, row2Column5, row2Column6, row2Column7, row2Column8, row2Column9,
                row3Column1, row3Column2, row3Column3, row3Column4, row3Column5, row3Column6, row3Column7, row3Column8, row3Column9,
                row4Column1, row4Column2, row4Column3, row4Column4, row4Column5, row4Column6, row4Column7, row4Column8, row4Column9,
                row5Column1, row5Column2, row5Column3, row5Column4, row5Column5, row5Column6, row5Column7, row5Column8, row5Column9,
                row6Column1, row6Column2, row6Column3, row6Column4, row6Column5, row6Column6, row6Column7, row6Column8, row6Column9,
                row7Column1, row7Column2, row7Column3, row7Column4, row7Column5, row7Column6, row7Column7, row7Column8, row7Column9,
                row8Column1, row8Column2, row8Column3, row8Column4, row8Column5, row8Column6, row8Column7, row8Column8, row8Column9,
                row9Column1, row9Column2, row9Column3, row9Column4, row9Column5, row9Column6, row9Column7, row9Column8, row9Column9);


        }

        /// <summary>
        /// Tells if a string contains one character or less
        /// </summary>
        /// <param name="str">the str that will be checked</param>
        /// <returns>true if there at most one character in the string</returns>
        private bool OneChar(string str)
        {
            return str.Length <= 1;
        }

        /// <summary>
        /// Tells if string is a number
        /// </summary>
        /// <param name="str">the str that will be checked</param>
        /// <returns>true if the string is a number between 1 and 9</returns>
        private bool NumberOnly(string str)
        {
            return str == "" ||(str[0] >= 49 && str[0] <= 57);
        }
    }
}
