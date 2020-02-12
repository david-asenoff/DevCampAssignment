using System;

namespace DevCampAssignment
{
    public abstract class Logo : ILogo
    {
        private int _width;
        private char _space;
        private char _character;

        public char Character
        {
            get => this._character;
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new Exception(Constants.InvalidSpace);
                }

                _character = value;
            }
        }

        public char Space
        {
            get => this._space;
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new Exception(Constants.InvalidSpace);
                }
                _space = value;
            }
            
        }

        public int Width
        {
            get => this._width;
            set
            {
                if (value % 1 != 0)
                {
                    throw new ArgumentException($"{Constants.InvalidWidthType}");
                }
                else if (value < Constants.LogoMinWidth && value >= Constants.LogoMaxWidth)
                {
                    throw new ArgumentException(Constants.InvalidWidthRange);
                }
                else if (value % 2 == 0)
                {
                    throw new ArgumentException($"{Constants.InvalidEvenWidth}");
                }

                _width = value;
            }
        }


        protected Logo(char character, char space, int width)
        {
            this.Character = character;
            this.Space = space;
            this.Width = width;
        }

        public abstract string GetString();
    }
}
