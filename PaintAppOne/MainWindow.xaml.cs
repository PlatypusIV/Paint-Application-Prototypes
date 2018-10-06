using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaintAppOne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private enum MyShape
        {
            Line,Ellipse,Rectangle
        }

        private MyShape _currentShape = MyShape.Line;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lineBtn_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = MyShape.Line;
        }

        private void ellipseBtn_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = MyShape.Ellipse;
        }

        private void rectBtn_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = MyShape.Rectangle;
        }

        Point _start;
        Point _end;

        private void myCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _start = e.GetPosition(this);
        }

        private void myCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            switch (_currentShape)
            {
                case MyShape.Line:
                    DrawLine();
                    break;
                case MyShape.Ellipse:
                    DrawEllipse();
                    break;
                case MyShape.Rectangle:
                    DrawRectangle();
                    break;
                default:
                    return;

            }
        }

        private void myCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                _end = e.GetPosition(this);
            }
        }

        private void DrawLine()
        {
            Line newLine = new Line()
            {
                Stroke = Brushes.Blue,
                X1 = _start.X,
                Y1 = _start.Y - 50,
                X2 = _end.X,
                Y2 = _end.Y - 50,

            };

            myCanvas.Children.Add(newLine);
        }

        private void DrawEllipse()
        {
            Ellipse newEllipse = new Ellipse()
            {
                Stroke = Brushes.Black,
                Fill = Brushes.Crimson,
                StrokeThickness = 3,
                Height = 10,
                Width = 10,


                

            };

            if(_end.X >= _start.X)
            {
                newEllipse.SetValue(Canvas.LeftProperty, _start.X);
                newEllipse.Width = _end.X - _start.X;
            }
            else
            {
                newEllipse.SetValue(Canvas.LeftProperty, _end.X);
                newEllipse.Width = _start.X - _end.X;
            }

            if (_end.Y >= _start.Y)
            {
                newEllipse.SetValue(Canvas.TopProperty, _start.Y);
                newEllipse.Height = _end.Y - _start.Y;
            }
            else
            {
                newEllipse.SetValue(Canvas.TopProperty, _end.Y - 50);
                newEllipse.Height = _start.Y - _end.Y;
            }



            myCanvas.Children.Add(newEllipse);
        }

        private void DrawRectangle()
        {
            Rectangle newRectangle = new Rectangle()
            {
                Stroke = Brushes.Black,
                Fill = Brushes.Crimson,
                StrokeThickness = 3,
            };

            if (_end.X >= _start.X)
            {
                newRectangle.SetValue(Canvas.LeftProperty, _start.X);
                newRectangle.Width = _end.X - _start.X;
            }
            else
            {
                newRectangle.SetValue(Canvas.LeftProperty, _end.X);
                newRectangle.Width = _start.X - _end.X;
            }

            if (_end.Y >= _start.Y)
            {
                newRectangle.SetValue(Canvas.TopProperty, _start.Y);
                newRectangle.Height = _end.Y - _start.Y;
            }
            else
            {
                newRectangle.SetValue(Canvas.TopProperty, _end.Y - 50);
                newRectangle.Height = _start.Y - _end.Y;
            }

            myCanvas.Children.Add(newRectangle);
        }
    }
}
