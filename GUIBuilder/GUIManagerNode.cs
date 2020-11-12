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

        public GUIItem GetItemsWithName(string name)
        {
            return _GUIItems.Find(x => x.Name == name);
        }

        public T GetItemsWithName<T>(string name) where T : GUIItem
        {
            return (T)_GUIItems.Find(x => x.Name == name);
        }

        public GUIItem GetItemWithAttr(string attr)
        {
            return _GUIItems.Find(x => x.Attr == attr);
        }

        public T GetItemsWithAttr<T>(string attr) where T : GUIItem
        {
            return (T)_GUIItems.Find(x => x.Attr == attr);
        }

        public GUIItem GetItemWithNameAttr(string name, string attr)
        {
            return _GUIItems.Find(x => x.Name == name && x.Attr == attr);
        }

        public T GetItemWithNameAttr<T>(string name, string attr) where T : GUIItem
        {
            return (T)_GUIItems.Find(x => x.Name == name && x.Attr == attr);
        }
    }
}