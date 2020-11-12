namespace Altseed2
{
    public class GUIInputText : GUIItem
    {
        public int MaxLength { get; set; }
        public ToolInputTextFlags Flags { get; set; }

        public string InputValue => _InputValue;
        protected string _InputValue;

        public GUIInputText()
        {
            MaxLength = 32;
            Flags = ToolInputTextFlags.None;
            _InputValue = "";
        }

        protected override void OnUpdate()
        {
            string input = Engine.Tool.InputText(Label, _InputValue, MaxLength, Flags);
            if(input != null) _InputValue = input;
        }
    }
}