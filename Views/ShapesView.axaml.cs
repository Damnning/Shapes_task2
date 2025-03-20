using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Shapes_task2.ViewModels;

namespace Shapes_task2.Views
{
    public partial class ShapesView : Window
    {
        public ShapesView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            //Resources.Add("ShapeToVisualConverter", new ShapeToVisualConverter());
            AvaloniaXamlLoader.Load(this);
        }
    }
}