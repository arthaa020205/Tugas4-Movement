using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 input;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        input = value.Get<Vector2>();
        Debug.Log("INPUT: " + input);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = input * speed;
        Debug.Log("VEL: " + rb.linearVelocity);
    }
}