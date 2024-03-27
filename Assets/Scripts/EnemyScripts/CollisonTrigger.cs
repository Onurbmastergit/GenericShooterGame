using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonTrigger : MonoBehaviour
{
    private MovimentSimple enemy;

    void Start()
    {
        enemy = transform.parent.GetComponent<MovimentSimple>(); // Assumindo que o MovimentSimple está no pai do CollisonTrigger
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Iniciar o seguimento do jogador
            enemy.StartFollowingPlayer();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Parar de seguir o jogador
            enemy.StopFollowingPlayer();
        }
    }
}
