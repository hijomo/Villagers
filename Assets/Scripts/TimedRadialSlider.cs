using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TimedRadialSlider : MonoBehaviour
{


	public float timerLength;


	private float elapsTime;
	private Image sliderFillImage;
	public bool timerRunning;

	// Use this for initialization
	void Start ()
	{

		sliderFillImage = GetComponent<Image> ();
	}

	public void StartTimer (float length)
	{
		timerRunning = true;
		timerLength = length;
	}

	public void StopTimer ()
	{
		timerRunning = false;
		elapsTime = 0f;
		sliderFillImage.fillAmount = 0f;
	}

	// Update is called once per frame
	void Update ()
	{
		if (timerRunning) {
			elapsTime += Time.deltaTime;
			float angle = elapsTime / timerLength;
			sliderFillImage.fillAmount = angle;
		}
		if (elapsTime > timerLength) {
			StopTimer ();
		}

	}
}
