using UnityEngine;
using System.Collections.Generic;

public class CreateObjects : MonoBehaviour {
	public List<GameObject> lObjects = new List<GameObject> ();


	// Use this for initialization
	void Start () {
		for(int i = 0; i < 3; i++){
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = new Vector3((float)(15-(i*1.5)), 1, -2);
			cube.AddComponent<CursorColor>();
			Rigidbody r = new Rigidbody();
			cube.AddComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionZ;;
			cube.AddComponent<BoxCollider>();
			cube.AddComponent<Dragable>();
			lObjects.Add(cube);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
