using System;

namespace Altseed2
{
    public class GUIInputInt4 : GUIItem
    {
        public Vector4I InputValue => _InputValue;
        protected Vector4I _InputValue;

        protected override void OnUpdate()
        {
            int[] input = new int[4]
            {
                _InputValue.X,
                _InputValue.Y,
                _InputValue.Z,
                _InputValue.W,
            };

            Engine.Tool.InputInt4(Label, new Span<int>(input));

            _InputValue.X = input[0];
            _InputValue.Y = input[1];
            _InputValue.Z = input[2];
            _InputValue.W = input[3];
        }
    }
}