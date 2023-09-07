using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    //Ren H, 6/9/23: Set-up
    [SerializeField]
    public GameObject Pause;
    public bool pauseEnabled;

   void Start(){
        pauseEnabled = true;
    }

    public void TurnOnAndOff(){
        if(pauseEnabled == true){
            Pause.SetActive(true);
            pauseEnabled = false;
        }
    }

    // Ren H, 6/9/23- See: ClickPause script
}


