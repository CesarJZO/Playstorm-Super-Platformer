using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int walkSpeed = 1;
    bool isFacingRight = true;
    float velocityX;
    public Animator animator;
    bool isJumping;

    bool Grounded => Physics2D.Raycast(
            origin: transform.position,
            direction: Vector2.down,
            distance: groundDistance,
            layerMask: groundLayerMask
        );

    [SerializeField] private new Rigidbody2D rigidbody;

    [Header("Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float groundDistance;
    [SerializeField] private LayerMask groundLayerMask;

   
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
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * groundDistance);
    }
    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(velocityX * walkSpeed, rigidbody.velocity.y);
        print(velocityX);
    }
    private void LateUpdate()
    {
        animator.SetFloat("Speed",Mathf.Abs(velocityX));
        animator.SetBool("IsGrounded", Grounded);
        animator.SetFloat("VelocityY", rigidbody.velocity.y);
        
    }
    private void Turn()
    {
        transform.localScale = new Vector3(transform.localScale.x*-1, 1,0);
        isFacingRight = !isFacingRight;
    }
}
