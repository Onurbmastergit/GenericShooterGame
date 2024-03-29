using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerZombie : MonoBehaviour
{
    public GameObject[] prefabsToSpawn; // Prefabs das balas para cada nível
    public Transform spawnTransform; // O transform onde os objetos serão instanciados
    public float spawnDistance = 0f; // Distância na frente do transform para spawnar os objetos
    public float spawnInterval = 1f; // Intervalo de tempo entre cada spawn
    public static int level; // Nível atual
    public int spawnCount = 0;
    public int LifeTime = 0;

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

            //Destroy(newObject , LifeTime);
            spawnCount++;
            level = Random.Range(0,3);
            SpawnarBoss();
            // Aguarda o intervalo de spawn
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void Start()
    {
        level = Random.Range(0,3);
        // Verifica se o spawnTransform está atribuído
        if (spawnTransform == null)
        {
            Debug.LogError("Transform não atribuído ao Prefab Spawner.");
            return;
        }

        // Inicia a rotina de spawn
        StartCoroutine(StartSpawnRoutine());
    }
    void SpawnarBoss() 
    {
        if (spawnCount == 10) 
        {
            spawnCount = 0;
            level = 4;
        }
        
    }
}
