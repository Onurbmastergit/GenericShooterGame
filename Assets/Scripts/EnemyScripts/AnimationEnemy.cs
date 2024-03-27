using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEnemy : MonoBehaviour
{
    public Animator animator;
    public bool attack;
    public bool die;
    public Collider colliderAttack;

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
            attack = false;
        }

       
    }
    public void EnableCollider() 
    {
        colliderAttack.enabled = true;
    }
    public void DisableCollider() 
    {
        colliderAttack.enabled = false;
    }
}
