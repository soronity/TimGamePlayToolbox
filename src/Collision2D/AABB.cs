using UnityEngine;

namespace TimGameplay.Collision2D
{
    // Axis-aligned bounding box in 2D
    public struct AABB
    {
        public float MinX, MinY;
        public float MaxX, MaxY;

        public AABB(float minX, float minY, float maxX, float maxY)
        {
            MinX = minX;
            MinY = minY;
            MaxX = maxX;
            MaxY = maxY;
        }

        public Vector2 Center => new Vector2(
            (MinX + MaxX) * 0.5f,
            (MinY + MaxY) * 0.5f
        );
    }
}