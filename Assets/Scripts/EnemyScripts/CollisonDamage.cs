using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonDamage : MonoBehaviour
{
    public AnimationEnemy animation;

    private void Start()
    {
        animation = GetComponent<AnimationEnemy>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animation.attack = true;

        }
        else 
        {
            animation.attack = false;
        }
    }
}
