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

        public bool IsClicked { get; private set; }

        protected override void OnUpdate()
        {
            if(IsClicked = Engine.Tool.RadioButton(Label, _IsActive)) _IsActive = !_IsActive;
        }
    }
}