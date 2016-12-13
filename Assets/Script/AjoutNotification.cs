using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AjoutNotification : MonoBehaviour {

    public Image[] images;
    public Text[] texts;

    private ReservoirNotifs notifs;

	void OnEnable() {
        updateNotifs();
	}
	
    public void updateNotifs()
    {
        notifs = FindObjectOfType<ReservoirNotifs>();
        clearNotifs();
        foreach (Notification n in notifs.notifs)
        {
            addNotif(n);
        }
    }

	// Update is called once per frame
	void Update () {
    }

    public void supprimer(int num)
    {
        notifs.notifs.RemoveAt(num);
        updateNotifs();
    }

    void clearNotifs()
    {
        for (int i = 0; i < this.images.Length; i++)
        {
            images[i].sprite = null;
            texts[i].text = null;
        }
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
