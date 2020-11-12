namespace Altseed2
{
    public class GUIMainMenuBar : GUICollection
    {
        protected override void OnUpdate()
        {
            if(Engine.Tool.BeginMainMenuBar())
            {
                _GUIItems.ForEach(x => x.Update());
                Engine.Tool.EndMainMenuBar();
            }
        }
    }
}