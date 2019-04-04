namespace WpfMath.Platforms
{
    public class TranslateTransform : Transform
    {
        public double X { get; }
        public double Y { get; }

        public TranslateTransform(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
