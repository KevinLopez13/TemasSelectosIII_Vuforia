using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsControler : MonoBehaviour
{
    public GameObject OriginPos;
    public GameObject BallPrefab;

    public void Update()
    {   
        GameObject ball = GameObject.Find("Pelota");
        if (ball == null){
            GameObject new_ball = Instantiate(BallPrefab, OriginPos.transform);
            new_ball.name = "Pelota";
            new_ball.transform.SetLocalPositionAndRotation( Vector3.zero, Quaternion.identity);
            new_ball.GetComponent<Rigidbody>().useGravity = true;
        }
        
    }
}
