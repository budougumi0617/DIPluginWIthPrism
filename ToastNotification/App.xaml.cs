using System.Windows;

namespace ToastNotification
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var mw = new MainWindow();
            var vm = mw.DataContext as MainWindowViewModel;
            mw.Top = vm.TopPostion;
            mw.Left = vm.LeftPostion;
            mw.Width = vm.Width;
            mw.Height = vm.Heignt;
            mw.Show();
        }

    }
}
