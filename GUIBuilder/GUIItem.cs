namespace Altseed2
{
    public class GUIItem
    {
        protected string Label => Name + (Attr == "" ? "" : ("###" + Attr));
        public string Name { get; set; }
        public string Attr { get; set; }

        public bool IsUpdated { get; set; }
        public bool IsSameLine { get; set; }

        public GUIItem()
        {
            Name = Attr = "";
            IsUpdated = true;
            IsSameLine = false;
        }

        internal void Update()
        {
            if(IsSameLine) Engine.Tool.SameLine();
            if(IsUpdated) OnUpdate();
        }

        protected virtual void OnUpdate()
        {
        }
    }
}