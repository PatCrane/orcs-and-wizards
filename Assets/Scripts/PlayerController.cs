using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bulletPrefab;
    public float projectileOffset;
    public Transform playerPosition;

  

    

    [SerializeField] private Animator _animator;



    private void Start()
    {
        
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * move * speed * Time.deltaTime);
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
            _animator.SetBool("isShooting", true);
        }
        else
        {
            _animator.SetBool("isShooting", false);
        }


        
    }

    void Shoot()
    {
        Vector3 offset = new Vector3(0f, 2f, 0f);
        Vector3 spawnPos = transform.position + offset;

        Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

        
    }
}
