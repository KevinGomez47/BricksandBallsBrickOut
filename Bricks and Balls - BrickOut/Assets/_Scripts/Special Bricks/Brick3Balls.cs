using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick3Balls : Brick
{
    public GameObject paddle;
    public GameObject threeBalls;
    void Start()
    {
        
    }

    public override void bounceBall()
    {
        base.bounceBall();
        spawnBalls();

    }

    private void spawnBalls()
    {
        var brickCenter = gameObject.GetComponent<Renderer>().bounds.center;
        var powerUp = Instantiate(threeBalls);
        powerUp.transform.position = brickCenter;
        powerUp.name = gameObject.name;
        powerUp.SetActive(true);

    }
}
