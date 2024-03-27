using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentSimple : MonoBehaviour
{
    public float speed;
    private GameObject player; // Referência para o jogador
    public bool isFollowing = false; // Flag para verificar se estamos seguindo o jogador

    private void Start()
    {
        player = GameObject.FindWithTag("Player"); // Encontrar o jogador e guardar sua referência
    }

    private void Update()
    {
        if (isFollowing && player != null)
        {
            // Calcular a direção para o jogador
            Vector3 playerPosition = player.transform.position;
            Vector3 enemyPosition = transform.position;
            Vector3 direction = new Vector3(playerPosition.x - enemyPosition.x, 0f, playerPosition.z - enemyPosition.z).normalized;
            // Mover na direção do jogador
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else
        {
            // Mover para frente
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    public void StartFollowingPlayer()
    {
        isFollowing = true; // Começar a seguir o jogador
    }

    public void StopFollowingPlayer()
    {
        isFollowing = false; // Parar de seguir o jogador
    }
}
