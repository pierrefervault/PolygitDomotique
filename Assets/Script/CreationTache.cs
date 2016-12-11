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
    public Button valider;

	// Use this for initialization
	void Start () {
        Button btn = valider.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
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

    public void TaskOnClick()
    {
        if (reccurence.value == 0)
        {
            Tache newTask = (Tache)ScriptableObject.CreateInstance(typeof(Tache));
            newTask.nomTache = tache.GetComponentInChildren<Text>().text;
            newTask.recurrence = reccurence.GetComponentInChildren<Text>().text;
            newTask.statut = "Statut : en attente";
            newTask.temps = 120;
            GameObject.FindGameObjectWithTag("panelTache").GetComponent<AjoutTache>().addTacheInTaches(newTask);

        }
        if (reccurence.value == 1)
        {
           
        }
        if (reccurence.value == 2)
        {

        }
        if (reccurence.value == 3)
        {

        }
    }

}
