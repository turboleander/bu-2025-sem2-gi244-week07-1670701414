using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float gravityMultiplier = 1f;
    private Rigidbody rb;
    private InputAction jumpAction;
    private bool isOnGround = true;
    private int jumpCount = 0;

    public bool isGameOver = false;

    void Awake()
    {
        isGameOver = false;
        rb = GetComponent<Rigidbody>();
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Physics.gravity *= gravityMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpAction.triggered && jumpCount < 2 /*&& isOnGround*/ && !isGameOver)
        {
            rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
            isOnGround = false;
            jumpCount++; 
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit" + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            jumpCount = 0;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            isGameOver = true;
        }
    }

}
