using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Shapes_task2.Models;

public abstract class Shape
{
    public abstract int Id { get; set; }
    public abstract string Name { get;}
    public abstract double Area { get; }
    public abstract (double X, double Y) Position { get; }

    //public abstract bool overlaps_with(Shape other);
}