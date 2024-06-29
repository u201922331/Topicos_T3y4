using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip hurt;
    [SerializeField] AudioClip eat;
    [SerializeField] AudioClip lose;
    [SerializeField] AudioClip mushroom;
    public int lifes = 3;
    public static Hero instance;
    void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        GameObject gameObject = other.gameObject;
        if(gameObject.tag == "Enemy"){
            audioSource.clip = hurt;
            lifes--;
            if(lifes <=0){
                audioSource.clip = lose;
            }
            LifeController.instance.reduceLife();
        }else if(gameObject.tag == "Food"){
            audioSource.clip = eat;
            HUD.instance.updateScore();
        }
        else{
            lifes = lifes == 3 ? 3 : lifes + 1;
            audioSource.clip = mushroom;
            LifeController.instance.gainLife();
        }
        audioSource.Play();
        Destroy(other.gameObject);
    }

    
    void Update()
    {
       Vector3 mousePosition = 
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
       mousePosition.x = transform.position.x;
       mousePosition.z = transform.position.y;
       mousePosition.y = Mathf.Clamp(mousePosition.y,
       -Camera.main.orthographicSize,
       Camera.main.orthographicSize);
       transform.position = mousePosition;

    }
}
