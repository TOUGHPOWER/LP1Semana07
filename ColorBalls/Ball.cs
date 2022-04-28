using System;

namespace ColorBalls
{
    public class Ball
    {
        private Color color;
        private float radius;
        private int numberOfTimesThrown;

        public Ball(Color thecolor, float theRadius)
        {
            color = thecolor;
            radius = theRadius;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if(radius > 0)
            {
                numberOfTimesThrown ++;
            }
        }

        public int GetNumberOfTimesThrown() => numberOfTimesThrown;
    }
}