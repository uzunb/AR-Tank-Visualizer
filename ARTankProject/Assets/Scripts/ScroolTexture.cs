using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScroolTexture : MonoBehaviour
{
    public float scroolX =0.05f;


    // Update is called once per frame
    void Update()
    {
        float offsetX = Time.time * scroolX;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(-offsetX, 0.0f);
    }
}
