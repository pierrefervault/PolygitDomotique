using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreationTache : MonoBehaviour {

    public Dropdown appareil;
    public Dropdown tache;
    public Dropdown reccurence;
    public Dropdown mois;
    public Toggle[] jours;
    public Dropdown jour;
    public Dropdown heure;
    public Dropdown minute;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (reccurence.value == 0)
        {
            foreach (Toggle t in jours)
            {
                t.gameObject.SetActive(false);
            }
            jour.gameObject.SetActive(false);
            mois.gameObject.SetActive(false);

        }
        if (reccurence.value == 1)
        {
            foreach (Toggle t in jours)
            {
                t.gameObject.SetActive(true);
            }
            jour.gameObject.SetActive(false);
            mois.gameObject.SetActive(false);
        }
        if (reccurence.value == 2)
        {
            foreach (Toggle t in jours)
            {
                t.gameObject.SetActive(false);
            }
            jour.gameObject.SetActive(true);
            mois.gameObject.SetActive(false);
        }
        if (reccurence.value == 3)
        {
            foreach (Toggle t in jours)
            {
                t.gameObject.SetActive(false);
            }
            jour.gameObject.SetActive(true);
            mois.gameObject.SetActive(true);
        }

    }
}
