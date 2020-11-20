namespace Altseed2
{
    public class GUIImage : GUIItem
    {
        public Texture2D Image { get; set; }
        public Vector2F ImageSize { get; set; }
        public Vector2F UV0 { get; set; }
        public Vector2F UV1 { get; set; }
        public Color TintColor { get; set; }
        public Color BorderColor { get; set; }

        protected override void OnUpdate()
        {
            Engine.Tool.Image(Image, ImageSize, UV0, UV1, TintColor, BorderColor);
        }
    }
}