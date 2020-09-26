using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomPlaneColor : MonoBehaviour
{
    public Renderer rend;
    public Material[] materials;

    private int index = 1;


    public void ButtonPressed()
    {
        if (materials.Length == 0)
            return;

        index++;

        if (index == materials.Length + 1)
            index = 1;

        print(index);
        rend.sharedMaterial = materials[index - 1];
        Debug.Log("button clicked.");

    }
}
