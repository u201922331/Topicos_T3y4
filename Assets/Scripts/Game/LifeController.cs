
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeController : MonoBehaviour
{
    [SerializeField] GameObject lifeObject;

    public static LifeController instance;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }
    void Start()
    {
        for (int i = 0; i < Hero.instance.lifes; i++)
        {
            Vector3 positionLife =transform.position;
            positionLife.x = i * 
                    (lifeObject.GetComponent<SpriteRenderer>().sprite.bounds.size.x*0.5f);
            Instantiate(lifeObject,positionLife,Quaternion.identity);
        }
    }

    public void reduceLife(){
        List<GameObject> lifes = 
            GameObject.FindGameObjectsWithTag("Life").ToList<GameObject>();
        int total = lifes.Count;
        if(total > 0){
            Destroy(lifes[total-1]);
            total--;
        }
        if(total <=0){
            SceneManager.LoadScene("GameOver");
        }
    }

    public void gainLife(){
        List<GameObject> lifes = 
            GameObject.FindGameObjectsWithTag("Life").ToList<GameObject>();
        int total = lifes.Count;
        Vector3 positionLife =transform.position;
        positionLife.x = total * 
                (lifeObject.GetComponent<SpriteRenderer>()
                .sprite.bounds.size.x*0.5f);
        Instantiate(lifeObject,positionLife,Quaternion.identity);
    }
}
