using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class CameraPlayPauseBehaviour : MonoBehaviour
{
    public Camera ARCamera;
    public Toggle CameraToggle;

    private int previousCullingMask;
    private CameraClearFlags previousClearFlags;

    // Start is called before the first frame update
    void Start()
    {
        //Add listener for when the state of the Toggle changes, to take action
        CameraToggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChanged();
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayPauseCamera(bool CameraIsOn)
    {
        print(CameraIsOn);
        if (CameraIsOn)
        {
            CameraDevice.Instance.Start();
        }
        else
        {
            CameraDevice.Instance.Stop();
        }
    }

    public void ToggleValueChanged()
    {
        PlayPauseCamera(CameraToggle.isOn);
    }
}
