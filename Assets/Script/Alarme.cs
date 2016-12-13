using UnityEngine;
using System.Collections;

public class Alarme : MonoBehaviour {

    public string nom;
    public Color onColor;
    public Color offColor;

    private Light lumiere;

	// Use this for initialization
	void Start () {
        lumiere = GetComponentInChildren<Light>();
        lumiere.color = onColor;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void setOn()
    {
        lumiere.color = onColor;
    }

    public void setOff()
    {
        lumiere.color = offColor;
    }
}
