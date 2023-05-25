using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class TextInputScript : MonoBehaviour {
	
    public TMPro.TMP_Dropdown dropdownField;
	public int floor = 1;
	
    void Start() {
        
    }

    
    void Update() {
        
		floor = 4 - dropdownField.value;
    }
}
