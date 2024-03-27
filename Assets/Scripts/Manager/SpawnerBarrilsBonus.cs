using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBarrilsBonus : MonoBehaviour
{
    public GameObject prefabToSpawn; // O prefab que voc� deseja instanciar
    public float spawnInterval = 1f; // Intervalo de tempo entre cada spawn

    private IEnumerator StartSpawnRoutine()
    {
        while (true)
        {
            // Instancia o objeto na posi��o zero (local position) do objeto de spawn
            GameObject newObject = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);

            // Aguarda o intervalo de spawn
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void Start()
    {
        // Verifica se o prefabToSpawn est� atribu�do
        if (prefabToSpawn == null)
        {
            Debug.LogError("Prefab n�o atribu�do ao Prefab Spawner.");
            return;
        }

        // Inicia a rotina de spawn
        StartCoroutine(StartSpawnRoutine());
    }
}
