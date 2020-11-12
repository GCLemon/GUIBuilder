namespace Altseed2
{
    public class GUIWindow : GUICollection
    {
        public ToolWindowFlags Flags { get; set; }

        protected override void OnUpdate()
        {
            if(Engine.Tool.Begin(Label, Flags))
            {
                _GUIItems.ForEach(x => x.Update());
                Engine.Tool.End();
            }
        }
    }
}