using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class changeColorBtn : MonoBehaviour
{
    public GameObject vbBtnObj;

    public Renderer rend;
    public Material[] materials;

    private int index = 1;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("colorBtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);


    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (materials.Length == 0)
            return;

        index++;

        if (index == materials.Length + 1)
            index = 1;

        rend.sharedMaterial = materials[index - 1];
        Debug.Log("vbutton clicked.");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("vbutton released.");
    }


}
