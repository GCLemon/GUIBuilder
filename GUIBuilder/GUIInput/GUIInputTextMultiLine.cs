namespace Altseed2
{
    public class GUIInputTextMultiLine : GUIItem
    {
        public ToolInputTextFlags Flags { get; set; }
        public int MaxLength { get; set; }
        public Vector2F Size { get; set; }

        public string InputValue 
        {
            get => _InputValue;
            set => _InputValue = value;
        }
        protected string _InputValue;

        public GUIInputTextMultiLine()
        {
            MaxLength = 128;
            Flags = ToolInputTextFlags.None;
            _InputValue = "";
        }

        protected override void OnUpdate()
        {
            string input = Engine.Tool.InputTextMultiline(Label, _InputValue, MaxLength, Size, Flags);
            if(input != null) _InputValue = input;
        }
    }
}