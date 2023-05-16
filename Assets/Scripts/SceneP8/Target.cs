using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Events;

public class target : DefaultObserverEventHandler
{
    GameObject ball;
    protected override void OnTrackingFound()
    {
        ball = GameObject.Find("Pelota");
        if(ball){
            ball.GetComponent<Rigidbody>().useGravity = true;
        }
        base.OnTrackingFound();
    }

    protected override void OnTrackingLost()
    {
        ball = GameObject.Find("Pelota");
        if(ball){
            ball.GetComponent<Rigidbody>().useGravity = false;
        }
        base.OnTrackingLost();
    }
}
