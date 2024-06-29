using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    List<GameObject> objectsToCreate;
    [SerializeField]
    float elapsed = 0f;

    // Update is called once per frame
    void Update()
    {
        elapsed+=Time.deltaTime;
        if(elapsed >= 2.0f){
            elapsed = 0;
            CreateObject();
        }
    }

    void CreateObject(){
        int index = Random.Range(0,objectsToCreate.Count - 1);
        float positionY = Random.Range(-Camera.main.orthographicSize,
        Camera.main.orthographicSize);
        Vector3 newPosition = transform.position;
        newPosition.y = positionY;
        Instantiate(objectsToCreate[index],
            newPosition,
            Quaternion.identity);
    }
}
