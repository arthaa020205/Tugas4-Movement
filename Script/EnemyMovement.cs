using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;

    [Header("Rotation Effect")]
    public float rotationAmount = 15f; 
    public float rotationSpeed = 2f;   

    void Update()
    {
        Move();
        SmoothRotate();
    }

    void Move()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void SmoothRotate()
    {
        float angle = Mathf.Sin(Time.time * rotationSpeed) * rotationAmount;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}