using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

	public GameManager gameManager;
	public Slider slider;
	public float zoomValue = 1f;
	
    void Update() {
		
		zoomValue = slider.value * 5f + 1f;
        //Debug.Log(zoomValue);
    }
}
