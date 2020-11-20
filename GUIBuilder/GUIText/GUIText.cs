namespace Altseed2
{
    public enum GUITextMode
    {
        Normal,
        Colored,
        Disabled,
    }

    public class GUIText : GUIItem
    {
        public GUITextMode Mode { get; set; }
        public Color Color { get; set; }

        protected override void OnUpdate()
        {
            switch(Mode)
            {
                case GUITextMode.Normal:
                    Engine.Tool.Text(Label);
                    break;

                case GUITextMode.Colored:
                    Engine.Tool.TextColored(Color, Label);
                    break;

                case GUITextMode.Disabled:
                    Engine.Tool.TextDisabled(Label);
                    break;
            }
        }
    }
}