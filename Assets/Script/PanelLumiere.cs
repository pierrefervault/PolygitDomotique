using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelLumiere : MonoBehaviour {

    public CreationTache owner;
    public RawImage preview;
    public Slider RSlide;
    public Slider GSlide;
    public Slider BSlide;
    public Slider ISlide;

    private ControllerLamp cible;
    private Tache tache;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        refreshPreview();
	}

    void OnEnable()
    {
        if(owner.objectList.Length > 0)
        {
            cible = (ControllerLamp)owner.objectList[owner.appareil.value];
        }
        //owner.objectList[owner.appareil.value].taches[owner.tache.value]
    }

    void refreshPreview()
    {
        preview.color = new Color(RSlide.value, GSlide.value, BSlide.value);
        cible.r = RSlide.value;
        cible.g = GSlide.value;
        cible.b = BSlide.value;
        cible.intens = ISlide.value;
    }
}
