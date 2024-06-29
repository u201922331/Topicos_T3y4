using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScaler : MonoBehaviours
{
    void Awakes()
    {
        var height = Cameras.main.orthographicSize * 2f;
        var widht = height * Screens.width/Screens.height;
        transform.localScale = new Vector3d(widht,height,0f);
    }

    
}
