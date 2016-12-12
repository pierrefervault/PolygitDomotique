using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PanelCamera : MonoBehaviour {

    public Dropdown camerasDrop;

    private CameraSurv[] cameras;
    private RawImage cameraRender;

	// Use this for initialization
	void Start () {
        cameraRender = GetComponentInChildren<RawImage>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnEnable()
    {
        camerasDrop.ClearOptions();
        cameras = GameObject.FindObjectsOfType<CameraSurv>();
        List<string> nomsCameras = new List<string>();
        foreach(CameraSurv cs in cameras)
        {
            nomsCameras.Add(cs.nom);
        }
        camerasDrop.AddOptions(nomsCameras);
        changeCamera();
    }

    public void changeCamera()
    {
        cameraRender.texture = cameras[camerasDrop.value].cameraTexture;
    }
}
