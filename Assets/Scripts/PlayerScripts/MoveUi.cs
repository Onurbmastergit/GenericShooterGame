using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveUi : MonoBehaviour
{
   
    float velocity = 5f;
    Transform Player;

    public Joystick Joystick;
    

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
        Joystick = GetComponent<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 move = new Vector3(0, 0, Joystick.Horizontal);
        move = move * velocity * Time.deltaTime;

        move *= -1;
        Player.transform.Translate(move);
    }

  
}
