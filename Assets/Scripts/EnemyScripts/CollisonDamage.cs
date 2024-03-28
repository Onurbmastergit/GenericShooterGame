using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisonDamage : MonoBehaviour
{
   int danoZumbi;
   public EnemyStatus danoInimigo;
   public  PlayerStatus player;

   void Start()
   {
    player = GameObject.FindWithTag("Player").GetComponent<PlayerStatus>();
   }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            player.ReceberDano(danoInimigo.danoZumbiBase);
        } 
        
    }
}
