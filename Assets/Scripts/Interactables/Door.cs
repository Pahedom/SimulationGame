using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interactables
{
    public class Door : MonoBehaviour
    {
        [SerializeField] private Animator animator;

        [SerializeField] private AudioSource openSound;
        [SerializeField] private AudioSource closeSound;

        private void Open()
        {
            animator.SetTrigger("PlayerEnter");

            openSound.Play();
        }

        private void Close()
        {
            animator.SetTrigger("PlayerExit");

            closeSound.Play();
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