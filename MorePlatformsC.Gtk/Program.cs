using System;
using Gtk;
using Xamarin.Forms.Platform.GTK;
using Xamarin.Forms;
using Application = Gtk.Application;

namespace MorePlatformsC.Gtk
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("More Platforms");
            window.Show();

            Application.Run();
        }
    }
}
