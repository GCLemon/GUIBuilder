using System.Collections.Generic;

namespace Altseed2
{
    public class GUIWindow : GUIItem
    {
        public ToolWindowFlags Flags { get; set; }

        private readonly List<GUIItem> _GUIItems;

        public GUIWindow()
        {
            _GUIItems = new List<GUIItem>();
        }

        protected override void OnUpdate()
        {
            if(Engine.Tool.Begin(Label, Flags))
            {
                _GUIItems.ForEach(x => x.Update());
                Engine.Tool.End();
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