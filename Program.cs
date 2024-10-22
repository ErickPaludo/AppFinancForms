using GastosForms.MVC.Controller;
using GastosForms.MVC.Models;

namespace GastosForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ViewHome view = new ViewHome();
            view.Visible = false;
            HomeModel model = new HomeModel();
            HomeController controller = new HomeController(view,model);
            view.ShowDialog();
        }
    }
}