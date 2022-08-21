using UnityEngine;

namespace Utilities
{
    public class FollowPlayerXY : MonoBehaviour
    {
        [SerializeField] private Vector2 offset;

        private Transform player;

        void Awake()
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        void Update()
        {
            Follow();
        }

        private void Follow()
        {
            transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);
        }
    }
}