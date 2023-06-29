using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rigidbody;
    private float moveSpeed = 10f;
    private bool isWalking = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * moveSpeed * Time.deltaTime;
        rigidbody.MovePosition(transform.position + movement);

        if (movement != Vector3.zero)
        {
            if (!isWalking)
            {
                isWalking = true;
                animator.SetBool("IsWalking", true);
            }
        }
        else
        {
            if (isWalking)
            {
                isWalking = false;
                animator.SetBool("IsWalking", false);
            }
        }
    }
}
