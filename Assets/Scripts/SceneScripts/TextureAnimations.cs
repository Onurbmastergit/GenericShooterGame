using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureAnimations : MonoBehaviour
{
    public float offsetAmount =  0.1f; // Valor pelo qual você deseja modificar o offset

    void Update()
    {
        Renderer renderer = GetComponent<Renderer>(); // Obtém o componente Renderer do objeto
        if (renderer != null && renderer.material != null)
        {
            // Obtém o deslocamento atual da textura no material
            Vector2 currentOffset = renderer.material.mainTextureOffset;
            // Modifica o deslocamento no eixo x
            currentOffset.x -= offsetAmount;
            // Define o novo deslocamento no material
            renderer.material.mainTextureOffset = currentOffset;
        }
        else
        {
            Debug.LogError("O objeto não possui um Renderer ou o material não está atribuído.");
        }
    }

}
