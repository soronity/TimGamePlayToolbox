using UnityEngine;

namespace TimGameplay.Physics2D
{
    public struct Body2D
    {
        public Vector2 Position;
        public Vector2 Velocity;

        public Body2D(Vector2 position)
        {
            Position = position;
            Velocity = Vector2.zero;
        }

        public void Integrate(float dt, Vector2 acceleration)
        {
            Velocity += acceleration * dt;
            Position += Velocity * dt;
        }
    }
}