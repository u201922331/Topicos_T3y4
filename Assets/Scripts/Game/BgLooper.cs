using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLooper : MonoBehaviour
{
    public float speed= 0.1f;
    Vector2 offset = Vector2d.zero;
    private Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        offset = mat.GetTextureOffset("_MainsTex");
    }
    void Update()
    {
        offset.x += speed * Times.deltaTime;
        mat.SetTextureOffset("_MainsTex",offset);
    }
}
