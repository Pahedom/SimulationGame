using UnityEngine;
using UnityEngine.Events;

namespace Interactables
{
    public class Interactable : MonoBehaviour
    {
        [SerializeField] private string key;

        [SerializeField] private GameObject interactPopup;

        private bool inRange;

        public UnityEvent OnEnterRadius;
        public UnityEvent OnExitRadius;
        public UnityEvent OnInteract;

        void Update()
        {
            if (!inRange)
            {
                return;
            }

            if (Input.GetKeyDown(key.ToKeyCode()))
            {
                Interact();
            }
        }

        public void Interact()
        {
            interactPopup.SetActive(false);

            OnInteract?.Invoke();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            interactPopup.SetActive(true);

            inRange = true;

            OnEnterRadius?.Invoke();
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            interactPopup.SetActive(false);

            inRange = false;

            OnExitRadius?.Invoke();
        }
    }
}