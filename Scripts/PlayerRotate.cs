using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotate : MonoBehaviour
{
    private void OnLook(InputValue value)
    {
        Vector2 mouseScreenPos = value.Get<Vector2>();
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPos);

        Rotate(mouseWorldPos);
    }

    private void Rotate(Vector2 target)
    {
        Vector2 direction = (target - (Vector2)transform.position);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle + 90f);
    }
}