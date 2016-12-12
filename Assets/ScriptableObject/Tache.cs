using UnityEngine;
using UnityEngine.UI;

using System.Collections;

[CreateAssetMenu]
public class Tache : ScriptableObject {

    public string nomTache;
    public string statut;
    public bool enCours;
    public bool started;
    public string recurrence;
    public TacheObjet tacheObj;
    public ObjetConnect cible;
    public int temps;

    private int timer;

	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	public void Update () {
        if (enCours)
        {
            if (!started)
            {
                cible.execute(tacheObj.idTache);
                started = true;
            }
            timer++;
            if(timer >= temps)
            {
                Destroy(this);
            }
        }
	}
}
