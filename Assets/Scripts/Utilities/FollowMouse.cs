using UnityEngine;

namespace Utilities
{
    public class FollowMouse : MonoBehaviour
    {
        [SerializeField] private Vector2 offset;

        private void Update()
        {
            Follow();
        }

        private void Follow()
        {
            transform.position = new Vector3(Input.mousePosition.x + offset.x, Input.mousePosition.y + offset.y, transform.position.z);
        }
    }
}