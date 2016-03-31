using UnityEngine;
using System.Collections;

public class gamecontroller : MonoBehaviour {

	public GameObject hazards;
	public Vector3 spawnvalues;
	public int hazardcount;
	public float spawnwait;
		// Use this for initialization
	void Start () {
	
		spawnwaves ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void spawnwaves()
	{
		for (int i=0;i<hazardcount;i++)
		{
		Vector3 spawnposition = new Vector3 (Random.Range (-spawnvalues.x, spawnvalues.x), spawnvalues.y, spawnvalues.z);
		Quaternion spawnrotation = Quaternion.identity;
		Instantiate(hazards,spawnposition,spawnrotation);

		}
	}
}
