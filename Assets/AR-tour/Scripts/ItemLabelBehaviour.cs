using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemLabelBehaviour : MonoBehaviour {

    public Text Label;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Label.transform.LookAt(Camera.main.transform);
        //TODO always turn the label to the Camera

    }

    public void UpdatePositionAndLabel(Transform labelPositionTransform, string label = "")
    {
        //TODO update position of the label and label value
        
    }
}
