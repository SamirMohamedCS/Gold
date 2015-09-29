using UnityEngine;
using System.Collections;

public class Cameracontrol : MonoBehaviour {
	public Transform lilSanic;
	public Transform bigSanic;
	Transform cameraTransform;
	public Transform transitionTransform;
	Vector3 cameraDistance, cameraDistance2;
	bool transitioned;

	// Use this for initialization
	void Start () 
	{
		cameraTransform = gameObject.GetComponent<Transform> ();
		Time.timeScale = 2f;
		cameraDistance = new Vector3 (27.5f, 10f, -20f);
		cameraDistance2 = new Vector3 (200f, 100f, -140f);
		transitioned = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (lilSanic.position.y < -560)
			transitioned = true;

		if (!transitioned)
			cameraTransform.position = lilSanic.position + cameraDistance;
		else
		{
			cameraTransform.position = bigSanic.position + cameraDistance2;
			cameraTransform.rotation = transitionTransform.rotation;
		}
	}
}
