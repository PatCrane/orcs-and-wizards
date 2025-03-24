using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("projectile"))
        {
            ScoreManager.Instance.AddScore(100);
            Destroy(gameObject);
        }
    }
}
