using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed of movement

    void Update()
    {
        // Move the object along the X-axis
        float horizontalInput = Input.GetAxis("Horizontal");
        float movement = horizontalInput * speed * Time.deltaTime;

        transform.Translate(new Vector3(movement, 0f, 0f));
    }
}