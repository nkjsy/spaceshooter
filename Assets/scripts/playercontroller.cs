using UnityEngine;
using System.Collections;


public class playercontroller : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public float xmin,xmax,zmin,zmax;
	public float tilt;
	public GameObject shot;
	public Transform shotspawn;
	public float fireRate;
	private float nextFire;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetButton("Fire1")&&Time.time>nextFire)
		{
			nextFire=Time.time+fireRate;
			Instantiate (shot, shotspawn.position, shotspawn.rotation);
		}
	}

	void FixedUpdate()
	{
		float movehorizontal= Input.GetAxis("Horizontal");
		float movevertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (movehorizontal, 0.0f, movevertical);
		rb.velocity = movement*speed;
		rb.position = new Vector3 (Mathf.Clamp (rb.position.x, xmin,xmax), 0.0f, Mathf.Clamp (rb.position.z, zmin, zmax));

		rb.rotation = Quaternion.Euler (rb.velocity.z*-tilt*0.5f, 0.0f, rb.velocity.x*-tilt);

	}
}
