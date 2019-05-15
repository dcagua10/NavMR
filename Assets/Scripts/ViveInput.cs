using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveInput : MonoBehaviour {

    public SteamVR_Action_Vector2 touchPadAction;
    [SerializeField]
    private GameObject rig;
    private GameObject camera;
    private int speed = 2;

    private SteamVR_TrackedObject trackedObj;

    private Vector2 axis = Vector2.zero;

    void Start()   
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
	void Update ()
    {

        rig = GameObject.Find("Control");
        camera = GameObject.Find("Camera");

        if (rig == null)
        {
            print("Objeto no Encontrado"); 
        }

        Vector2 touchpadValue = touchPadAction.GetAxis(SteamVR_Input_Sources.Any);

        if (touchpadValue != axis)
        {
            print("Valor del touchpad: " + touchpadValue);
            float xAdd = touchpadValue.x;
            float zAdd = touchpadValue.y;
            Vector3 posAct = rig.transform.localPosition;
            Vector3 vectorAdd = new Vector3(xAdd, 0.0f, zAdd);
            Vector3 newPos = posAct + vectorAdd;

            rig.transform.position = rig.transform.position + camera.transform.forward * touchpadValue.y * speed * Time.deltaTime;
            float x = rig.transform.position.x;
            float y = rig.transform.position.y;
            float z = rig.transform.position.z;
            if (y != 0)
            {
                Vector3 reset = new Vector3(x, 0.0f, z);
                rig.transform.position = reset;
            }
        }
		
	}
}
