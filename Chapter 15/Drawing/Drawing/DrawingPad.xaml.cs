using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Drawing
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void drawingCanvas_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Point mouseLocation = e.GetPosition(this.drawingCanvas);
            Square mySquare = new Square(100);

            if (mySquare is IDraw)
            {
                IDraw drawSquare = mySquare;
<<<<<<< HEAD
                drawSquare.X = (int)mouseLocation.X;
                drawSquare.Y = (int)mouseLocation.Y;
                drawSquare.Draw(drawingCanvas);
            }


            if (mySquare is IColor)
            {
                IColor colorSquare = mySquare;
                colorSquare.Color = Colors.BlueViolet;

=======
                drawSquare.SetLocation((int)mouseLocation.X, (int)mouseLocation.Y);
                drawSquare.Draw(drawingCanvas);
            }

            if (mySquare is IColor)
            {
                IColor colorSquare = mySquare;
                colorSquare.SetColor(Colors.BlueViolet);
>>>>>>> be353c7c1611cd35d0c6f7ced1cdc27ec52ca5a8
            }
        }

        private void drawingCanvas_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            Point mouseLocation = e.GetPosition(this.drawingCanvas);
            Circle myCircle = new Circle(100);

            if (myCircle is IDraw)
            {
                IDraw drawCircle = myCircle;
<<<<<<< HEAD
                drawCircle.X = (int)mouseLocation.X;
                drawCircle.Y = (int)mouseLocation.Y;
                drawCircle.Draw(drawingCanvas);

=======
                drawCircle.SetLocation((int)mouseLocation.X, (int)mouseLocation.Y);
                drawCircle.Draw(drawingCanvas);
>>>>>>> be353c7c1611cd35d0c6f7ced1cdc27ec52ca5a8
            }

            if (myCircle is IColor)
            {
                IColor colorCircle = myCircle;
<<<<<<< HEAD
                colorCircle.Color = Colors.HotPink;
=======
                colorCircle.SetColor(Colors.HotPink);
>>>>>>> be353c7c1611cd35d0c6f7ced1cdc27ec52ca5a8
            }
        }
    }
}
