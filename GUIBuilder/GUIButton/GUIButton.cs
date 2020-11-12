using System;

namespace Altseed2
{
    public class GUIButton : GUIItem
    {
        public bool IsClicked { get; private set; }
        
        protected override void OnUpdate()
        {
            IsClicked = Engine.Tool.Button(Label);
        }
    }
}