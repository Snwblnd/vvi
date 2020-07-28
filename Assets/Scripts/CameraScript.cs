using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{


    protected Transform _XForm_Camera;
    protected Transform _XFORM_Parent;

    protected Vector3 LocalRotation;
    protected float _CameraDistance = 10f;

    public float MouseSensivity = 4f;
    public float ScrollSensivity = 2f;
    public float OrbitDampening = 10f;
    public float ScrollDampening = 6f;

    public bool CameraDisabled = false;



    // Start is called before the first frame update
    void Start()
    {
        this._XForm_Camera = this.transform;
        this._XFORM_Parent = this.transform.parent;

        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CameraDisabled = !CameraDisabled;
        }

        Cursor.visible = CameraDisabled;

        if (!CameraDisabled)
        {
            

            if(Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {

                LocalRotation.x += Input.GetAxis("Mouse X") * MouseSensivity;
                LocalRotation.y -= Input.GetAxis("Mouse Y") * MouseSensivity;

                LocalRotation.y = Mathf.Clamp(LocalRotation.y, 0f, 90f);

            }


        }

        if(Input.GetAxis("Mouse ScrollWheel") != 0f)
            {
                float ScrollAmount = Input.GetAxis("Mouse ScrollWheel") * ScrollSensivity;

                ScrollAmount *= (this._CameraDistance * 0.3f);

                this._CameraDistance += ScrollAmount * -1f;

                this._CameraDistance = Mathf.Clamp(this._CameraDistance, 1.5f, 100f);

            }

        Quaternion QT = Quaternion.Euler(LocalRotation.y, LocalRotation.x, 0);
        this._XFORM_Parent.rotation = Quaternion.Lerp(this._XFORM_Parent.rotation, QT, Time.deltaTime * OrbitDampening);

        if(this._XForm_Camera.localPosition.z != this._CameraDistance * -1f)
        {
            this._XForm_Camera.localPosition = new Vector3(0f, 0f, Mathf.Lerp(this._XForm_Camera.localPosition.z, this._CameraDistance * -1f, Time.deltaTime * ScrollDampening));
        }
    }
}
