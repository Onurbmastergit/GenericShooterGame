using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonDamage : MonoBehaviour
{
   

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("aTIGIU O pLAYE5R");
        } 
        
    }
}
