using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticulesEffects : MonoBehaviour
{
    public GameObject particlePrefab; // Prefab da partícula a ser spawnada
    public float particleDestroyTime = 0.7f; // Tempo até a partícula ser destruída após ser spawnada

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            // Encontre o ponto de contato exato entre a bala e o GameObject atual
            Vector3 contactPoint = other.ClosestPoint(transform.position);

            // Spawn da partícula no ponto de contato
            GameObject particleInstance = Instantiate(particlePrefab, contactPoint, Quaternion.identity);

            // Destruir a partícula após um certo tempo
            Destroy(particleInstance, particleDestroyTime);

            // Destruir a bala
            Destroy(other.gameObject);
        }
    }
}
