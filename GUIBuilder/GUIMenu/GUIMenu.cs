using System.Collections.Generic;

namespace Altseed2
{
    public class GUIMenu : GUIItem
    {
        private readonly List<GUIMenuItem> _GUIItems;

        public GUIMenu()
        {
            _GUIItems = new List<GUIMenuItem>();
        }
        
        public void AddGUIItem(GUIMenuItem item)
        {
            _GUIItems.Add(item);
        }

        public void RemoveGUIItem(GUIMenuItem item)
        {
            _GUIItems.Remove(item);
        }

        public void RemoveAllItems()
        {
            _GUIItems.Clear();
        }

        public GUIMenuItem GetItemWithName(string name)
        {
            return _GUIItems.Find(x => x.Name == name);
        }

        public GUIMenuItem GetItemWithAttr(string attr)
        {
            return _GUIItems.Find(x => x.Attr == attr);
        }

        public GUIMenuItem GetItemWithNameAttr(string name, string attr)
        {
            return _GUIItems.Find(x => x.Name == name && x.Attr == attr);
        }

        protected override void OnUpdate()
        {
            if(Engine.Tool.BeginMenu(Label, true))
            {
                foreach(GUIMenuItem item in _GUIItems) item.Update();
                Engine.Tool.EndMenu();
            }
            else
            {
                foreach(GUIMenuItem item in _GUIItems) item.IsPressed = false;
            }
        }
    }
}