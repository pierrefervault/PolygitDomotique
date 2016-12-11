using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AjoutNotification : MonoBehaviour {

    public Image[] images;
    public Text[] texts;
    public Notification[] notifications;

	// Use this for initialization
	void Start () {
	    foreach(Notification n in notifications)
        {
            addNotif(n);
        }
	}
	
	// Update is called once per frame
	void Update () {
    }

    void addNotif(Notification n)
    {
        for (int i = 0; i < this.images.Length; i++)
        {
            if (images[i].sprite == null)
            {
                images[i].sprite = n.image;
                texts[i].text = n.texte;
                i = this.images.Length;
            }
        }
    }
}
