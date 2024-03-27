using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticulesEffects : MonoBehaviour
{
    public GameObject particlePrefab; // Prefab da part�cula a ser spawnada
    public float particleDestroyTime = 0.7f; // Tempo at� a part�cula ser destru�da ap�s ser spawnada

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            // Encontre o ponto de contato exato entre a bala e o GameObject atual
            Vector3 contactPoint = other.ClosestPoint(transform.position);

            // Spawn da part�cula no ponto de contato
            GameObject particleInstance = Instantiate(particlePrefab, contactPoint, Quaternion.identity);

            // Destruir a part�cula ap�s um certo tempo
            Destroy(particleInstance, particleDestroyTime);

            // Destruir a bala
            Destroy(other.gameObject);
        }
    }
}
