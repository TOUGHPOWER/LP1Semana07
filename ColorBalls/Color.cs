using System;

namespace ColorBalls
{
    public class Color
    {
        private int redColorValue;
        private int greenColorValue;
        private int blueColorValue;
        private int alphaValue;
        

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

        public int SetRedValue(int theRedValue) => redColorValue = theRedValue;

        public int GetGreenValue() => greenColorValue;

        public int SetGreenValue(int theGreenValue) => greenColorValue = theGreenValue;

        public int GetBlueValue() => blueColorValue;

        public int SetBlueValue(int theBlueValue) => blueColorValue = theBlueValue;

        public int GetAlphaValue() => alphaValue;

        public int SetAlphaValue(int theAlphaValue) => alphaValue = theAlphaValue;

        public int GetGreyScale() => (redColorValue + greenColorValue + blueColorValue)/3;

    }
}