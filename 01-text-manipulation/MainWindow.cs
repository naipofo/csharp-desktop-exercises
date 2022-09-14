using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;
using System.Linq;
using System.Text;

namespace _01_text_manipulation
{
    class MainWindow : Window
    {
        [UI] private Entry _entryIn = null;
        [UI] private Entry _entryOut = null;
        [UI] private Button _button1 = null;
        [UI] private Button _button2 = null;
        [UI] private Button _button3 = null;

        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetRawOwnedObject("MainWindow"))
        {
            builder.Autoconnect(this);

            _button1.Clicked += bindTransformer((s) =>
            {
                return s + "_123";
            });

            _button2.Clicked += bindTransformer((s) =>
            {
                return new String(s.Reverse().ToArray());
            });

            _button3.Clicked += bindTransformer((s) =>
            {
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
            });

            DeleteEvent += Window_DeleteEvent;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private EventHandler bindTransformer(Func<String, String> transform)
        {
            return (sender, a) =>
            {
                _entryOut.Text = transform(_entryIn.Text);
            };
        }
    }
}
