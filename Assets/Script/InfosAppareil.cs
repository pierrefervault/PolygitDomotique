using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfosAppareil : MonoBehaviour {
	public Button btnLaveuse;
	public Button btnAspirateur;
	public Button btnCafe;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AfficherInfosAppareil(string nom){
		GameObject.Find ("PanelGererAppareils").SetActive (false);
		btnLaveuse.gameObject.SetActive (false);

		btnCafe.gameObject.SetActive (false);
		btnAspirateur.gameObject.SetActive (false);
		gameObject.SetActive (true);
		GameObject.Find ("InfosAppareil_nom").GetComponent<Text> ().text = nom;

		if (nom.Equals ("Laveuse")) {
			GameObject.Find ("InfosAppareil_description").GetComponent<Text> ().text = "État : Fonctionnelle\nTâches : Lavage\nTemps restants : 22 min.";
			btnLaveuse.gameObject.SetActive (true);
		}
		else if (nom.Equals ("Cafétière")) {
			GameObject.Find ("InfosAppareil_description").GetComponent<Text> ().text = "État : Fonctionnelle\nTâches : Aucune\nCafés restants : 3";
			btnCafe.gameObject.SetActive (true);
		}
		else if (nom.Equals ("Sècheuse")) {
			GameObject.Find ("InfosAppareil_description").GetComponent<Text> ().text = "État : Fonctionnelle\nTâches : Sèchage\nTemps restants : 17 min.";
		}
		else if (nom.Equals ("Aspirateur")) {
			GameObject.Find ("InfosAppareil_description").GetComponent<Text> ().text = "État : Fonctionnelle\nTâches : Nettoyage\nTemps restants : 32 min.";
			btnAspirateur.gameObject.SetActive (true);
		}

	}
}
