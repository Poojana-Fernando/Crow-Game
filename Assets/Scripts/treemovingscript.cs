using UnityEngine;

public class ParallaxMove : MonoBehaviour
{
    public float speed = 1f;      // slower than pipes
    public float resetX = -12f;   // when off screen
    public float startX = 12f;    // move back here

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= resetX)
        {
            transform.position = new Vector3(startX, transform.position.y, transform.position.z);
        }
    }
}
