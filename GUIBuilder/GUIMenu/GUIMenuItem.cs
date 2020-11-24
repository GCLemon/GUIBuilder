namespace Altseed2
{
    class GUIMenuItem : GUIItem
    {
        public string Shortcut { get; set; }
        public bool IsSelected { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsPressed { get; set; }

        public GUIMenuItem()
        {
            Shortcut = "";
            IsSelected = false;
            IsEnabled = true;
            IsPressed = false;
        }

        protected override void OnUpdate()
        {
            IsPressed = Engine.Tool.MenuItem(Label, Shortcut, IsSelected, IsEnabled);
        }
    }
}