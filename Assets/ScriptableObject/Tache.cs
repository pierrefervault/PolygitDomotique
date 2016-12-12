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

    public int timer;

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
			GameObject.FindGameObjectWithTag("panelTache").GetComponent<AjoutTache>().updateProgress(this);
            if(timer >= temps)
            {
				GameObject.FindGameObjectWithTag("panelTache").GetComponent<AjoutTache>().removeTacheInPanel(this);
                Destroy(this);
            }
        }
	}
}
