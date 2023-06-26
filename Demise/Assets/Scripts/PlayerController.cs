using System;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    [SerializeField] public float movementSpeed;
    [SerializeField] public float jumpForce;
    [SerializeField] private AudioSource jumpSound;
    private IsGrounded _ground;
  
    
    
    [SerializeField] private Animator playerAnim;
    private Rigidbody2D _rigidbody;
    private bool facingRight = true;

    void Start()
    {
        _ground = GameObject.Find("isGrounded").GetComponent<IsGrounded>();
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

    

    private void Jump()
    {
        float grounded = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && _ground.groundCheck)
        {
            
            
            jumpSound.Play();
           
                _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
                Debug.Log(_ground.groundCheck);
               
        }
    }

    void Flip()
    {
        gameObject.transform.Rotate(0f, 180f, 0f);

        facingRight = !facingRight;
    }
}