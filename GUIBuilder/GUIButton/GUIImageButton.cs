using System;

namespace Altseed2
{
    public class GUIImageButton : GUIItem
    {
        public Texture2D Image { get; set; }
        public Vector2F ButtonSize { get; set; }
        public Vector2F UV0 { get; set; }
        public Vector2F UV1 { get; set; }
        public Color TintColor { get; set; }
        public Color BorderColor { get; set; }
        public int FramePadding { get; set; }

        public event Action OnClicked
        {
            add { _OnClicked += value; }
            remove { _OnClicked -= value; }
        }
        private event Action _OnClicked;

        public GUIImageButton()
        {
            ButtonSize = new Vector2F(0, 0);
            UV0 =  new Vector2F(0, 0);
            UV1 =  new Vector2F(1, 1);
            TintColor = new Color(0, 0, 0, 0);
            BorderColor = new Color(255, 255, 255);
            FramePadding = 1;
        }
        
        protected override void OnUpdate()
        {
            if(Engine.Tool.ImageButton(Image, ButtonSize, UV0, UV1, FramePadding, TintColor, BorderColor))
                if(_OnClicked != null) _OnClicked();
        }
    }
}