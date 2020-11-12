using System;

namespace Altseed2
{
    public class GUIInputInt3 : GUIItem
    {
        public Vector3I InputValue => _InputValue;
        protected Vector3I _InputValue;

        protected override void OnUpdate()
        {
            int[] input = new int[3]
            {
                _InputValue.X,
                _InputValue.Y,
                _InputValue.Z,
            };

            Engine.Tool.InputInt3(Label, new Span<int>(input));

            _InputValue.X = input[0];
            _InputValue.Y = input[1];
            _InputValue.Z = input[2];
        }
    }
}