using System;

namespace Altseed2
{
    public class GUIInputVector3F : GUIItem
    {   
        public Vector3F InputValue => _InputValue;
        private Vector3F _InputValue;
        
        protected override void OnUpdate()
        {
            float[] input = new float[3]
            {
                _InputValue.X,
                _InputValue.Y,
                _InputValue.Z,
            };

            Engine.Tool.InputFloat3(Label, new Span<float>(input));

            _InputValue.X = input[0];
            _InputValue.Y = input[1];
            _InputValue.Z = input[2];
        }
    }
}