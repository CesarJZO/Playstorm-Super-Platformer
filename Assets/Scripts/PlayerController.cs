using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int walkSpeed = 1;
    bool isFacingRight = true;
    float velocityX;
    public Animator animator;
    bool isJumping;

    private bool Grounded => Physics2D.OverlapCircle(
        point: transform.position,
        radius: groundSensorRadius,
        layerMask: groundLayerMask
    );

    public new Rigidbody2D rigidbody;

    [Header("Settings")]
    public float jumpForce;
    public float groundSensorRadius;
    public LayerMask groundLayerMask;

    private void Update()
    {
         velocityX = Input.GetAxisRaw("Horizontal");

        if(velocityX < 0 && isFacingRight == true)
        {
            Turn();
        }else if(velocityX > 0 && isFacingRight == false)
        {
            Turn();
        }
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
            isJumping = true;
        }
    }

    private void Jump()
    {
        if (Grounded == true)
        {
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetTrigger("Jump");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, groundSensorRadius);
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(velocityX * walkSpeed, rigidbody.velocity.y);
        // print(velocityX);
    }

    private void LateUpdate()
    {
        animator.SetFloat("Speed", Mathf.Abs(velocityX));
        animator.SetBool("IsGrounded", Grounded);
        animator.SetFloat("VelocityY", rigidbody.velocity.y);
    }

    private void Turn()
    {
        transform.localScale = new Vector3(transform.localScale.x*-1, 1,0);
        isFacingRight = !isFacingRight;
    }
}
