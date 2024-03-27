using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTeclado : MonoBehaviour
{

    float velocity = 5f;
    public Transform Player;



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log("Teclado");
        Debug.Log($"Horizontal == {horizontal}");
        Vector3 move = new Vector3(0, 0, horizontal );
        move = move * velocity * Time.deltaTime;

        move *= -1;

        transform.Translate(move);
    }


}


