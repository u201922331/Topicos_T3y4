using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    [SerializeField]
    Button btnMain;
    [SerializeField]
    TMP_Text txtScore;
    void Start()
    {
        int score = 0;
        if(PlayerPrefs.HasKey("score")){
            score = PlayerPrefs.GetInt("score");
        }
        txtScore.text = "Last Score :"+score.ToString();
        btnMain.onClick.AddListener(()=>GoMain());
    }

    void GoMain(){
        btnMain.onClick.RemoveAllListeners();
        SceneManager.LoadScene("Menu");
    }
}
