﻿using UnityEngine;
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

    private ReservoirNotifs notifs;

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
			GameObject panel = GameObject.FindGameObjectWithTag("panelTache");
            if (panel != null)
            {
                panel.GetComponent<AjoutTache>().updateProgress(this);
            }
            if (timer >= temps)
            {
                if (tacheObj.notif != null)
                {
                    notifs = FindObjectOfType<ReservoirNotifs>();
                    notifs.notifs.Add(tacheObj.notif);
                    AjoutNotification notifPanel = FindObjectOfType<AjoutNotification>();
                    if(notifPanel != null)
                    {
                        notifPanel.updateNotifs();
                    }
                }
                if (tacheObj.sendMessageAtEnd)
                {
                    cible.execute(tacheObj.idTacheEnd);
                }
                if(panel != null)
                {
                    panel.GetComponent<AjoutTache>().removeTacheInPanel(this);
                }
                FindObjectOfType<ReservoirTaches>().taches.Remove(this);
                Destroy(this);
            }
        }
	}
}
