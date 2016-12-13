using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class CacheInterface : MonoBehaviour {

    public string bouton;
    public GameObject target;
    public FirstPersonController targetScript; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown(bouton))
        {
            target.SetActive(!target.active);
            targetScript.enabled = !target.active;
        }
	}
}
