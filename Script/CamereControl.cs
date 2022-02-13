using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereControl : MonoBehaviour
{
    GameObject cameraParent;
    Vector3 defaultPosition;
    Quaternion defaultRotation;
    float defaultZoom;
    public float minimumZoom;
    // Start is called before the first frame update
    void Start()
    {
        cameraParent = GameObject.Find("CameraParent");
        defaultPosition = Camera.main.transform.position;
        defaultRotation = cameraParent.transform.rotation;
        defaultZoom = Camera.main.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Camera.main.transform.Translate(Input.GetAxis("Mouse X") / 10, Input.GetAxis("Mouse Y") / 10, 0);
        }
        if (Input.GetMouseButton(1))
        {
            cameraParent.transform.Rotate(Input.GetAxis("Mouse Y") * 10, Input.GetAxis("Mouse X") * 10, 0);
        }
        Camera.main.fieldOfView += (20 * Input.GetAxis("Mouse ScrollWheel"));
        if(Camera.main.fieldOfView < minimumZoom)
        {
            Camera.main.fieldOfView = minimumZoom;
        }
        if(Input.GetMouseButton(2))
        {
            Camera.main.transform.position = defaultPosition;
            cameraParent.transform.rotation = defaultRotation;
            Camera.main.fieldOfView = defaultZoom;
        }
    }
}