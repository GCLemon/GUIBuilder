using System;

namespace Altseed2
{
    public class GUIArrowButton : GUIItem
    {
        public ToolDir Driection { get; set; }

        public event Action OnClicked
        {
            add { _OnClicked += value; }
            remove { _OnClicked -= value; }
        }
        private event Action _OnClicked;

        public GUIArrowButton()
        {
            Driection = ToolDir.None;
        }

        protected override void OnUpdate()
        {
            if(Engine.Tool.ArrowButton(Label, Driection))
                if(_OnClicked != null) _OnClicked();
        }
    }
}