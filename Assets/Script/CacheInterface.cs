using UnityEngine;
using System.Collections;

public class CacheInterface : MonoBehaviour {

    public string bouton;
    public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown(bouton))
        {
            target.SetActive(!target.active);
        }
	}
}
