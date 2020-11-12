using System;

namespace Altseed2
{
    class GUICombo<T> : GUIItem where T : Enum
    {
        public T CurrentItem { get; set; }
        public int VisibleItems { get; set; }

        private string _Items;

        public GUICombo()
        {
            _Items = String.Join("\t", (T[])Enum.GetValues(typeof(T)));
        }

        protected override void OnUpdate()
        {
            int item = (int)(object)CurrentItem;
            Engine.Tool.Combo(Label, ref item, _Items, VisibleItems);
            CurrentItem = (T)Enum.ToObject(typeof(T), item);
        }
    }
}