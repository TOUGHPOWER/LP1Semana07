using System;

namespace ColorBalls
{
    public class Color
    {
        private readonly int redColorValue;
        private readonly int greenColorValue;
        private readonly int blueColorValue;
        private readonly int alphaValue;
        

        public Color(int theRedValue, int theGreenValue, int theBlueValue, int theAlphaValue)
        {
            redColorValue = theRedValue;
            greenColorValue = theGreenValue;
            blueColorValue = theBlueValue;
            alphaValue = theAlphaValue;
        }

        public Color(int theRedValue, int theGreenValue, int theBlueValue)
        {
            redColorValue = theRedValue;
            greenColorValue = theGreenValue;
            blueColorValue = theBlueValue;
            alphaValue = 255;
        } 

        public int GetRedValue() => redColorValue;

        

        public int GetGreenValue() => greenColorValue;

        

        public int GetBlueValue() => blueColorValue;

        

        public int GetAlphaValue() => alphaValue;

        

        public int GetGreyScale() => (redColorValue + greenColorValue + blueColorValue)/3;

    }
}