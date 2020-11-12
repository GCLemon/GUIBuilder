using System;

namespace Altseed2
{
    public class GUIRadioButton : GUIItem
    {
        public bool IsActive
        {
            get => _IsActive;
            set => _IsActive = value;
        }
        private bool _IsActive;

        public event Action OnClicked
        {
            add { _OnClicked += value; }
            remove { _OnClicked -= value; }
        }
        private event Action _OnClicked;

        protected override void OnUpdate()
        {
            if(Engine.Tool.RadioButton(Label, _IsActive))
            {
                if(_OnClicked != null) _OnClicked();
                _IsActive = !_IsActive;
            }
        }
    }
}