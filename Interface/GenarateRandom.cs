using System;

namespace Rhcodepi
{
    internal class GenarateRandom : IRandomizable
    {
        public float GetRandomNum(int upperBound)
        {
            Random r = new Random();
            float randomValue = r.NextSingle() * upperBound;
            return randomValue;
        }
    }
}