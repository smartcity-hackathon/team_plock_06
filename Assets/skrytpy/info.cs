using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class info : MonoBehaviour {

	public string n1; 
	public string n2;
	public string n3;
	public string opis;
	public Texture zdjecie;
	
	public GameObject to;
	public Text t1;
	public Text t2;
	public Text t3;
	public Text t4;
	public RawImage zdj;
	public void wyswietl()
	{
		to.SetActive(true);
		zdj.texture = zdjecie;
		t1.text = n1;
		t2.text = n2;
		t3.text = n3;
		t4.text = opis;
	}
	
	public void koncz()
	{
		to.SetActive(false);
	}
}
