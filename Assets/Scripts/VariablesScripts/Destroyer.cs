using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Destruir o objeto que este script est� anexado
        Destroy(other.gameObject);
    }
}
