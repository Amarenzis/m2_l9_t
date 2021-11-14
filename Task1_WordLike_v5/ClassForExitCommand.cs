using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task1_WordLike_v4
{
    class ClassForExitCommand
    {
        public static RoutedUICommand Exit { get; set; }

        static ClassForExitCommand()
        {
            InputGestureCollection input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.E, ModifierKeys.Alt, "Alt+E"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(ClassForExitCommand), input);
        }
    }
}
