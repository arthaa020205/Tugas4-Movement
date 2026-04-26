using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    protected Rigidbody2D body;
    protected Vector2 currentInput;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        body.linearVelocity = currentInput * moveSpeed;
    }
}