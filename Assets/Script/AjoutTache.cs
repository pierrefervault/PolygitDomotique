using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AjoutTache : MonoBehaviour {

    public Text[] nomTaches;
    public Text[] statuts;
    public Text[] recurrences;
    public Tache[] taches;

    // Use this for initialization
    void Start()
    {
        foreach (Tache t in taches)
        {
            addTache(t);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void addTache(Tache t)
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
}