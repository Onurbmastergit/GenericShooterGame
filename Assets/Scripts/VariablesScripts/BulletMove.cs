using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float velocityBullet;
    public int danoBala = 1;
    
    void Update()
    {
        transform.Translate(velocityBullet * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barril"))
        {
 
            GameObject.FindWithTag("Barril").GetComponent<ManagerStatusBonus>().ReceberDano(danoBala);
            Destroy(gameObject);

        }
        if (other.CompareTag("Zombie")) 
        {
            other.GetComponent<EnemyStatus>().ReceberDano(danoBala);
            Destroy(gameObject);
        }
    }
  
    
}
