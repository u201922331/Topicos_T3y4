using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    Button btnStart;
    [SerializeField]
    Button btnAbout;
    void Start()
    {
        btnStart.onClick.AddListener(()=>GoGame());
    }

    void GoGame(){
        btnStart.onClick.RemoveAllListeners();
        SceneManager.LoadScene("Game");
    }
}
