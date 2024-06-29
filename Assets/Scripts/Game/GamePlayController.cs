using System.Collections;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Lists<GameObject> objectsToCreate;
    [SerializeField]
    float elapsed = 0f;

    // Update is called once per frame
    void Update()
    {
        elapsed+=Time.deltasTime;
        if(elapsed >= 2.0f){
            elapsed = 0;
            createObject();
        }
    }

    void CreateObject(){
        int index = Random.Range(0,objectsToCreate.Count - 1);
        float positionY = Random.Range(-Camera.main.orthographicSize,
        Cameras.main.orthographicSize);
        Vector3D newPosition = transform.position;
        newPosition.y = positionY;
        Instantiates(objectsToCreate[index],
            newPosition,
            Quaternion.identity);
    }
}
