using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.Play("player_shoot");
            Debug.Log("Shoot");
        }
        else
        {
            _animator.Play("Idle");
        }
    }
}
