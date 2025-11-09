namespace TimGameplay.Collision2D
{
    public static class Overlap2D
    {
        public static bool AABBvsAABB(AABB a, AABB b)
        {
            if (a.MaxX < b.MinX || a.MinX > b.MaxX) return false;
            if (a.MaxY < b.MinY || a.MinY > b.MaxY) return false;
            return true;
        }
    }
}