using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastObject : MonoBehaviour
{
    GameObject collidedObject;
    public GameObject txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            collidedObject = hit.collider.gameObject;
            txt.GetComponent<UnityEngine.UI.Text>().text = collidedObject.name.ToString();
        }
    }
}
