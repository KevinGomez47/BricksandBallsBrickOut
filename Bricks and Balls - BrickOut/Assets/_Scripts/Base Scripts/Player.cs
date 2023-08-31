using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 mousePos2D;
    Vector2 mousePos3D;
    [SerializeField] public float limitX = 7.2f;
    [SerializeField] public float paddleSpeed = 20f;
    public GameObject ball;
    void Start()
    {

    }

    void Update()
    {
        //Con este método se mueve el paddle mediante el mouse 
        /*
        Vector3 pos = transform.position;
        mousePos2D = Input.mousePosition;
        mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        pos.x = mousePos3D.x;
        if(pos.x <= -limitX) pos.x = -limitX;
        else if (pos.x >= limitX) pos.x = limitX;
        transform.position = pos;
        */

        //Con este método se mueve el paddle mediante flechas

        /*
        if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector3.left * paddleSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector3.right * paddleSpeed * Time.deltaTime);
        Vector3 pos = transform.position;
        if(pos.x <= -limitX) pos.x = -limitX;
        else if (pos.x >= limitX) pos.x = limitX;
        transform.position = pos;
        */

        //Con este método se mueve el paddle mediante un control

        transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * paddleSpeed * Time.deltaTime);
        Vector3 pos = transform.position;
        if (pos.x <= -limitX) pos.x = -limitX;
        else if (pos.x >= limitX) pos.x = limitX;
        transform.position = pos;
    }

}
