using UnityEngine;
using System.Collections;

public class Screen : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

    void OnMouseDown()
    {
        //Debug.Log("Mouse Clicked");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlaceObjectRaycast(GameObject theObject)
    {
        Ray worldPosition = Camera.main.ViewportPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(worldPosition, out hit))
        {
            Instantiate(theObject, hit.point, Quaternion.identity);
            Debug.Log(theObject.name + " Created");
        }
    }
}
