using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBullets : MonoBehaviour
{
    public GameObject prefabToSpawn; // O prefab que você deseja instanciar
    public Transform spawnTransform; // O transform onde os objetos serão instanciados
    public float spawnDistance = 5f; // Distância na frente do transform para spawnar os objetos
    public float spawnInterval = 1f; // Intervalo de tempo entre cada spawn
    public float tempoDeVida;

    private IEnumerator StartSpawnRoutine()
    {
        while (true)
        {
            // Calcula a posição de spawn na frente do transform
            Vector3 spawnPosition = spawnTransform.position + spawnTransform.forward * spawnDistance;

            // Instancia o objeto na posição calculada
            GameObject newObject = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

            // Destruir o objeto após um pequeno atraso
            Destroy(newObject, tempoDeVida);

            // Aguarda o intervalo de spawn
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void Start()
    {
        // Verifica se o prefabToSpawn e o spawnTransform estão atribuídos
        if (prefabToSpawn == null || spawnTransform == null)
        {
            Debug.LogError("Prefab ou Transform não atribuídos ao Prefab Spawner.");
            return;
        }

        // Inicia a rotina de spawn
        StartCoroutine(StartSpawnRoutine());
    }
}
