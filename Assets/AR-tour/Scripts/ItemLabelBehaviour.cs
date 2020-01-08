using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemLabelBehaviour : MonoBehaviour {

    public Canvas CanvasLabel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CanvasLabel.transform.LookAt(Camera.main.transform.position);
        //TODO always turn the label to the Camera

    }

    public void UpdatePositionAndLabel(Transform labelPositionTransform, string label = "")
    {
        if(label != "")
        {
            gameObject.transform.SetParent(labelPositionTransform);
            CanvasLabel.GetComponentInChildren<Text>().text = label;
            gameObject.transform.localPosition = new Vector3(0,-0.2f,0.3f);
            print(label);
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
