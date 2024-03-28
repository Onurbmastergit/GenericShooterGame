using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class PlayerStatus : MonoBehaviour
{
    public int vidaTotal = 200;
    public int vidaAtual;
    public string Username;

    public TextMeshProUGUI Uname;
    public UnityEngine.UI.Image vidaStatusBar;


    Color32 corVermelho = new Color32(249, 6, 0, 255); // Red = F90600
    Color32 corVerde = new Color32(0, 249, 22, 255);   // Green = 00F916
    Color32 corAmarelo = new Color32(249, 192, 0, 255);// Yellow = F9C000
    void Start ()
    {
        Uname.text = Username;
        vidaAtual = vidaTotal;
    }
    void Update()
    {
        float fillAmount = (float)vidaAtual/vidaTotal;

        vidaStatusBar.fillAmount = fillAmount;

        if (vidaAtual <= vidaTotal * 0.2f) // Menos de 20% de vida (Vermelho)
        {
            vidaStatusBar.color = corVermelho;
        }
        else if (vidaAtual >= vidaTotal * 0.8f) // Mais de 80% de vida (Verde)
        {
            vidaStatusBar.color = corVerde;
        }
        else // Entre 20% e 80% de vida (Amarelo)
        {
            vidaStatusBar.color = corAmarelo;
        }
    }
    public void ReceberDano(int valor)
    {
        vidaAtual -= valor;
        VerificarMorte();
    }
    void VerificarMorte()
    {
        if(vidaAtual <= 0)
        {
            Invoke("DestruirCorpo" , 1.5f);
        }
    }
    void DestruirCorpo()
    {
        Destroy(gameObject);
    }
}
