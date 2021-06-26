using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class gamemanager : MonoBehaviour
{
    public Text puntaje;
    public Text gameOver;
    
    void Update()
    {
         float puntos = float.Parse(puntaje.text);
        if(puntos<=0){
            gameOver.enabled = true;
            Debug.Log("" + puntos);
        }
    }
}
