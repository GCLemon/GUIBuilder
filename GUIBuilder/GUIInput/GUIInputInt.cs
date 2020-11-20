using System;

namespace Altseed2
{
    public class GUIInputInt : GUIItem
    {
        public int ValueNum { get; set; }

        public int[] Values
        {
            get
            {
                int[] retArray = new int[ValueNum];
                Array.Copy(_Values, retArray, ValueNum);
                return retArray;
            }
        }
        private int[] _Values;

        public GUIInputInt()
        {
            ValueNum = 4;
            _Values = new int[4];
        }

        protected override void OnUpdate()
        {
            switch(ValueNum)
            {
                case 1:
                    Engine.Tool.InputInt(Label, ref _Values[0]);
                    break;
                
                case 2:
                    Engine.Tool.InputInt2(Label, new Span<int>(_Values));
                    break;

                case 3:
                    Engine.Tool.InputInt3(Label, new Span<int>(_Values));
                    break;

                case 4:
                    Engine.Tool.InputInt4(Label, new Span<int>(_Values));
                    break;

                default:
                    throw new NotSupportedException();

            }
        }
    }
}