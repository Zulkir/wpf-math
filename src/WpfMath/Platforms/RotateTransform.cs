namespace WpfMath.Platforms
{
    public class RotateTransform : Transform
    {
        public double Angle { get; }

        public RotateTransform(double angle)
        {
            Angle = angle;
        }
    }
}
