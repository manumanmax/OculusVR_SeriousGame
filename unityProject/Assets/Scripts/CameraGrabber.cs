using UnityEngine;
using System.Collections;

public class CameraGrabber : MonoBehaviour {
    public GameObject hitDownObject = null;
    private Ray ray;
    private RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}


    void OnMouseDown()
    {
        if (hitDownObject)
        {
            Rigidbody rb = hitDownObject.rigidbody;
            Debug.Log(rb);
            if(rb != null){
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, hit.distance));
                
                rigidbody.MovePosition(worldPos);
            }
        }
    }

	// Update is called once per frame
	void Update () {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit))
        {
            hitDownObject = hit.transform.gameObject;
        }
        

	}
}
