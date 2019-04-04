namespace WpfMath.Platforms
{
    public interface DrawingContext
    {
        void PushGuidelineSet(GuidelineSet guidelines);
        void PushTransform(Transform transform);
        void Pop();
        void DrawGlyphRun(Brush foregrBrush, GlyphRun glyphRun);
        void DrawRectangle(Brush foregrBrush, Pen pen, Rect scaledRectangle);
    }
}
