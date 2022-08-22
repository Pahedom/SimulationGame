using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interactables
{
    public class Door : MonoBehaviour
    {
        [SerializeField] private Animator animator;

        private void Open()
        {
            animator.SetTrigger("PlayerEnter");
        }

        private void Close()
        {
            animator.SetTrigger("PlayerExit");
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Open();
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            Close();
        }
    }
}