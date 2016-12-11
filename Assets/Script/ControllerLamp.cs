using UnityEngine;
using System.Collections;
using System;

public class ControllerLamp : ObjetConnect {

    public float r;
    public float g;
    public float b;
    public float intens;

    private float baseIntens;
    private Light light;

    public override void execute(int idTache)
    {
        if (idTache == 0) //Eteindre
        {
            light.intensity = 0;
        }
        if (idTache == 1) //Allumer
        {
            light.intensity = baseIntens;
        }
        if (idTache == 2) //Modification lumière
        {
            baseIntens = intens;
            light.intensity = intens;
            light.color = new Color(r, g, b);
        }
    }

    // Use this for initialization
    void Start () {
        light = GetComponentInChildren<Light>();
        baseIntens = light.intensity;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
