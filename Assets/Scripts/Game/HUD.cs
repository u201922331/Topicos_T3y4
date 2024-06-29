using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField]
    GameObject objectScore;
    TMP_Text txtScore;
    [SerializeField]
    GameObject objectMaxScore;
    TMP_Text txtMaxScore;
    int score;
    public static HUD instance;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    void Start()
    {
        txtScore = objectScore.GetComponent<TMP_Text>();
        txtScore.text = "Score " +score.ToString();
        if(PlayerPrefs.HasKey("score")){
            txtMaxScore = objectMaxScore.GetComponent<TMP_Text>();
            objectMaxScore.SetActive(true);
            txtMaxScore.text = "Max Score " +PlayerPrefs.GetInt("score");
        }
    }

    public void updateScore(){
        score+=10;
        PlayerPrefs.SetInt("score",score);
        txtScore.text = "Score " +score.ToString();
    }
    
    
}
