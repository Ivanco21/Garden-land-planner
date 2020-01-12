using System.Windows;
using WpfClientForm.VM;

namespace WpfClientForm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // в дальнейшем нужно будет задавать DataContext извне
            // то для удобства тестирования и понимания концепций оставляем здесь
            DataContext = new MainVM();
        }
    }
}
