using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    [SerializeField] public float movementSpeed;
    [SerializeField] public float jumpForce;
    private bool isGrounded;
    
    [SerializeField] private Animator playerAnim;
    private Rigidbody2D _rigidbody;
    private bool facingRight = true;

    void Start()
    {
        
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
    }

    private void FixedUpdate()
    {
        float movement = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
        if (movement != 0)
        {
            _rigidbody.AddForce(new Vector2(movement * movementSpeed, 0f));
            playerAnim.Play("Run");
        }

        if (movement == 0)
        {
            playerAnim.Play("Idle");
        }
        if (movement > 0 && !facingRight)
        {
            Flip();
        }
        if (movement < 0 && facingRight)
        {
            Flip();
        }
        
    }

    //public void Grounded()
    //{
        //if (Vector3.up * jumpForce)
        //{
            
        //}
    //}

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
                _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void Flip()
    {
        gameObject.transform.Rotate(0f, 180f, 0f);

        facingRight = !facingRight;
    }
}