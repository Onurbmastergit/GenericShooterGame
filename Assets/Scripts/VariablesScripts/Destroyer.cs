using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zombie")) 
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Barril")) 
        {
            Destroy(other.gameObject);
        }
       
    }
}
