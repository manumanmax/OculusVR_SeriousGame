using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Dragable : MonoBehaviour
{

	public Camera cam  ;
	private Rigidbody myRigidbody ;
	private Transform myTransform  ;
	private bool canMove = false;
	private GameObject workArea;
	private Transform camTransform ;
	
	void Start () 
	{
		workArea = GameObject.Find ("workArea");
		print (workArea);
		myRigidbody = rigidbody;
		myTransform = transform;
		if (!cam) 
		{
			cam = Camera.main;
		}
		if (!cam) 
		{
			Debug.LogError("Can't find camera tagged MainCamera");
			return;
		}
		camTransform = cam.transform;
		//sqrMoveLimit = moveLimit * moveLimit;   // Since we're using sqrMagnitude, which is faster than magnitude
	}
	
	void OnMouseDown () 
	{
		canMove = true;
	}
	
	void OnMouseUp () 
	{
		canMove = false;
	}
	
	void FixedUpdate () 
	{
		if (!canMove)
		{
			return;
		}

		Vector3 mousePos = Input.mousePosition;
		Vector3 move = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, camTransform.position.y - myTransform.position.y)) - myTransform.position;

		//transform.position = (myRigidbody.position + move);
		//myRigidbody.MovePosition(myRigidbody.position + move);
	}
}
