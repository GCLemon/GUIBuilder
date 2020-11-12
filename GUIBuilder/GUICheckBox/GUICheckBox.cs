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

        public bool IsClicked { get; private set; }

        protected override void OnUpdate()
        {
            IsClicked = Engine.Tool.CheckBox(Label, ref _IsChecked);
        }
    }
}