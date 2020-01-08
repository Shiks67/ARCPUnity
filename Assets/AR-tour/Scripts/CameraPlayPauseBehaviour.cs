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

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayPauseCamera(bool CameraIsOn)
    {
        if(CameraIsOn)
        {
            /*CameraDevice.Instance.Start();
            ObjectTracker imgTracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
            imgTracker.Start();*/
            Time.timeScale = 1;
            ARCamera.clearFlags = previousClearFlags;
            ARCamera.cullingMask = previousCullingMask;
        }
        else
        {
            /*CameraDevice.Instance.Stop();
            ObjectTracker imgTracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
            imgTracker.Stop();*/
            Time.timeScale = 0;
            previousCullingMask = ARCamera.cullingMask;
            previousClearFlags = ARCamera.clearFlags;
            ARCamera.clearFlags = CameraClearFlags.Nothing;
            ARCamera.cullingMask = 0;
        }
    }

    public void ValueChanged()
    {
        PlayPauseCamera(CameraToggle.isOn);
    }
}
