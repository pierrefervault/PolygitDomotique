using UnityEngine;
using System.Collections;
using System;

public class ControllerCafe : ObjetConnect
{

    Animator anim;

    public override void execute(int idTache)
    {
        if (idTache == 0)
        {
            anim.SetBool("FaitCafé", false);
        }
        if (idTache == 1)
        {
            anim.SetBool("FaitCafé", true);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
