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

        public GUIItem GetItemWithName(string name)
        {
            return _GUIItems.Find(x => x.Name == name);
        }

        public T GetItemWithName<T>(string name) where T : GUIItem
        {
            return (T)_GUIItems.Find(x => x.Name == name);
        }

        public GUIItem GetItemWithAttr(string attr)
        {
            return _GUIItems.Find(x => x.Attr == attr);
        }

        public T GetItemWithAttr<T>(string attr) where T : GUIItem
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

        protected override void OnUpdate()
        {
            if(Engine.Tool.BeginMenuBar())
            {
                _GUIItems.ForEach(x => x.Update());
                Engine.Tool.EndMenuBar();
            }
        }
    }
}