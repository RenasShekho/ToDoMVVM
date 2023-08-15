using Avalonia.Controls;
using ToDoMVVM.ViewModels;

namespace ToDoMVVM.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}