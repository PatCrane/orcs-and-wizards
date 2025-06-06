using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        { 
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
    }
}
