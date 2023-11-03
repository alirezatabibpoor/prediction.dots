using System.Drawing;
using prediction.dots;


Point point1 = new Point(2,4);
Point point2 = new Point(3, 6);
Point point3 = new Point(4, 10);
predictiondots predictiondots = new predictiondots();
bool arecoliner = predictiondots.arecolliner(point1, point2, point3);
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => $"{point1},{point2},{point3}\n sloppe1 == {(point2.Y - point1.Y) / (point2.X - point1.X)} \n sloope2 == {(point3.Y - point2.Y) / (point3.X - point2.X)} \n are they collnear ?? \n {arecoliner}");


app.Run();