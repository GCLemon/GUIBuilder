using System.Collections.Generic;

namespace Altseed2
{
    public class GUIMainMenuBar : GUIItem
    {
        private readonly List<GUIItem> _GUIItems;

        public GUIMainMenuBar()
        {
            _GUIItems = new List<GUIItem>();
        }

        protected override void OnUpdate()
        {
            if(Engine.Tool.BeginMainMenuBar())
            {
                _GUIItems.ForEach(x => x.Update());
                Engine.Tool.EndMainMenuBar();
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