using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PanelAlarmes : MonoBehaviour {

    public Dropdown alarmDrop;

    private Alarme[] alarmList;

    void OnEnable()
    {
        alarmDrop.ClearOptions();
        alarmList = FindObjectsOfType<Alarme>();
        List<string> alarmNames = new List<string>();
        foreach(Alarme al in alarmList)
        {
            alarmNames.Add(al.nom);
        }
        alarmDrop.AddOptions(alarmNames);
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void setOnAlarm()
    {
        alarmList[alarmDrop.value].setOn();
    }

    public void setOffAlarm()
    {
        alarmList[alarmDrop.value].setOff();
    }
}
