using UnityEngine;
using System.Collections;

public class mainCam : MonoBehaviour {

	public GameObject focalPoint;
    private float speedMod = 0.25f;
    private Vector3 point;

    void Start()
    {
        point = focalPoint.transform.position;  //get target's coords
        transform.LookAt(point);                //and make camera look to it 
    }

    void Update()
    {
        //make the camera rotate around "point" coords, rotating around its Y axis, 20 degrees per second times the speed modifier
        transform.RotateAround(point, new Vector3(0.0f,1.0f,1.0f), 20 * Time.deltaTime * speedMod);
    }
}
