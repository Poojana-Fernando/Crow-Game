using UnityEngine;
using UnityEngine.InputSystem;

public class Birdmovemnt : MonoBehaviour
{

    public float jumpforce = 5f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0 )
        {
            rb.linearVelocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
{
    Time.timeScale = 0f;
    Debug.Log("Game Over");
}




}
