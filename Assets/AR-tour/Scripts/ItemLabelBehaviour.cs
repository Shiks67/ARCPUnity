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
        Label.transform.LookAt(2* transform.position - Camera.main.transform.position);
        //TODO always turn the label to the Camera

    }

    public void UpdatePositionAndLabel(Transform labelPositionTransform, string label = "")
    {
        gameObject.transform.SetParent(labelPositionTransform);
        Label.text = label;
        gameObject.transform.localPosition = new Vector3(0,-.3f,0);
        print(label);
    }
}
