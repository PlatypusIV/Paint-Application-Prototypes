using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PaintAppTwo.Commands
{
    public static class DidgeriDoo
    {
        public static readonly RoutedUICommand SaveAs = new RoutedUICommand
            (
                "SaveAs",
                "SaveAs",
                typeof(DidgeriDoo),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.S,ModifierKeys.Control & ModifierKeys.Shift,"Ctrl + Shift + S")
                }
            );
    }
}
