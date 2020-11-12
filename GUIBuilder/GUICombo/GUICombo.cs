using System.Collections.Generic;

namespace Altseed2
{
    class GUICombo : GUIItem
    {
        public int CurrentItem
        {
            get => _CurrentItem;
            set => _CurrentItem = value;
        }
        private int _CurrentItem;

        public int VisibleItems { get; set; }

        public List<string> Items { get; }

        public GUICombo()
        {
            Items = new List<string>();
        }

        protected override void OnUpdate()
        {
            string items = string.Join("\t", Items);
            Engine.Tool.Combo(Label, ref _CurrentItem, items, VisibleItems);
        }
    }
}