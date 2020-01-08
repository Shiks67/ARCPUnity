using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickablePoint : MonoBehaviour
{
    public GameObject Label;
    public GameObject Solides;
    public GameObject SolidesDepthMask;
    public Color SphereColor;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = SphereColor;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        gameObject.SetActive(false);
        SolidesDepthMask.SetActive(false);
        Solides.SetActive(true);
        Label.GetComponent<ItemLabelBehaviour>().UpdatePositionAndLabel(gameObject.transform.parent.gameObject.transform, gameObject.transform.parent.gameObject.name);
    }
}
