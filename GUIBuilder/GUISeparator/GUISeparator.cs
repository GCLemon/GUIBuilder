namespace Altseed2
{
    public class GUISeparator : GUIItem
    {
        protected override void OnUpdate()
        {
            Engine.Tool.Separator();
        }
    }
}