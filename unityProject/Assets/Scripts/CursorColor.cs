using UnityEngine;
using System.Collections;

public class CursorColor : MonoBehaviour {
	public int size = 6;
	public GameObject otherGameObject;

	private Texture2D t;
	private Variables vars;
	private bool display = true;


	private void Awake () {
		//vars = GameObject.Find ("variables");
		//print (vars);
		t = new Texture2D(size, size, TextureFormat.RGB24, true);
		t.name = "Procedural Texture";
		FillTexture(Color.green);
	}

	public void OnMouseEnter () {
		print ("enter");
        //if(display)
		    Cursor.SetCursor(t, Vector2.zero, CursorMode.ForceSoftware);
	}

	public void OnMouseExit() {
		print ("exit");
		if(!display)
			Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
	}

	void OnMouseDown () 
	{
		display = true;
	}
	
	void OnMouseUp () 
	{
		display = false;
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
	}
	
	private void FillTexture (Color color) {
		for (int y = 0; y < size; y++) {
			for (int x = 0; x < size; x++) {
				t.SetPixel(x, y, color);
			}
		}
		t.Apply();
	}
}
