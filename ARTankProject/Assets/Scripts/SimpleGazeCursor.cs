using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class SimpleGazeCursor : MonoBehaviour {
    public Camera viewCamera;
    public GameObject tooltip;
    public Text tooltipText;

	// Update is called once per frame
	void Update () {
        UpdateCursor();
	}
    
    /// Updates the cursor based on what the camera is pointed at.
    private void UpdateCursor()
    {
        // Create a gaze ray pointing forward from the camera
        Ray ray = new Ray(viewCamera.transform.position, viewCamera.transform.rotation * Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            // If the ray hits something, set the position to the hit point and rotate based on the normal vector of the hit
            tooltip.SetActive(true);
            tooltipText.text = hit.collider.gameObject.name;
        }
        else
        {
            // If the ray doesn't hit anything, set the position to the maxCursorDistance and rotate to point away from the camera
            tooltip.SetActive(false);
        }
    }
}
