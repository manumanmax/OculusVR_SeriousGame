using UnityEngine;
using System.Collections;

public class CameraGrabber : MonoBehaviour {
    public GameObject hitDownObject = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit))
            hitDownObject = hit.transform.gameObject;

	}
}
