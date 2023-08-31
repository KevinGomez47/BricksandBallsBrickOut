using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    // Salud general de un bloque
    public int hitPoints = 1;

    // El bloque es solido
    public bool isSolid;

    void Start()
    {
        
    }

    void Update()
    {
        // Se destruye el bloque cuando su salud es igual o menor a cero
        if (hitPoints <= 0 && !isSolid)
        {
            // Se ejecuta la funcion que rebota la bola más la sobrecarga de metodos de cada Special Brick
            bounceBall();

            // Se destruye el bloque si su salud llega a cero
            Destroy(gameObject);

        }

    }

    public virtual void bounceBall() {
        
    }
}
