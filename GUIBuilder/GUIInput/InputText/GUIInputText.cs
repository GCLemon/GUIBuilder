namespace Altseed2
{
    public class GUIInputText : GUIItem
    {
        public int MaxLength { get; set; }
        public string Hint { get; set; }
        public ToolInputTextFlags Flags { get; set; }
        
        public string InputValue => _InputValue;
        private string _InputValue;

        public GUIInputText()
        {
            _InputValue = "";
        }

        protected override void OnUpdate()
        {
            string input = null;

            if(Hint == null) input = Engine.Tool.InputText(Label, _InputValue, MaxLength, Flags);
            else input = Engine.Tool.InputTextWithHint(Label, Hint, _InputValue, MaxLength, Flags);

            if(input != null) _InputValue = input;
        }
    }
}