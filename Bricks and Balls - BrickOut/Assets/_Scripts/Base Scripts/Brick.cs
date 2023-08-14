using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    // Salud general de un bloque
    public int hitPoints = 1;

    //
    public bool solid;

    void Start()
    {
        
    }

    void Update()
    {
        // Se destruye el bloque cuando su salud es igual o menor a cero
        if (hitPoints <= 0 && !solid)
        {
            Destroy(gameObject);

            // Se ejecuta la funcion que rebota la bola más la sobrecarga de metodos de cada Special Brick
            bounceBall();
        }

    }

    public virtual void bounceBall() {
        
    }
}
