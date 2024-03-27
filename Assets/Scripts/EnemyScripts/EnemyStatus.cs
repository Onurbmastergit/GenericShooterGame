using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    public int vidaAtual;
    public int vidaBase = 35;
    public int level = 0;
    public bool boss;

    public AnimationEnemy AnimationEnemy;

    private void Start()
    {
        if (level == 1)
        {
            vidaBase = 50;
        }
        else if (level == 2)
        {
            vidaBase *= 2;
        }
        else if (level == 3)
        {
            vidaBase *= 3;
        }
        else if (boss == true) 
        {
            vidaBase *= 4;
        }
        AnimationEnemy = GetComponent<AnimationEnemy>();
        vidaAtual = vidaBase;
    }
    public void ReceberDano(int valor) 
    {
        vidaAtual -= valor;
        VerificarMorte();
    }
    void VerificarMorte() 
    {
        if (vidaAtual == 0) 
        {
            AnimationEnemy.die = true;
            Invoke("DestruirCorpo", 2f);
        }
    }
    void DestruirCorpo() 
    {
        Destroy(gameObject);
    }
}
