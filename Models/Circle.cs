using System;
using System.Diagnostics;


namespace Shapes_task2.Models;

public class Circle : Shape
{
    
    public double X { get; set; }
    public double Y { get; set; }
    public double Radius { get; set; }
    
    public override int Id { get; set; }
    public override string Name { get => "Circle"; }
    public override double Area => Math.PI * Radius * Radius;
    public override (double X, double Y) Position => (X, Y);
    
}