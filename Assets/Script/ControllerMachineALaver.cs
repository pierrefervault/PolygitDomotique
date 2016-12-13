using UnityEngine;
using System.Collections;
using System;

public class ControllerMachineALaver : ObjetConnect {

    Animator anim;

    public override void execute(int idTache)
    {
        if (idTache == 0)
        {
            anim.SetBool("enMarche", false);
        }
        if (idTache == 1)
        {
            anim.SetBool("enMarche", true);
        }
    }

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
