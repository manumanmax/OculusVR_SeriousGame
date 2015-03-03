using UnityEngine;
using System.Collections;

public class CameraGrabber : MonoBehaviour {
    public GameObject hitObject = null;
    private Ray ray;
    private RaycastHit hit;
    private 
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
                if (cursCol.dragOk)
                {
                    Vector3 worldPos = Camera.main.ScreenToWorldPoint(
                        new Vector3(Input.mousePosition.x, Input.mousePosition.y, hit.distance));
                    worldPos = new Vector3(worldPos.x, worldPos.y, hitObject.transform.position.z);
                    hitObject.rigidbody.MovePosition(worldPos);
                }
            }
        }
        

	}
}
