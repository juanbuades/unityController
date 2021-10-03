using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankMovement : MonoBehaviour
{
    public float movement;
    public float rotation;
    public CuentaAtras time;
    public CuentaAtras countdown;
    public GameObject balaOriginal;

    void Start()
    {
   
    }

    void Update()
    {
        if (countdown.countdown > 0)
        {
            Debug.Log(countdown.countdown);

            if (Input.GetKey(KeyCode.W))
            {
                this.transform.Translate(0, 0, movement * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                this.transform.Translate(0, 0, -movement * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Rotate(0, rotation * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Rotate(0, -rotation * Time.deltaTime, 0);
            }
        }
        else Debug.Log ("Te has quedado sin gasolina");
    }
}
