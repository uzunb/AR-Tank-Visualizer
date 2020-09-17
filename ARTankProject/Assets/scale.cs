using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class scale : MonoBehaviour
{
    private float scaleValue;

    void Setup()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            scaleValue = transform.localScale.x - 0.5f ;
            transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
            Debug.Log("Pressed primary button.");

        }

        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            scaleValue = transform.localScale.x + 0.5f ;
            transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
            Debug.Log("Pressed primary button.");

        }

    }
}
