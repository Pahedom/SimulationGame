using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D myRigidbody;

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")));
    }

    public void Move(Vector2 direction)
    {
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