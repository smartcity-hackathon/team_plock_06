using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tworze_obiekt : MonoBehaviour {

	public sortowanie sortowanie_script;
	public GameObject[] tablica = new GameObject[20];
	public int aktualny=0;
	public GameObject prefab;
	public Transform parent;
	public RectTransform cel;
	public Vector3 przesun;
	
	public GameObject info_script;
	
	//przykladowe zdj 

	// Use this for initialization
	void Start () 
	{

	}
	
	public void spam(int Z,Texture zdjecie,string tag_glowny, string tag_pobocz, string nazwa, string opis,string cecha1,string opis1,string cecha2,string opis2,string cecha3,string opis3,string cecha4,string opis4,string cecha5,string opis5)
	{
		Debug.Log("z: "+Z);
		objekt objekt_script;
		GameObject rzecz;
		rzecz = Instantiate(prefab, cel.position+ przesun*aktualny, cel.rotation, parent);
		objekt_script = rzecz.GetComponent<objekt>();
		objekt_script.glowny_tag = tag_glowny;
		objekt_script.poboczny_tag = tag_pobocz;
		objekt_script.nazwa_ob =nazwa;
		objekt_script.cecha1 = cecha1;
		objekt_script.opis1 = opis1;
		objekt_script.cecha2 = cecha2;
		objekt_script.opis2 =opis2;
		objekt_script.cecha3 =cecha3;
		objekt_script.opis3=opis3;
		objekt_script.cecha4=cecha4;
		objekt_script.opis4=opis4;
		objekt_script.cecha5 =cecha5;
		objekt_script.opis5=opis5;
		objekt_script.ogolny_opis = opis;
		objekt_script.zdj = zdjecie;
		objekt_script.z =Z;
		objekt_script.info = info_script;
		objekt_script.przypisz();
		if(Z==0)sortowanie_script.znalazl(rzecz);
		else sortowanie_script.zgubil(rzecz);
		aktualny++;
	}
}
