using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    
    private List<Color> colors;
    private int idColor = 0;

    public void Start(){
        colors = new List<Color>();
        colors.Add(Color.red);
        colors.Add(Color.green);
        colors.Add(Color.blue);
        colors.Add(Color.yellow);
        colors.Add(Color.cyan);
        colors.Add(Color.magenta);
    }

    public void SetColor(){
        
        GetComponent<Renderer>().material.color = colors[idColor++];
        
        if (idColor >= colors.Count){
            idColor = 0;
        }
    }
}
