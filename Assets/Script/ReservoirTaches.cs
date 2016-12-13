using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReservoirTaches : MonoBehaviour {

    public List<Tache> taches;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Tache t in taches)
        {
            t.Update();

        }
    }
}
