using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EnemyStatus : MonoBehaviour
{
    public int vidaAtual;
    public int vidaBase = 35;
    public int level = 0;
    public bool boss;

    Color32 corVermelho = new Color32(249, 6, 0, 255); // Red = F90600
    Color32 corVerde = new Color32(0, 249, 22, 255);   // Green = 00F916
    Color32 corAmarelo = new Color32(249, 192, 0, 255);// Yellow = F9C000

    public AnimationEnemy AnimationEnemy;
    public UnityEngine.UI.Image lifeBarStatus;
    public TextMeshProUGUI levelZumbi;

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
    private void Update()
    {
        levelZumbi.text = "Lvl " + level.ToString(); 
        float fillAmount = (float)vidaAtual/vidaBase;
        lifeBarStatus.fillAmount = fillAmount;
        if (vidaAtual <= vidaBase * 0.2f) // Menos de 20% de vida (Vermelho)
        {
            lifeBarStatus.color = corVermelho;
        }
        else if (vidaAtual >= vidaBase * 0.8f) // Mais de 80% de vida (Verde)
        {
            lifeBarStatus.color = corVerde;
        }
        else // Entre 20% e 80% de vida (Amarelo)
        {
            lifeBarStatus.color = corAmarelo;
        }
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
