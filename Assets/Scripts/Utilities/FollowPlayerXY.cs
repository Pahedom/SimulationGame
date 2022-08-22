using System;
using UnityEngine;

namespace Utilities
{
    public class FollowPlayerXY : MonoBehaviour
    {
        [SerializeField] private Vector2 offset;

        [Serializable]
        private struct Constraints
        {
            public float left;
            public float right;
            public float top;
            public float bottom;
        }

        [SerializeField] private Constraints constraints;

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
            float posX = Mathf.Clamp(player.position.x + offset.x, constraints.left, constraints.right);
            float posY = Mathf.Clamp(player.position.y + offset.y, constraints.bottom, constraints.top);

            transform.position = new Vector3(posX, posY, transform.position.z);
        }
    }
}