using UnityEngine;

namespace TimGameplay.Core
{
    public static class FloatUtils
    {
        public const float Epsilon = 1e-5f;

        public static bool Approximately(float a, float b, float epsilon = Epsilon)
        {
            return Mathf.Abs(a - b) < epsilon;
        }
    }
}