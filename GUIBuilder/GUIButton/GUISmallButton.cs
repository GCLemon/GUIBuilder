using System;

namespace Altseed2
{
    public class GUISmallButton : GUIItem
    {
        public bool IsClicked { get; private set; }
        
        protected override void OnUpdate()
        {
            IsClicked = Engine.Tool.SmallButton(Label);
        }
    }
}