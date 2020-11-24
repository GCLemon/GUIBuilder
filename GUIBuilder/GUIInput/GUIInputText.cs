namespace Altseed2
{
    public class GUIInputText : GUIItem
    {
        public ToolInputTextFlags Flags { get; set; }
        public int MaxLength { get; set; }
        public string Hint { get; set; }

        public string InputValue 
        {
            get => _InputValue;
            set => _InputValue = value;
        }
        protected string _InputValue;

        public GUIInputText()
        {
            Flags = ToolInputTextFlags.None;
            MaxLength = 32;
            Hint = "";
            _InputValue = "";
        }

        protected override void OnUpdate()
        {
            string input = (Hint != "")
                ? Engine.Tool.InputTextWithHint(Label, Hint, _InputValue, MaxLength, Flags)
                : Engine.Tool.InputText(Label, _InputValue, MaxLength, Flags);
            
            if(input != null) _InputValue = input;
        }
    }
}