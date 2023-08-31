using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick3Balls : Brick
{
    public GameObject threeBalls;
    Vector3 PosToInst;
    void Start()
    {
        PosToInst = transform.position;
    }

    public override void bounceBall()
    {
        base.bounceBall();
        spawnBalls();

    }

    private void spawnBalls()
    {
        var powerUp = Instantiate(threeBalls);
        powerUp.transform.position = PosToInst;
        powerUp.name = gameObject.name;
        powerUp.SetActive(true);

    }
}
