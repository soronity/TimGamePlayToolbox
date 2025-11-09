using UnityEngine;
using TimGameplay.Collision2D;

namespace TimGameplay.UnityGlue
{
    public class ShapeDebugger2D : MonoBehaviour
    {
        public Vector2 halfSize = new Vector2(0.5f, 0.5f);
        public Color gizmoColor = Color.yellow;

        private void OnDrawGizmos()
        {
            var pos = (Vector2)transform.position;
            var aabb = new AABB(pos.x - halfSize.x, pos.y - halfSize.y, pos.x + halfSize.x, pos.y + halfSize.y);
            Gizmos.color = gizmoColor;
            Gizmos.DrawWireCube(aabb.Center, new Vector3(halfSize.x * 2, halfSize.y * 2, 0f));
        }
    }
}