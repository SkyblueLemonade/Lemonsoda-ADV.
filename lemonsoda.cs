using UnityEngine;

public class lemonsoda : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontalInput, verticalInput).normalized;
        Vector2 movement = direction * speed * Time.deltaTime;

        transform.Translate(movement);
    }
}

