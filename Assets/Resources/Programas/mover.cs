using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {


    Vector3 Distance;
    float posicionX;
    float posicionY;

    private void OnMouseDown()
    {
        Distance = Camera.main.WorldToScreenPoint(transform.position);
        posicionX = Input.mousePosition.x - Distance.x;
        posicionY = Input.mousePosition.y - Distance.y;
    }

    private void OnMouseDrag()
    {
        Vector3 currentPosition = new Vector3(Input.mousePosition.x-posicionX, Input.mousePosition.y-posicionY, Distance.z);
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(currentPosition);
        transform.position = worldPosition;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
