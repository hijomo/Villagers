using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WheatFarmController : MonoBehaviour
{

	public GameObject wheat;

	public List<GameObject> inventory;
	public TimedRadialSlider timerScript;
	public float timerLength;
	public int maxWheatToStock;
	private float timerComplete;
	private bool makingWheat;
	private Transform trans;
	private Vector3 spawnPoint = new Vector3 (0, 10f, 0);



	void Awake ()
	{
		timerScript = GetComponentInChildren<TimedRadialSlider> ();
		trans = GetComponent<Transform> ();
	}

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if (CountResource ("Wheat") < maxWheatToStock && !makingWheat) {
			timerScript.StartTimer (timerLength);
			makingWheat = true;
			timerComplete = Time.time + timerLength;
		}

		if (makingWheat && Time.time > timerComplete) {
			makingWheat = false;
			CreatWheat ();
		}



		Debug.Log (CountResource ("Wheat"));
	}

	void CreatWheat ()
	{
		GameObject obj = (GameObject)Instantiate (wheat,
		                                          trans.position + spawnPoint,
		                                          Quaternion.identity);
		obj.name = "Wheat";
		inventory.Add (obj);
	}

	int CountResource (string resource)
	{
		int count = 0;
		foreach (GameObject item in inventory) {
			if (item.name == resource)
				count++;
		}
		return count;
	}

}
