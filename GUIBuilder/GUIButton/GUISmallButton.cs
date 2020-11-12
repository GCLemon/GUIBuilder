using System;

namespace Altseed2
{
    public class GUISmallButton : GUIItem
    {
        public event Action OnClicked
        {
            add { _OnClicked += value; }
            remove { _OnClicked -= value; }
        }
        private event Action _OnClicked;
        
        protected override void OnUpdate()
        {
            if(Engine.Tool.SmallButton(Label))
                if(_OnClicked != null) _OnClicked();
        }
    }
}