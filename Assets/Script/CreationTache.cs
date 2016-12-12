using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

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
    public PanelLumiere lightInfos;

    public ObjetConnect[] objectList;

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
            heure.gameObject.SetActive(false);
            minute.gameObject.SetActive(false);

        }
        if (reccurence.value == 1)
        {
            foreach (Toggle t in jours)
            {
                t.gameObject.SetActive(false);
            }
            jour.gameObject.SetActive(false);
            mois.gameObject.SetActive(false);
            heure.gameObject.SetActive(true);
            minute.gameObject.SetActive(true);
        }
        if (reccurence.value == 2)
        {
            foreach (Toggle t in jours)
            {
                t.gameObject.SetActive(true);
            }
            jour.gameObject.SetActive(false);
            mois.gameObject.SetActive(false);
            heure.gameObject.SetActive(true);
            minute.gameObject.SetActive(true);
        }
        if (reccurence.value == 3)
        {
            foreach (Toggle t in jours)
            {
                t.gameObject.SetActive(false);
            }
            jour.gameObject.SetActive(true);
            mois.gameObject.SetActive(false);
            heure.gameObject.SetActive(true);
            minute.gameObject.SetActive(true);
        }
        if (reccurence.value == 4)
        {
            foreach (Toggle t in jours)
            {
                t.gameObject.SetActive(false);
            }
            jour.gameObject.SetActive(true);
            mois.gameObject.SetActive(true);
            heure.gameObject.SetActive(true);
            minute.gameObject.SetActive(true);
        }

    }

    public void OnEnable()
    {
        appareil.ClearOptions();
        objectList = GameObject.FindObjectsOfType<ObjetConnect>();
        List<string> objectsString = new List<string>();
        foreach (ObjetConnect o in objectList)
        {
            objectsString.Add(o.nomObjet);
        }
        appareil.AddOptions(objectsString);
        changeObject();
    }

    public void changeObject()
    {
        tache.ClearOptions();
        List<string> tachesString = new List<string>();
        foreach (TacheObjet t in objectList[appareil.value].taches)
        {
            tachesString.Add(t.nomTache);
        }
        tache.AddOptions(tachesString);
        changeTache();
    }

    public void changeTache()
    {
        if (objectList[appareil.value].taches[tache.value].needLightInfos)
        {
            lightInfos.gameObject.SetActive(true);
        }
        else
        {
            lightInfos.gameObject.SetActive(false);
        }
    }

    public void TaskOnClick()
    {
        if (reccurence.value == 0)
        {
            Tache newTask = (Tache)ScriptableObject.CreateInstance(typeof(Tache));
            newTask.cible = objectList[appareil.value];
            newTask.tacheObj = newTask.cible.taches[tache.value];
            newTask.nomTache = tache.GetComponentInChildren<Text>().text;
            newTask.recurrence = reccurence.GetComponentInChildren<Text>().text;
            newTask.statut = "Statut : en cours";
            newTask.enCours = true;
            newTask.temps = 120;
            GameObject.FindGameObjectWithTag("panelTache").GetComponent<AjoutTache>().addTacheInTaches(newTask);

        }
        if (reccurence.value == 1)
        {
            Tache newTask = (Tache)ScriptableObject.CreateInstance(typeof(Tache));
            newTask.nomTache = tache.GetComponentInChildren<Text>().text;
            newTask.recurrence = reccurence.GetComponentInChildren<Text>().text;
            newTask.statut = "Statut : en attente";
            newTask.temps = 120;
            GameObject.FindGameObjectWithTag("panelTache").GetComponent<AjoutTache>().addTacheInTaches(newTask);
        }
        if (reccurence.value == 2)
        {
            Tache newTask = (Tache)ScriptableObject.CreateInstance(typeof(Tache));
            newTask.nomTache = tache.GetComponentInChildren<Text>().text;
            newTask.recurrence = reccurence.GetComponentInChildren<Text>().text;
            newTask.statut = "Statut : en attente";
            newTask.temps = 120;
            GameObject.FindGameObjectWithTag("panelTache").GetComponent<AjoutTache>().addTacheInTaches(newTask);
        }
        if (reccurence.value == 3)
        {
            Tache newTask = (Tache)ScriptableObject.CreateInstance(typeof(Tache));
            newTask.nomTache = tache.GetComponentInChildren<Text>().text;
            newTask.recurrence = reccurence.GetComponentInChildren<Text>().text;
            newTask.statut = "Statut : en attente";
            newTask.temps = 120;
            GameObject.FindGameObjectWithTag("panelTache").GetComponent<AjoutTache>().addTacheInTaches(newTask);
        }
        if (reccurence.value == 4)
        {
            Tache newTask = (Tache)ScriptableObject.CreateInstance(typeof(Tache));
            newTask.nomTache = tache.GetComponentInChildren<Text>().text;
            newTask.recurrence = reccurence.GetComponentInChildren<Text>().text;
            newTask.statut = "Statut : en attente";
            newTask.temps = 120;
            GameObject.FindGameObjectWithTag("panelTache").GetComponent<AjoutTache>().addTacheInTaches(newTask);
        }
    }

}
