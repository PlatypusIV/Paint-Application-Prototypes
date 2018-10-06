using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaintAppTwo.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int newBrushSize = 0;
        int newEraserSize = 0;

        bool tempColorBool = false;

        bool erasing = false;
        //bool undoing = false;

        Image imageToCanvas;

        Image imageOnCanvasDuringRunTime;

        public MainWindow()
        {
            InitializeComponent();
            ColorPickerUC.Visibility = Visibility.Collapsed;
            //MainCanvasAttribute.Color = ColorPickerUC.RGBColor;

            mainCanvas.Height = 480;
            mainCanvas.Width = 600;
            MainCanvasAttribute.Color = Color.FromRgb((byte)ColorPickerUC.RSlider.Value, (byte)ColorPickerUC.GSlider.Value, (byte)ColorPickerUC.BSlider.Value);

        }


        private void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
            //e.CanExecute = false;
            
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (mainCanvas.Children.Count == 0)
            {
                LoadImageIntoInkCanvas();
            }
            else
            {
                try
                {
                    switch (MessageBox.Show("There is already an image loaded into the program! Are you sure you want to replace it?",
                        "PaintAppTwo", MessageBoxButton.YesNo, MessageBoxImage.Exclamation, MessageBoxResult.No))
                    {
                        case MessageBoxResult.Yes:
                            LoadImageIntoInkCanvas();
                            break;
                        case MessageBoxResult.No:
                            break;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Something went wrong!" +
                        $"{exc.ToString()}");
                }
            }
        }

        public void LoadImageIntoInkCanvas()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files |*.jpg;*.png;*.jpeg;*.bmp";
            mainCanvas.Strokes.Clear();

            if (dialog.ShowDialog() != null && dialog.FileName != "")
            {
                mainCanvas.Children.Clear();
                imageToCanvas = new Image();
                BitmapImage bitmapImageToCanvas = new BitmapImage(new Uri(dialog.FileName, UriKind.RelativeOrAbsolute));

                imageToCanvas.Source = bitmapImageToCanvas;
                imageToCanvas.Width = mainCanvas.ActualWidth;
                imageToCanvas.Height = mainCanvas.ActualHeight;

                mainCanvas.Children.Add(imageToCanvas);

                //mainCanvas.Background = new ImageBrush(bitmapImageToCanvas);
            }
        }

        private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Save_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Jpg file (*.jpg)|*.jpg|Png file (*.png)|*.png|Jpeg file (*.jpeg)|*.jpeg|BMP file (*.BMP)|*.BMP";
            if(saveFile.ShowDialog() == true && saveFile.FileName != "")
            {
                using(FileStream fileStream = new FileStream(saveFile.FileName,FileMode.Create))
                using (MemoryStream memStream = new MemoryStream())
                {
                    int marginBottom = (int)mainCanvas.Margin.Bottom;
                    int marginTop = (int)mainCanvas.Margin.Top;
                    int marginLeft = (int)mainCanvas.Margin.Left;
                    int marginRight = (int)mainCanvas.Margin.Right;

                    int width = (int)mainCanvas.ActualWidth - marginLeft - marginRight;
                    int height = (int)mainCanvas.ActualHeight - marginTop - marginBottom;

                    Rectangle backgroundRectangle;

                    RenderTargetBitmap targetBitmap =
                        new RenderTargetBitmap(width, height, 96d, 96d, PixelFormats.Default);

                    if (mainCanvas.Children.Count < 1)
                    {
                        mainCanvas.Background = new SolidColorBrush(Colors.White);
                    }
                    else
                    {
                        mainCanvas.Background = new SolidColorBrush(Colors.Transparent);
                        backgroundRectangle = new Rectangle
                        {
                            Width = mainCanvas.ActualWidth,
                            Height = mainCanvas.ActualHeight,
                            Fill = new SolidColorBrush(Colors.Transparent)
                        };
                        targetBitmap.Render(backgroundRectangle);
                    }
                    
                    targetBitmap.Render(mainCanvas);

                    BitmapEncoder encoder = new BmpBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(targetBitmap));

                    encoder.Save(memStream);
                    memStream.WriteTo(fileStream);

                    mainCanvas.Background = new SolidColorBrush(Colors.White);
                }
            }
        }

        private void brushSizeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if(brushSizeTextBox.Text != "")
                {
                    newBrushSize = Convert.ToInt32(brushSizeTextBox.Text);

                    MainCanvasAttribute.Height = newBrushSize;
                    MainCanvasAttribute.Width = newBrushSize;
                }
                else
                {
                    newBrushSize = 3;
                    MainCanvasAttribute.Height = newBrushSize;
                    MainCanvasAttribute.Width = newBrushSize;
                }
                

            } catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
                newBrushSize = 3;

                MainCanvasAttribute.Height = newBrushSize;
                MainCanvasAttribute.Width = newBrushSize;
            }
              
        }

        private void colorBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (tempColorBool)
                {
                    case false:
                        if (ColorPickerUC.Visibility == Visibility.Collapsed)
                        {
                            ColorPickerUC.Visibility = Visibility.Visible;
                            tempColorBool = true;
                        }
                        break;
                    case true:
                        if (ColorPickerUC.Visibility == Visibility.Visible)
                        {
                            ColorPickerUC.Visibility = Visibility.Collapsed;
                            tempColorBool = false;
                        }
                        break;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show($"Error:{exc.ToString()}");
            }          
        }

        private void ColorPickerUC_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!erasing)
            {
                MainCanvasAttribute.Color = Color.FromRgb((byte)ColorPickerUC.RSlider.Value, (byte)ColorPickerUC.GSlider.Value, (byte)ColorPickerUC.BSlider.Value);
            }
            
        }

        private void XSizeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if(PictureSizeXTextBox.Text != "")
                {
                    
                    mainCanvas.Width = Convert.ToInt32(PictureSizeXTextBox.Text);
                    if (imageToCanvas != null)
                    {
                        imageToCanvas.Width = Convert.ToInt32(PictureSizeXTextBox.Text);
                    }
                }
            }catch (Exception exc)
            {
                MessageBox.Show("Please insert a proper number into the TextBox!\n" +
                    $"{exc.ToString()}");

                
                mainCanvas.Width = 600;

                if (imageToCanvas != null)
                {
                    imageToCanvas.Width = 600;
                }
            }
        }

        private void YSizeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if ( PictureSizeYTextBox.Text != "")
                {
                    mainCanvas.Height = Convert.ToInt32(PictureSizeYTextBox.Text);
                    if (imageToCanvas != null)
                    {
                        imageToCanvas.Height = Convert.ToInt32(PictureSizeYTextBox.Text);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Please insert a proper number into the TextBox!");

                mainCanvas.Height = 500;
                if (imageToCanvas != null)
                {
                    imageToCanvas.Width = 500;
                }
            }
        }

        //private void eraserBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!undoing)
        //    {
        //        mainCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        //        eraserBtn.Background = new SolidColorBrush(Color.FromRgb((byte)255, (byte)0, (byte)0));
        //        eraserBtn.Content = "UNDOING!";
        //        undoing = true;
        //        if (erasing)
        //        {
        //            erasing = false;
        //        }
        //    }
        //    else
        //    {
        //        mainCanvas.EditingMode = InkCanvasEditingMode.Ink;
        //        eraserBtn.Background = new SolidColorBrush(Colors.AliceBlue);
        //        eraserBtn.Content = "DRAWING!";            
        //        undoing = false;
        //    }
        //}

        private void eraserBtnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (!erasing)
            {
                MainCanvasAttribute.Color = Color.FromRgb((byte)255, (byte)255, (byte)255);
                //MainCanvasAttribute.Color = Colors.Transparent;

                eraserBtnTwo.Background = new SolidColorBrush(Color.FromRgb((byte)255, (byte)0, (byte)0));
                eraserBtnTwo.Content = "ERASING!";
                if(newEraserSize > 0)
                {
                    MainCanvasAttribute.Width = newEraserSize;
                    MainCanvasAttribute.Height = newEraserSize;
                }
                else
                {
                    MainCanvasAttribute.Width = 6;
                    MainCanvasAttribute.Height = 6;
                }


                erasing = true;
            }
            else
            {
                MainCanvasAttribute.Color = Color.FromRgb((byte)ColorPickerUC.RSlider.Value, (byte)ColorPickerUC.GSlider.Value, (byte)ColorPickerUC.BSlider.Value);
                eraserBtnTwo.Background = new SolidColorBrush(Colors.AliceBlue);
                eraserBtnTwo.Content = "DRAWING!";
                if(newBrushSize > 0)
                {
                    MainCanvasAttribute.Width = newBrushSize;
                    MainCanvasAttribute.Height = newBrushSize;
                }
                else
                {
                    MainCanvasAttribute.Width = 3;
                    MainCanvasAttribute.Height = 3;
                }
                erasing = false;
            }
        }

        private void eraserSizeTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (eraserSizeTxtBox.Text != "")
                {
                    newEraserSize = Convert.ToInt32(eraserSizeTxtBox.Text);
                    //mainCanvas.EraserShape = new RectangleStylusShape(newEraserSize, newEraserSize);

                    MainCanvasAttribute.Width = newEraserSize;
                    MainCanvasAttribute.Height = newEraserSize;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Please enter a proper integer into the text box!" +
                    $"{exc.ToString()}");

                newEraserSize = 6;
                MainCanvasAttribute.Width = newEraserSize;
                MainCanvasAttribute.Height = newEraserSize;

                //mainCanvas.EraserShape = new RectangleStylusShape(newEraserSize, newEraserSize);
            }            
        }
    }
}
