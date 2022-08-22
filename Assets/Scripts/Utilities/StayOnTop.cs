using UnityEngine;

namespace Utilities
{
    public class StayOnTop : MonoBehaviour
    {
        void Awake()
        {
            transform.parent = FindObjectOfType<Canvas>().transform;
        }
    }
}