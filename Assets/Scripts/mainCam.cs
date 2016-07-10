using UnityEngine;
using System.Collections;

public class mainCam : MonoBehaviour {

	public float moveRate; 
	private int startat = -22;
	public GameObject focalPoint;
    public Camera mainCamera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		startat-=1;
        mainCamera.transform.position = new Vector3(0, 0, startat );
    }
}
