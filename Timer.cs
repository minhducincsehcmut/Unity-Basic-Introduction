using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 10.0f; // Speed of movement
    void Start()
    {

    }

    void Update()
    {
        // Move the object along the Y-axis using Time.deltaTime for smooth movement
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
