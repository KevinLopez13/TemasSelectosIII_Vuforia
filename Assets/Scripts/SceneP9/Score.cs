using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public TMP_Text s_attemps;
    public TMP_Text s_time;
    public TMP_Text title;

    public void setAttemps(string attemps){
        s_attemps.text = "Intentos: " + attemps;
    }

    public void setTime(string time){
        s_time.text = "Tiempo: " + time;
    }

    public void setTitle(string ttl){
        title.text = ttl;
    }

}
