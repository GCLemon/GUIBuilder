namespace Altseed2
{
    public class GUIInputFloat : GUIItem
    {   
        public float InputValue => _InputValue;
        private float _InputValue;

        protected override void OnUpdate()
        {
            Engine.Tool.InputFloat(Label, ref _InputValue);
        }
    }
}