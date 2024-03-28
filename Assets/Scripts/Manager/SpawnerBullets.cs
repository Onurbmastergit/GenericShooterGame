using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBullets : MonoBehaviour
{
     public GameObject[] prefabsToSpawn; // Prefabs das balas para cada nível
    public Transform spawnTransform; // O transform onde os objetos serão instanciados
    public float spawnDistance = 5f; // Distância na frente do transform para spawnar os objetos
    public float spawnInterval = 1f; // Intervalo de tempo entre cada spawn
    public float tempoDeVida;
    public  static int level; // Nível atual

    private IEnumerator StartSpawnRoutine()
    {
        while (true)
        {
            // Calcula a posição de spawn na frente do transform
            Vector3 spawnPosition = spawnTransform.position + spawnTransform.forward * spawnDistance;

            // Seleciona o prefab com base no nível
            int index = Mathf.Clamp(level, 0, prefabsToSpawn.Length - 1);
            GameObject prefabToSpawn = prefabsToSpawn[index];

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
        // Verifica se o spawnTransform está atribuído
        if (spawnTransform == null)
        {
            Debug.LogError("Transform não atribuído ao Prefab Spawner.");
            return;
        }

        // Inicia a rotina de spawn
        StartCoroutine(StartSpawnRoutine());
    }
}
