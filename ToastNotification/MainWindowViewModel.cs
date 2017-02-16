using Prism.Mvvm;

namespace ToastNotification
{
    class MainWindowViewModel : BindableBase
    {

        int width = 200;
        public int Width { get { return width; } }

        int height = 300;
        public int Heignt { get { return height; } }

        public int LeftPostion
        {
            get
            {
                return (int)System.Windows.SystemParameters.PrimaryScreenWidth - Width;
            }
        }
        public int TopPostion
        {
            get
            {
                return (int)System.Windows.SystemParameters.PrimaryScreenHeight - Heignt;
            }
        }
    }
}
