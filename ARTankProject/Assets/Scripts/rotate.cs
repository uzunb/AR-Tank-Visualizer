using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class rotate : MonoBehaviour
{
    private float AngleX ;
    private float AngleY ;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
            transform.Rotate(25.0f, 0.0f, 0.0f, Space.Self);        

        if (Input.GetKeyDown(KeyCode.DownArrow))
            transform.Rotate(-25.0f, 0.0f, 0.0f, Space.Self);        

        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.Rotate(0.0f, 25.0f, 0.0f, Space.Self);        

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Rotate(0.0f, -25.0f, 0.0f, Space.Self);
    }
}
