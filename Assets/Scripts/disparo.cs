using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public GameObject balaOriginal;
    public CuentaAtras countdown;
    public float reloadTime;

    void Start()  
    {
       
    }

    void Update()
    {

        if (countdown.countdown > 0)
        {
            if (reloadTime >= 3)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Instantiate(balaOriginal, this.transform.position, this.transform.rotation);
                    reloadTime = 0;

                }
            }
            else reloadTime = reloadTime += 1 * Time.deltaTime;   
        }
    }
    
}
