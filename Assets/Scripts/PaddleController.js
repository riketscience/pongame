var ypos:float;
var zpos:float = 0;
var xboundary:float = -12.5;
var speed:float = 80;
var maxbound:float = 20.0;
var roofPrefab:GameObject;
var roofRigidbody:Rigidbody;
var roof:GameObject;
var paddlesound:AudioClip;

function Start() {
    ypos = transform.position.y;
}

function Update () {
    if (Input.GetAxis("Horizontal") != 0)
    {
        transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime, ypos, zpos);

        if (transform.position.x < xboundary) {
            transform.position = new Vector3(xboundary, ypos, zpos);
        }
        if (transform.position.x > -xboundary) {
            transform.position = new Vector3(-xboundary, ypos, zpos);
        }
    }
}
