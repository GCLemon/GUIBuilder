namespace Altseed2
{
    public class GUIInputTextMultiline : GUIItem
    {
        public int MaxLength { get; set; }
        public Vector2F Size { get; set; }
        public ToolInputTextFlags Flags { get; set; }
        
        public string InputValue => _InputValue;
        private string _InputValue;

        public GUIInputTextMultiline()
        {
            _InputValue = "";
        }

        protected override void OnUpdate()
        {
            string input = Engine.Tool.InputTextMultiline(Label, _InputValue, MaxLength, Size, Flags);
            if(input != null) _InputValue = input;
        }
    }
}