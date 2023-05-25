using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraControlScript : MonoBehaviour {

	public GameManager gameManager;
	float scrollSpeed = .0075f;
	Vector2 deltaPos;
	Vector3 newPos = new Vector3(0f, 0f, 0f);
	
    void Start() {
        
    }

    void Update() {
        
		int touchesCounter = 0;
		foreach(Touch touch in Input.touches) {
			touchesCounter++;
		}
		foreach(Touch touch in Input.touches) {
			if (touchesCounter == 1 && touch.position.x > 200f) {
				deltaPos = touch.deltaPosition * scrollSpeed / gameManager.sliderScript.zoomValue;
				//deltaPos = Vector2.ClampMagnitude(touch.deltaPosition, swipeSpeed * Time.deltaTime);
				newPos = new Vector3(Mathf.Clamp(newPos.x - deltaPos.x, -2.8284f, 2.8284f), Mathf.Clamp(newPos.y - deltaPos.y, -2f, 2f), 0f);
			}
		}
		
		transform.position = newPos * gameManager.sliderScript.zoomValue;
		gameManager.schemaScript.transform.localScale = new Vector3(gameManager.sliderScript.zoomValue, gameManager.sliderScript.zoomValue, 1f);
    }
}
