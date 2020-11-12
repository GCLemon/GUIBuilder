namespace Altseed2
{
    public class GUIMenuBar : GUICollection
    {
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