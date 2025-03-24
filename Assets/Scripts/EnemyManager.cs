using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    public int rows = 3;
    public int cols = 5;
    public float spacing = 1.5f;
    
    void Start()
    {
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Vector2 position = new Vector2(j * spacing, i * spacing + 3);
                Instantiate(enemyPrefab, position, Quaternion.identity);
            }
        }
    }

    
}
