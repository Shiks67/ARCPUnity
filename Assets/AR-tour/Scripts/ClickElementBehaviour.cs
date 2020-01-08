using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickElementBehaviour : MonoBehaviour
{
    public GameObject Label;
    private bool isSelected;
    private List<Color> oldColors = new List<Color>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print(gameObject.GetComponentInChildren<Canvas>());

        if (gameObject.GetComponentInChildren<Canvas>() != null && !isSelected)
        {
            foreach (Transform to in gameObject.transform.Find("Solides").transform)
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
            foreach (Transform to in gameObject.transform.Find("Solides").transform)
            {
                to.gameObject.GetComponent<Renderer>().material.color = oldColors[0];
                oldColors.RemoveAt(0);
            }
            isSelected = false;
        }

    }

    void OnMouseDown()
    {
        if (gameObject.transform.Find("ClickableSphere") != null)
        {
            gameObject.transform.Find("Solides").gameObject.SetActive(false);
            gameObject.transform.Find("SolidesDepthMask").gameObject.SetActive(true);
            gameObject.transform.Find("ClickableSphere").gameObject.SetActive(true);
            Label.GetComponent<ItemLabelBehaviour>().UpdatePositionAndLabel(gameObject.transform.parent, "");
        }
        else
        {
            if(isSelected)
            {
                Label.GetComponent<ItemLabelBehaviour>().UpdatePositionAndLabel(gameObject.transform.parent, "");
            }
            else
            {
                Label.GetComponent<ItemLabelBehaviour>().UpdatePositionAndLabel(gameObject.transform, gameObject.name.ToString());
            }
        }
    }
}
