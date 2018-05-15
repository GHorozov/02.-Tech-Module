using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    public int Left { get; set; }
    public int Top { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int Bottom
    {
        get
        {
            return Top + Height;
        }
    }

    public int Right
    {
        get
        {
            return Left + Width;
        }
    }

    public bool IsInside(Rectangle rectangle)
    {
        var leftIsValid = rectangle.Left <= Left;
        var topIsValid = rectangle.Top <= Top;
        var rightIsValid = rectangle.Right >= Right;
        var bottomIsValid = rectangle.Bottom >= Bottom;

        return leftIsValid && topIsValid && rightIsValid && bottomIsValid;
    }
}

namespace RectanglePosition
{
    class RectanglePosition
    {
        static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();

            var result = firstRectangle.IsInside(secondRectangle);

            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
            
        }

        public static Rectangle ReadRectangle()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Rectangle
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            };
        }
    }
}
