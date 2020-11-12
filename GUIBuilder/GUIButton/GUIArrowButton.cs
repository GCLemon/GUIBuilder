using System;

namespace Altseed2
{
    public class GUIArrowButton : GUIItem
    {
        public ToolDir Driection { get; set; }

        public bool IsClicked { get; private set; }

        public GUIArrowButton()
        {
            Driection = ToolDir.None;
        }

        protected override void OnUpdate()
        {
            IsClicked = Engine.Tool.ArrowButton(Label, Driection);
        }
    }
}