using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject paddle;
    bool isGameStarted;
    [SerializeField] public float ballSpeed = 20f;
    void Start()
    {
        /*
        // Por medio de una etiqueta en los GO desde el Editor podemos buscar elementos con el siguiente método
        GameObject paddle = GameObject.FindGameObjectWithTag("Paddle");  
        */

        //Se calcula la posición exacta para que la bola este justo arriba del paddle sin ninguna separación.
        float paddleSizeY = paddle.GetComponent<Renderer>().bounds.size.y / 2;
        float ballSizeY = GetComponent<Renderer>().bounds.size.y / 2;
        Vector3 newBallPos = paddle.transform.position;
        newBallPos.y += paddleSizeY + ballSizeY;
        transform.position = newBallPos;

        // Se asigna como padre a Paddle para que se mueva con el antes de iniciado el disparo de la bola.
        transform.SetParent(paddle.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space) || Input.GetButton("Submit"))
        {
            if(!isGameStarted) 
            {
                isGameStarted = true;
                transform.SetParent(null);
                Vector3 randDir = Vector3.up;
                randDir.x = Random.Range(-1f, 1f);
                GetComponent<Rigidbody>().velocity = randDir * ballSpeed;
            }
        }
    }
}
