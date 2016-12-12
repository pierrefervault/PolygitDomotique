using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class AjoutTache : MonoBehaviour {

    public Text[] nomTaches;
    public Text[] statuts;
    public Text[] recurrences;
    public List<Tache> taches;

    // Use this for initialization
    void Start()
    {
        foreach (Tache t in taches)
        {
            addTacheInPanel(t);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Tache t in taches)
        {
            t.Update();
        }
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

    public void addTacheInTaches(Tache t)
    {
        taches.Add(t);
        addTacheInPanel(t);
    }
}