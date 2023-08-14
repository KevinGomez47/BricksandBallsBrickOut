using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeBalls : MonoBehaviour
{
    public GameObject ball;
    public GameObject paddle;

    private void OnDestroy()
    {
        var paddleCenter = paddle.GetComponent<Renderer>().bounds.center;
        int starPos = -1;
        for(int i = 0; i < 3; i++)
        {
            var tempBall = Instantiate(ball);
            tempBall.transform.position = paddleCenter + new Vector3(starPos + i, 0.66f, 0);
        }
    }
}
