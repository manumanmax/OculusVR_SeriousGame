using UnityEngine;
using System.Collections;

public class Movable : MonoBehaviour{
	private Transform t;
	private Vector3 mp;
	private Vector3 lastMousePos;
	private bool selected = false;
	public int ratio = 20;

	public Vector4 dropArea (){
		return new Vector4(0,0,0,0);
	}
	public Vector2 dropPoint(){
		return new Vector2 (0, 0);
	}

	void Start () {
		print ("movable");
		t = transform;
		mp = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			lastMousePos = Input.mousePosition;
			selected = true;
			//
		} 
		else if (Input.GetButtonUp ("Fire1")) {
			selected = false;
		}
		if (selected) {
			mp = Input.mousePosition;
			changePos(mp,t.position);
			//print (t.position);
		}
	}

	private void changePos(Vector3 mousePos, Vector3 objectPos){
		Vector3 movement = (mousePos - lastMousePos);
		movement.x = -movement.x;
		Vector3 v = objectPos + movement/ratio;
		lastMousePos = mousePos;
		v.z = objectPos.z;
		t.position = v;


	}
}


