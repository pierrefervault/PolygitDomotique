using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class AjoutTache : MonoBehaviour {

    public Text[] nomTaches;
    public Text[] statuts;
    public Text[] recurrences;
	public Slider[] sliders;
    public ReservoirTaches taches;

    // Use this for initialization
    void Start()
    {
        foreach (Tache t in taches.taches)
        {
            addTacheInPanel(t);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addTacheInPanel(Tache t)
    {
        for (int i = 0; i < this.nomTaches.Length; i++)
        {
            if (nomTaches[i].text.Equals(""))
            {
                nomTaches[i].text = t.nomTache;
                statuts[i].text = t.statut;
                recurrences[i].text = t.recurrence;
                i = this.nomTaches.Length;
            }
        }
    }
	public void removeTacheInPanel(Tache t){
		for (int i = 0; i < this.nomTaches.Length; i++)
		{
			if (nomTaches[i].text.Equals(t.nomTache))
			{
				nomTaches[i].text = "";
				statuts[i].text = "";
				recurrences[i].text = "";
				sliders [i].value = 0;

			}
		}
	}

    public void addTacheInTaches(Tache t)
    {
        taches.taches.Add(t);
        addTacheInPanel(t);
    }
	public void updateProgress(Tache t)
	{
		for (int i = 0; i < this.nomTaches.Length; i++)
		{
			if (nomTaches[i].text.Equals(t.nomTache))
			{
				sliders [i].value = (t.timer * 1.0f) / (t.temps * 1.0f);

			}
		}
	}
}