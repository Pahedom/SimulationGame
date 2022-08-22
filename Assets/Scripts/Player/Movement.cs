using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float speed;

        [SerializeField] private Animator animator;

        private Rigidbody2D myRigidbody;

        public UnityEvent OnStartMoving;
        public UnityEvent OnStopMoving;

        private void Awake()
        {
            myRigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            animator.SetBool("Moving", myRigidbody.velocity != Vector2.zero);

            Move(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")));
        }

        public void Move(Vector2 direction)
        {
            if (myRigidbody.velocity == Vector2.zero && direction != Vector2.zero)
            {
                OnStartMoving.Invoke();
            }
            else if (myRigidbody.velocity != Vector2.zero && direction == Vector2.zero)
            {
                OnStopMoving.Invoke();
            }

            myRigidbody.velocity = direction * speed;

            Flip(direction.x);
        }

        private void Flip(float directionX)
        {
            if (directionX < 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else if (directionX > 0)
            {
                transform.rotation = Quaternion.identity;
            }
        }
    }
}