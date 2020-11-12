using System.Collections.Generic;

namespace Altseed2
{
    public class GUIGroup : GUICollection
    {
        protected override void OnUpdate()
        {
            Engine.Tool.BeginGroup();
            _GUIItems.ForEach(x => x.Update());
            Engine.Tool.EndGroup();
        }
    }
}