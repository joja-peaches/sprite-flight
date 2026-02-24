using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float minSize = 0.5f;
    float maxSize = 2.0f;

    float minSpeed = 50f;
    float maxSpeed = 150f;
    Rigidbody2D rb;
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        rb = GetComponent<Rigidbody2D>();

        transform.localScale = new Vector3(randomSize, randomSize, 1);

        rb.AddForce(Vector2.right * randomSpeed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
