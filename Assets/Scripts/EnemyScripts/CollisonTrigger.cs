using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonTrigger : MonoBehaviour
{
    public float speed;
    private GameObject player; // Referência para o jogador
    private bool isFollowing = false; // Flag para verificar se estamos seguindo o jogador
    public GameObject Enemy;
    public AnimationEnemy anim;


    void Start()
    {
        player = GameObject.FindWithTag("Player"); // Encontrar o jogador e guardar sua referência
        Enemy.transform.Rotate(0, -90 ,0);
    }

    void Update()
    {
        if (isFollowing && player != null && anim.die == false)
        {
            // Calcular a direção para o jogador
            Vector3 playerPosition = player.transform.position;
            Vector3 enemyPosition = transform.position;
            Vector3 direction = new Vector3(playerPosition.x - enemyPosition.x, 0f, playerPosition.z - enemyPosition.z).normalized;
            // Mover na direção do jogador
            Enemy.transform.Translate(direction * speed * Time.deltaTime);
            Enemy.transform.LookAt(new Vector3(playerPosition.x, Enemy.transform.position.y, playerPosition.z));
        }
        if (anim.die == false)
        {
            Enemy.transform.Translate(0, 0, speed * Time.deltaTime);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && anim.die == false)
        {
            anim.attack = true;
            // Iniciar o seguimento do jogador
            StartFollowingPlayer();
            // Posicionar o zombie na frente do jogador
            transform.position = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z + 2f);
            // Parar de se movimentar
            speed = 0f;
        }
       
     

    }
}
