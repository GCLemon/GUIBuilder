using System;

namespace Altseed2
{
    public class GUIInputVector2I : GUIItem
    {   
        public Vector2I InputValue => _InputValue;
        private Vector2I _InputValue;

        protected override void OnUpdate()
        {
            int[] input = new int[2]
            {
                _InputValue.X,
                _InputValue.Y,
            };

            Engine.Tool.InputInt2(Label, new Span<int>(input));

            _InputValue.X = input[0];
            _InputValue.Y = input[1];
        }
    }
}