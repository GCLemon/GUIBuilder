using System;

namespace Altseed2
{
    public class GUIInputVector2F : GUIItem
    {   
        public Vector2F InputValue => _InputValue;
        private Vector2F _InputValue;

        protected override void OnUpdate()
        {
            float[] input = new float[2]
            {
                _InputValue.X,
                _InputValue.Y,
            };

            Engine.Tool.InputFloat2(Label, new Span<float>(input));

            _InputValue.X = input[0];
            _InputValue.Y = input[1];
        }
    }
}