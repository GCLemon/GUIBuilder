using System;

namespace Altseed2
{
    public class GUIInputVector4F : GUIItem
    {   
        public Vector4F InputValue => _InputValue;
        private Vector4F _InputValue;
        
        protected override void OnUpdate()
        {
            float[] input = new float[4]
            {
                _InputValue.X,
                _InputValue.Y,
                _InputValue.Z,
                _InputValue.W,
            };

            Engine.Tool.InputFloat4(Label, new Span<float>(input));

            _InputValue.X = input[0];
            _InputValue.Y = input[1];
            _InputValue.Z = input[2];
            _InputValue.W = input[3];
        }
    }
}