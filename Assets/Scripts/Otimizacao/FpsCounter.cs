using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FpsCounter : MonoBehaviour
{
    [SerializeField] private float taxaDeAtualiza��oDoContador;
    private float fpsQuantidade;
    public TextMeshProUGUI FpsCounters;
    private void Start()
    {
        InvokeRepeating(nameof(ContadorFpsDoGame),0f , taxaDeAtualiza��oDoContador);
    }
    private void ContadorFpsDoGame() 
    {
        fpsQuantidade = 1f / Time.deltaTime;
        FpsCounters.text = Mathf.Floor(fpsQuantidade).ToString() + " FPS";
    }
}
