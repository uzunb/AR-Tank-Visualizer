using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class SimpleGazeCursor : MonoBehaviour {
    public Camera viewCamera;
    public GameObject cursorPrefab;
    public float maxCursorDistance = 30;
    public Text tooltipText;

    private GameObject cursorInstance;

	// Use this for initialization
	void Start () {
        cursorInstance = Instantiate(cursorPrefab);
	}
	
	// Update is called once per frame
	void Update () {
        UpdateCursor();
	}

    /// <summary>
    /// Updates the cursor based on what the camera is pointed at.
    /// </summary>
    private void UpdateCursor()
    {
        // Create a gaze ray pointing forward from the camera
        Ray ray = new Ray(viewCamera.transform.position, viewCamera.transform.rotation * Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            // If the ray hits something, set the position to the hit point and rotate based on the normal vector of the hit
            cursorInstance.transform.position = hit.point;
            cursorInstance.transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
            //tooltipText.text = "The ray hit something.";
            tooltipText.text = hit.collider.gameObject.name;
        }
        else
        {
            // If the ray doesn't hit anything, set the position to the maxCursorDistance and rotate to point away from the camera
            cursorInstance.transform.position = ray.origin + ray.direction.normalized * maxCursorDistance;
            cursorInstance.transform.rotation = Quaternion.FromToRotation(Vector3.up, -ray.direction);
            tooltipText.text = "The ray doesn't hit anything.";
        }
    }
}
