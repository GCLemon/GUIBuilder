using System;

namespace Altseed2
{
    public class GUIInputFloat : GUIItem
    {
        public int ValueNum { get; set; }

        public float[] Values
        {
            get
            {
                float[] retArray = new float[ValueNum];
                Array.Copy(_Values, retArray, ValueNum);
                return retArray;
            }
        }
        private float[] _Values;

        public GUIInputFloat()
        {
            ValueNum = 4;
            _Values = new float[4];
        }

        protected override void OnUpdate()
        {
            switch(ValueNum)
            {
                case 1:
                    Engine.Tool.InputFloat(Label, ref _Values[0]);
                    break;
                
                case 2:
                    Engine.Tool.InputFloat2(Label, new Span<float>(_Values));
                    break;

                case 3:
                    Engine.Tool.InputFloat3(Label, new Span<float>(_Values));
                    break;

                case 4:
                    Engine.Tool.InputFloat4(Label, new Span<float>(_Values));
                    break;

                default:
                    throw new NotSupportedException();

            }
        }
    }
}