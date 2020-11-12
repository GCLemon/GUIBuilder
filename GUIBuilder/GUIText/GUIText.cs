namespace Altseed2
{
    public class GUIText : GUIItem
    {
        protected override void OnUpdate()
        {
            Engine.Tool.Text(Label);
        }
    }
}