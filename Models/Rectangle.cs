using Avalonia.Controls.Shapes;
using Avalonia.Controls;
using Avalonia.Media;

namespace Shapes_task2.Models;

public class Rectangle : Shape
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public override int Id { get; set; }
    public override string Name { get => "Rectangle"; }
    public override double Area => Width * Height;
    public override (double X, double Y) Position => (X, Y);

    
}