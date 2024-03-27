using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrilMoviment : MonoBehaviour
{
    public float speed;
    public float rotationY = 90f; // Rotação desejada no eixo Y

    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
        transform.Translate(0f, 0f, -speed * Time.deltaTime); ;
    }
}
