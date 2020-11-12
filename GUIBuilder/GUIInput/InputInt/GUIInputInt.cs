namespace Altseed2
{
    public class GUIInputInt : GUIItem
    {   
        public int InputValue => _InputValue;
        private int _InputValue;

        protected override void OnUpdate()
        {
            Engine.Tool.InputInt(Label, ref _InputValue);
        }
    }
}