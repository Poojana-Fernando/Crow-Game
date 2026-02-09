using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 2f;
    public float destroyx = -12f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < destroyx)
        {
            Destroy(gameObject);
        }
    }
}

