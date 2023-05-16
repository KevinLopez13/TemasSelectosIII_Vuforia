using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelWin : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider){
        collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
