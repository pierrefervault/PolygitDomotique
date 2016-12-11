using UnityEngine;
using UnityEngine.UI;

using System.Collections;

[CreateAssetMenu]
public class Notification : ScriptableObject
{

    public Sprite[] images;
    public int importance;
    public string texte;
    public Sprite image;

    // Use this for initialization
    void Start()
    {
        if (importance == 0)
        {
            image = images[0];
        }
        if (importance == 1)
        {
            image = images[1];
        }
        if (importance == 2)
        {
            image = images[2];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}