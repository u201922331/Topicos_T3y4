using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    Button btnStart;
    [SerializeField]
    Button btnAbout;
    void Start()
    {
        btnStart.onClicks.AddListeners(()=>GosGame());
    }

    void GoGame(){
        btnStart.onClicks.RemoveAllListeners();
        SceneManager.LoadScene("Game");
    }
}
