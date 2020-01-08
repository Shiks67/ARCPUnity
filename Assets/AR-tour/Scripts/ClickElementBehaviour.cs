using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickElementBehaviour : MonoBehaviour
{
    private GameObject Label;
    private bool isSelected;
    private List<Color> oldColors = new List<Color>();

    // Start is called before the first frame update
    void Start()
    {
        Label = GameObject.Find("ItemLabel");
    }

    // Update is called once per frame
    void Update()
    {
        print(gameObject.GetComponentInChildren<Canvas>());

        if (gameObject.GetComponentInChildren<Canvas>() != null && !isSelected)
        {
            foreach (Transform to in gameObject.transform)
            {
                if (to.gameObject.name != "ItemLabel")
                {
                    oldColors.Add(to.gameObject.GetComponent<Renderer>().material.color);
                    to.gameObject.GetComponent<Renderer>().material.color = Color.red;
                }
            }
            isSelected = true;
        }
        else if (gameObject.GetComponentInChildren<Canvas>() == null && isSelected)
        {
            foreach (Transform to in gameObject.transform)
            {
                to.gameObject.GetComponent<Renderer>().material.color = oldColors[0];
                oldColors.RemoveAt(0);
            }
            isSelected = false;
        }

    }

    void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        Label.GetComponent<ItemLabelBehaviour>().UpdatePositionAndLabel(gameObject.transform, gameObject.name.ToString());
        foreach (Transform to in gameObject.transform)
        {
            print(to.gameObject.name);
            // to.gameObject.
        }
    }
}
