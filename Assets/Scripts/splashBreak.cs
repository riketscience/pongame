using UnityEngine;
using System.Collections;

public class splashBreak : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.AddComponent< Rigidbody > ();
                var rb = cube.GetComponent< Rigidbody > ();

                cube.transform.position = new Vector3(x, y, 0);
                rb.AddForce(0, 1000, -1200);
                //rb.AddExplosionForce(10.0F, transform.position, 5.0F, 3.0F);
            }
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
