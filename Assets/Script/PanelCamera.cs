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

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnEnable()
    {
        cameraRender = GetComponentInChildren<RawImage>();
        camerasDrop.ClearOptions();
        cameras = GameObject.FindObjectsOfType<CameraSurv>();
        List<string> nomsCameras = new List<string>();
        foreach(CameraSurv cs in cameras)
        {
            nomsCameras.Add(cs.nom);
        }
        camerasDrop.AddOptions(nomsCameras);
        cameraRender.texture = cameras[0].cameraTexture;
    }

    public void changeCamera()
    {
        cameraRender.texture = cameras[camerasDrop.value].cameraTexture;
    }
}
