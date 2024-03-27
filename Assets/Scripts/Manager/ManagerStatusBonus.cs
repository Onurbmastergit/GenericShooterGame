using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerStatusBonus : MonoBehaviour
{
    int lifeBarrilTotal;
    int lifeBarrilAtual;

    public TextMeshProUGUI vidaStatus;
    public GameObject barril;

    // Cores
    Color32 corVermelho = new Color32(249, 6, 0, 255); // Red = F90600
    Color32 corVerde = new Color32(0, 249, 22, 255);   // Green = 00F916
    Color32 corAmarelo = new Color32(249, 192, 0, 255);// Yellow = F9C000

    private void Start()
    {
        lifeBarrilTotal = Random.Range(20, 120);
        lifeBarrilAtual = lifeBarrilTotal;
    }

    private void Update()
    {
        vidaStatus.text = lifeBarrilAtual.ToString();

        // Define a cor do texto com base na quantidade de vida atual
        if (lifeBarrilAtual <= lifeBarrilTotal * 0.2f) // Menos de 20% de vida (Vermelho)
        {
            vidaStatus.color = corVermelho;
        }
        else if (lifeBarrilAtual >= lifeBarrilTotal * 0.8f) // Mais de 80% de vida (Verde)
        {
            vidaStatus.color = corVerde;
        }
        else // Entre 20% e 80% de vida (Amarelo)
        {
            vidaStatus.color = corAmarelo;
        }
    }

    public void ReceberDano(int valor)
    {
        lifeBarrilAtual -= valor;
        VerificarMorte();
    }

    void VerificarMorte()
    {
        if (lifeBarrilAtual <= 0)
        {
            Destroy(barril);
        }
    }
}
