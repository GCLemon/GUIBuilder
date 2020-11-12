using System.Collections.Generic;

namespace Altseed2
{
    public class GUIMenuBar : GUIItem
    {
        private readonly List<GUIItem> _GUIItems;

        public GUIMenuBar()
        {
            _GUIItems = new List<GUIItem>();
        }
        
        protected override void OnUpdate()
        {
            if(Engine.Tool.BeginMenuBar())
            {
                _GUIItems.ForEach(x => x.Update());
                Engine.Tool.EndMenuBar();
            }
        }

        public void AddGUIItem(GUIItem item)
        {
            _GUIItems.Add(item);
        }

        public void RemoveGUIItem(GUIItem item)
        {
            _GUIItems.Remove(item);
        }

        public void RemoveAllItems()
        {
            _GUIItems.Clear();
        }
    }
}