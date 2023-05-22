using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelWin : MonoBehaviour
{
    public GameControl gameControl;
    public void OnTriggerEnter(Collider collider){
        if(collider.gameObject.name == "Pelota"){
            Destroy(collider.gameObject);
            gameControl.nextLevel();
        }
    }
}
