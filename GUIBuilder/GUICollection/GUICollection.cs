using System.Collections.Generic;

namespace Altseed2
{
    public abstract class GUICollection : GUIItem
    {
        protected readonly List<GUIItem> _GUIItems;
        
        public GUICollection()
        {
            _GUIItems = new List<GUIItem>();
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

        public GUIItem GetItemsWithName(string name)
        {
            return _GUIItems.Find(x => x.Name == name);
        }

        public GUIItem GetItemWithAttr(string attr)
        {
            return _GUIItems.Find(x => x.Attr == attr);
        }

        public GUIItem GetItemWithNameAttr(string name, string attr)
        {
            return _GUIItems.Find(x => x.Name == name && x.Attr == attr);
        }
    }
}