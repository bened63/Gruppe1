﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class smartphone : MonoBehaviour {

	private float alpha = 0f;
	private float fadeSpeed = 0.8f;
	private float fadeDirection = -1f;
	private bool fade = false;

	void Start () {
		GameObject.FindGameObjectWithTag ("SmartphoneMessage").GetComponent<CanvasGroup> ().alpha = 0.0f;		
	}

	// Update is called once per frame
	void Update () {
		if (fade == true) {
			alpha += fadeDirection * fadeSpeed * Time.deltaTime;	
			alpha = Mathf.Clamp01(alpha);	
			GameObject.FindGameObjectWithTag ("SmartphoneMessage").GetComponent<CanvasGroup> ().alpha = alpha;
		}

		if (alpha == 1.0f && fadeDirection > 0) {
			fade = false;
			Invoke("displayMessage", 2);
		}

		if (alpha == 0.0f && fadeDirection < 0) {
			fade = false;
		}

		Debug.Log("Sichbarkeit: " + alpha);

	}

	public void displayMessage() {
		fade = !fade;
		fadeDirection = fadeDirection * (-1);
	}
}