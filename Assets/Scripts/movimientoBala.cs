using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoBala : MonoBehaviour
{
    public float velocidadBala;

    void Update()
    {
        this.transform.Translate(0, 0, velocidadBala*Time.deltaTime);
    }
}
