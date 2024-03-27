using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FpsCounter : MonoBehaviour
{
    [SerializeField] private float taxaDeAtualizaçãoDoContador;
    private float fpsQuantidade;
    public TextMeshProUGUI FpsCounters;
    private void Start()
    {
        InvokeRepeating(nameof(ContadorFpsDoGame),0f , taxaDeAtualizaçãoDoContador);
    }
    private void ContadorFpsDoGame() 
    {
        fpsQuantidade = 1f / Time.deltaTime;
        FpsCounters.text = Mathf.Floor(fpsQuantidade).ToString() + " FPS";
    }
}
