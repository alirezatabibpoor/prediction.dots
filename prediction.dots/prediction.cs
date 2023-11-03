using System.Drawing;

namespace prediction.dots
{
    public class predictiondots
    {
        public bool arecolliner(Point p1 , Point p2 ,Point p3)
        {
            double slope1=(p2.Y-p1.Y)/(p2.X-p1.X);
            double slope2 = (p3.Y - p2.Y) / (p3.X - p2.X);
            return slope1 == slope2;
        }
    }
}
