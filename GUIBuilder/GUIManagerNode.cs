using System.Collections.Generic;

namespace Altseed2
{
    public class GUIManagerNode : Node
    {
        protected readonly List<GUIItem> _GUIItems;

        public GUIManagerNode()
        {
            _GUIItems = new List<GUIItem>();
        }

        protected override void OnUpdate()
        {
            _GUIItems.ForEach(x => x.Update());
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