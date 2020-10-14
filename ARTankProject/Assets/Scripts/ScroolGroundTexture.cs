using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScroolGroundTexture : MonoBehaviour
{

    public GameObject theTank;
    private float horizontalScroolSpeed = 0.05f;
    private float verticalScroolSpeed = 0.05f;

    private Vector2 groundVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float offsetX = Time.time * horizontalScroolSpeed;
        float offsetY = Time.time * verticalScroolSpeed;
        
        groundVector = new Vector2(offsetX, offsetY);
        groundVector = rotate(groundVector, theTank.transform.rotation.y);
        

        GetComponent<Renderer>().material.mainTextureOffset = groundVector;
        //GetComponent<Renderer>().material.mainTextureOffset =new Vector2(Mathf.Cos(degree * Mathf.Degree2Rad) * Time.time, Mathf.Sin(degree * Mathf.Degree2Rad)* Time.time);
    }

    public static Vector2 rotate(Vector2 v, float delta) {
        return new Vector2(
            v.x * Mathf.Cos(delta) - v.y * Mathf.Sin(delta),
            v.x * Mathf.Sin(delta) + v.y * Mathf.Cos(delta)
    );
}
}
