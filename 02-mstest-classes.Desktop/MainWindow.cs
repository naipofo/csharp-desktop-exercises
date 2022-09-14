using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;
using _02_mstest_classes.Core;

namespace _02_mstest_classes.Desktop
{
    class MainWindow : Window
    {
        [UI] private Entry _entryIn = null;
        [UI] private Label _label1 = null;
        [UI] private Button _button1 = null;
        [UI] private Button _button2 = null;

        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetRawOwnedObject("MainWindow"))
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;

            attachManipulator(_button1, new SuffixStringManipulator());
            attachManipulator(_button2, new ReverseStringManipulator());
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void attachManipulator(Button trigger, IStringManipulator manipulator){
            trigger.Clicked += (_,_) => {
                _label1.Text = manipulator.Manipulate(_entryIn.Text);
            };
        }
    }
}
