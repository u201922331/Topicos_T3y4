using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScaler : MonoBehaviour
{
    void Awake()
    {
        var height = Camera.main.orthographicSize * 2f;
        var widht = height * Screen.width/Screen.height;
        transform.localScale = new Vector3(widht,height,0f);
    }

    
}
