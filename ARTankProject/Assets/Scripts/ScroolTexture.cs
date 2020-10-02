using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScroolTexture : MonoBehaviour
{
    private float scroolX = 0.25f;
    // Update is called once per frame
    void Update()
    {
        float offsetX = Time.time * scroolX;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(-offsetX, 0.0f);
    }
}
