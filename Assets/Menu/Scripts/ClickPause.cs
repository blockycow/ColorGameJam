using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickPause : MonoBehaviour
{    
    public GameObject Pause;

    public bool PauseActive = false;

    public void OnMouseDown(){
        Debug.Log("The Game is paused");
        Pause.SetActive(false);
        PauseActive = true;
    }
}
