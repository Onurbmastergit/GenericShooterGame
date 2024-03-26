using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTouch : MonoBehaviour
{
    float velocidade = 5f;
   
    void Update()
    {
        float inputHorizontal = 0;
        float inputVertical = 0;

        if (Input.touchCount > 0) 
        {
            float positionX = Input.GetTouch(0).position.x;
            float positionY = Input.GetTouch(0).position.y;
            if (Screen.width / 2 < positionX)
            {
                inputHorizontal = 1;
            }
            else 
            {
                inputHorizontal -= 1;
            }
            if (Screen.height / 2 < positionY)
            {
                inputVertical = 1;
            }
            else 
            {
                inputVertical -= 1;
            }


        }
        

        Vector3 move = new Vector3(inputHorizontal, 0 , inputVertical );
        move = move * velocidade * Time.deltaTime; 

        transform.Translate(move);
        transform.Rotate(move);
    }
}
