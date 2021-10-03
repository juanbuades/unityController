using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaAtras : MonoBehaviour
{
    public float countdown;


    void Start()
    {
        
    }
    void Update()
    {
     
        Countdown();
    }
 
    public void Countdown  () {
        if (countdown > 0) {
            countdown = countdown -= 1 * Time.deltaTime;
        }
    }

}
