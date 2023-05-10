using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private new Rigidbody2D rigidbody;

    [Header("Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float groundDistance;
    [SerializeField] private LayerMask groundLayerMask;

    private void Update()
    {


        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        bool grounded = Physics2D.Raycast(
            origin: transform.position,
            direction: Vector2.down,
            distance: groundDistance,
            layerMask: groundLayerMask
        );

        if (grounded == true)
        {
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * groundDistance);
    }
}
