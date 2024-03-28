using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWeapon : MonoBehaviour
{
    public int weaponLevel;
    public GameObject Wlvl1;
    public GameObject Wlvl2;
    public GameObject Wlvl3;
    public Transform spawnPoint; // Transform do spawn point
    private GameObject spawnedWeapon;

    void Start()
    {
        weaponLevel = Random.Range(1, 4); // Randomiza um número entre 1 e 3

        GameObject weaponPrefab = null;

        switch (weaponLevel)
        {
            case 1:
                weaponPrefab = Wlvl1;
                break;
            case 2:
                weaponPrefab = Wlvl2;
                break;
            case 3:
                weaponPrefab = Wlvl3;
                break;
            default:
                Debug.LogError("Weapon level out of range!");
                break;
        }

        if (weaponPrefab != null)
        {
            spawnedWeapon = Instantiate(weaponPrefab, spawnPoint.position, Quaternion.Euler(0, -90, 0)); // Ajusta a rotação para -90 no eixo Y
            spawnedWeapon.transform.parent = transform; // Torna o objeto instanciado filho do objeto em movimento
        }
    }

    // Se o objeto pai se mover, atualize a posição do objeto filho (o prefab instanciado)
    void LateUpdate()
    {
        if (spawnedWeapon != null)
        {
            spawnedWeapon.transform.position = spawnPoint.position;
        }
    }
}
