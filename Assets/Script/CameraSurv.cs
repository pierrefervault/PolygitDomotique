using UnityEngine;
using System.Collections;

public class CameraSurv : MonoBehaviour {

    public RenderTexture cameraTexture;
    public string nom;

	// Use this for initialization
	void Start () {
        cameraTexture = new RenderTexture(256,256,24);
        GetComponentInChildren<Camera>().targetTexture = cameraTexture;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
