namespace Altseed2
{
    public class GUICombo : GUIItem
    {
        public int CurrentItem
        {
            get => _CurrentItem;
            set => _CurrentItem = value;
        }
        private int _CurrentItem;

        public int VisibleItems { get; set; }

        public string[] Items { get; set; }

        protected override void OnUpdate()
        {
            string items = string.Join("\t", Items);
            Engine.Tool.Combo(Label, ref _CurrentItem, items, VisibleItems);
        }
    }
}