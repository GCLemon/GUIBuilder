namespace Altseed2
{
    public class GUIInputTextWithHint : GUIItem
    {
        public int MaxLength { get; set; }
        public string Hint { get; set; }
        public ToolInputTextFlags Flags { get; set; }

        public string InputValue => _InputValue;
        protected string _InputValue;

        public GUIInputTextWithHint()
        {
            MaxLength = 32;
            Hint = "";
            Flags = ToolInputTextFlags.None;
            _InputValue = "";
        }

        protected override void OnUpdate()
        {
            string input = Engine.Tool.InputTextWithHint(Label, Hint, _InputValue, MaxLength, Flags);
            if(input != null) _InputValue = input;
        }
    }
}