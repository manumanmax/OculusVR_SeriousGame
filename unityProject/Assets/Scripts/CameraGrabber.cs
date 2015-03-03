using UnityEngine;
using System.Collections;

public class CameraGrabber : MonoBehaviour {
    public GameObject hitObject = null;
    private Ray ray;
    private RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}

   

	// Update is called once per frame
	void Update () {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit))
        {
            hitObject = hit.transform.gameObject;
            CursorColor cursCol = hitObject.GetComponent<CursorColor>();

            if (cursCol != null)
            {
                if (cursCol.display)
                {
                    Vector3 worldPos = Camera.main.ScreenToWorldPoint(
                        new Vector3(Input.mousePosition.x, Input.mousePosition.y, hit.distance));
                    hitObject.rigidbody.MovePosition(worldPos);
                }
            }
        }
        

	}
}
