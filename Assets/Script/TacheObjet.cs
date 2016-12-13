using UnityEngine;
using System.Collections;

[CreateAssetMenu]
public class TacheObjet : ScriptableObject {

    public string nomTache;
    public int idTache; //Doit être unique entre les tâches d'un objet donné
    public bool needLightInfos;
    public bool sendMessageAtEnd;
    public Notification notif;
    public int idTacheEnd;
    public int temps; //En secondes

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
