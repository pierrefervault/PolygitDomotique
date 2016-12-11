using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class ObjetConnect : MonoBehaviour {

    public string nomObjet;
    public List<TacheObjet> taches;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    abstract public void execute(int idTache);
}
