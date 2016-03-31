using UnityEngine;
using System.Collections;

public class destroybycontact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerexplosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if ((other.tag) == "Boundary") {
			return;
		}

		Instantiate (explosion, transform.position, transform.rotation);
		if (other.tag=="Player")
		{
			Instantiate (playerexplosion, other.transform.position, other.transform.rotation);
		}
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
