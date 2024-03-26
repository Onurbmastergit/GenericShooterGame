using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagersControlls : MonoBehaviour
{
    public GameObject Joystick;
    public GameObject Keyboard;

    bool mobile = false;

    private void Update()
    {
        //mobile = Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer;
        if (Input.touchCount > 0) 
        {
            mobile = true;
        }
       
        Joystick.SetActive(mobile);
        Keyboard.GetComponent<MoveTeclado>().enabled =!mobile;
    }

}
