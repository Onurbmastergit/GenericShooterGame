using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BarrilMove : MonoBehaviour
{
    public float rotation;
    


    void Update()
    {
        transform.Rotate(0, 0, rotation* Time.deltaTime);
    }

    
}
