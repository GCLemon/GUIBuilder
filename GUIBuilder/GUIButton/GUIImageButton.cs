namespace Altseed2
{
    public class GUIImageButton : GUIItem
    {
        public Texture2D Image { get; set; }
        public Vector2F ImageSize { get; set; }
        public Vector2F UV0 { get; set; }
        public Vector2F UV1 { get; set; }
        public Color TintColor { get; set; }
        public Color BorderColor { get; set; }
        public int FramePadding { get; set; }
        
        public bool IsClicked { get; protected set; }

        public GUIImageButton()
        {
            ImageSize = new Vector2F(0, 0);
            UV0 =  new Vector2F(0, 0);
            UV1 =  new Vector2F(1, 1);
            TintColor = new Color(0, 0, 0, 0);
            BorderColor = new Color(255, 255, 255);
            FramePadding = 1;
        }
        
        protected override void OnUpdate()
        {
            IsClicked = Engine.Tool.ImageButton(Image, ImageSize, UV0, UV1, FramePadding, TintColor, BorderColor);
        }
    }
}