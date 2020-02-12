using System.Linq;
using System.Text;

namespace DevCampAssignment
{
    public sealed class MMLogo : Logo
    {
        private char[][] _logo;

        public MMLogo(char character, char space, int width)
            : base(character, space, width)
        {
            _logo = MyMatrix(character, space, width);
        }

        private char[][] MyMatrix(in char character, in char space, in int width)
        {
            int rowsQuantity = width + 1;
            int colsQuantity = width * 5;

            char[][] firstM = new char[rowsQuantity][];

            for (int i = 0; i < firstM.GetLength(0); i++)
            {
                firstM[i] = new char[colsQuantity];
            }

            for (int row = 0; row < rowsQuantity; row++)
            {

                for (int col = 0; col < colsQuantity; col++)
                {

                    if (col > width - 1 - row && col <= width - 1 - row + width)
                    {
                        firstM[row][col] = character;
                    }
                    else if (col > width - 1 + row && col <= width - 1 + row + width)
                    {

                        firstM[row][col] = character;
                    }
                    else if (col > 3 * width - 1 - row && col <= 3 * width - 1 - row + width)
                    {

                        firstM[row][col] = character;
                    }
                    else if (col > 3 * width - 1 + row && col <= 3 * width - 1 + row + width)
                    {

                        firstM[row][col] = character;
                    }

                    else
                    {
                        firstM[row][col] = space;
                    }
                }

            }

            _logo = new char [rowsQuantity][];

            for (int i = 0; i < firstM.GetLength(0); i++)
            {
                _logo[i] = firstM[i].Concat(firstM[i]).ToArray();
            }
            return _logo;
        }

        public override string GetString()
        {
            var sb = new StringBuilder();
            foreach (var row in _logo)
            {
                sb.AppendLine(new string(row));
            }

            return sb.ToString().TrimEnd();
        }
    }
}




