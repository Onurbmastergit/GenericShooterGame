using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEnemy : MonoBehaviour
{
    public Animator animator;
    public bool attack;
    public bool die;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        animator.SetBool("Attack", attack);
        animator.SetBool("Die", die);
        if (die == true)
        {
            {
                Invoke("DestruirCorpo", 1f);
            }
        }

        void DestruirCorpo()
        {
            Destroy(gameObject);
        }
    }
}
