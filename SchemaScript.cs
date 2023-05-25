using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchemaScript : MonoBehaviour {
	
	public GameManager gameManager;
	public GameObject schema0;
	public GameObject schema1;
	public GameObject schema2;
	public GameObject schema3;
	GameObject [] schemas;
	int currentFloor = 1;
	
    void Start() {
        
		schemas = new GameObject [] {schema0, schema1, schema2, schema3};
    }


    void Update() {
        
		if (gameManager.textInputScript.floor != currentFloor) {
			currentFloor = gameManager.textInputScript.floor;
			foreach (GameObject schema in schemas) schema.SetActive(false);
			schemas[currentFloor - 1].SetActive(true);
			
		}
		transform.localScale = new Vector3(gameManager.sliderScript.zoomValue, gameManager.sliderScript.zoomValue, 1f);
		//Debug.Log(currentFloor);
    }
}
