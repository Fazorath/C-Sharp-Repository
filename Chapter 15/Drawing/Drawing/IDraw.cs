using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    interface IDraw
    {
<<<<<<< HEAD
        int X { get; set; }
        int Y { get; set; }

=======
        void SetLocation(int xCoord, int yCoord);
>>>>>>> be353c7c1611cd35d0c6f7ced1cdc27ec52ca5a8
        void Draw(Canvas canvas);
    }
}
