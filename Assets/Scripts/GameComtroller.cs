using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GameComtroller : MonoBehaviour
{

	public List<Material> materials;
	public List<GameObject> actors;
	public List<GameObject> resources;
	public GameObject actor;
	public GameObject resource;

	// Use this for initialization
	void Start ()
	{
	
	}

	void createActor (Vector3 location)
	{
		GameObject obj = (GameObject)Instantiate (actor, location, Quaternion.identity);
		actors.Add (obj);

	}
	void createResource (Vector3 location, Material newMaterial)
	{
		GameObject obj = (GameObject)Instantiate (resource, location, Quaternion.identity);
		resources.Add (obj);
		obj.GetComponent<MeshRenderer> ().material = newMaterial;

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			Vector3 loc = Random.onUnitSphere * 20f;
			loc.y = 1.5f;
			createActor (loc);
		}

	}
}
