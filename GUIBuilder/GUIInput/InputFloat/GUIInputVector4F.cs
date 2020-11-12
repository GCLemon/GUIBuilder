using System;

namespace Altseed2
{
    public class GUIInputFloat4 : GUIItem
    {
        public Vector4F InputValue => _InputValue;
        protected Vector4F _InputValue;

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