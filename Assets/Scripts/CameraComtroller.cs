using UnityEngine;
using System.Collections;

public class CameraComtroller : MonoBehaviour
{

	public float translationSpeed;
	private Transform tran;
	// Use this for initialization
	void Start ()
	{
		tran = GetComponent<Transform> ();
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 cameraTranslationDirection = Vector3.zero;
		cameraTranslationDirection.z = Input.GetAxis ("Vertical") * Time.deltaTime;
		cameraTranslationDirection.x = Input.GetAxis ("Horizontal") * Time.deltaTime;
		cameraTranslationDirection = Vector3.Normalize (cameraTranslationDirection);
		tran.Translate (cameraTranslationDirection * translationSpeed, Space.World);

	}
}
