using System;

namespace Altseed2
{
    public class GUIButton : GUIItem
    {
        public event Action OnClicked
        {
            add { _OnClicked += value; }
            remove { _OnClicked -= value; }
        }
        private event Action _OnClicked;
        
        protected override void OnUpdate()
        {
            if(Engine.Tool.Button(Label))
                if(_OnClicked != null) _OnClicked();
        }
    }
}