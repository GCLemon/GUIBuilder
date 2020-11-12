using System;

namespace Altseed2
{
    public class GUICheckBox : GUIItem
    {
        public bool IsChecked
        {
            get => _IsChecked;
            set => _IsChecked = value;
        }
        private bool _IsChecked;

        public event Action OnClicked
        {
            add { _OnClicked += value; }
            remove { _OnClicked -= value; }
        }
        private event Action _OnClicked;

        protected override void OnUpdate()
        {
            if(Engine.Tool.CheckBox(Label, ref _IsChecked))
                if(_OnClicked != null) _OnClicked();
        }
    }
}