using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wskazowki : MonoBehaviour {


	public string dowod;
	public dodawanie dodawanie_script;
	
	public GameObject karta;
	public GameObject dowod_oso;
	
	public GameObject kartaZ;
	public GameObject dowod_osoZ;
	
	public GameObject rzecz;
	public GameObject opis;
	public GameObject dupa;
	public GameObject zadowolony;
	
	public bool on = false;
	
	// 1 - dowod
	
	public void wskaz(int x)
	{
		on = true;
		rzecz.SetActive(true);
		opis.SetActive(false);
		dupa.SetActive(true);
		zadowolony.SetActive(false);
		if(x==1)
		{
			Debug.Log(" iks 1 ");
			if(dodawanie_script.z==1)
			{
				Debug.Log(" z 1 ");
			karta.SetActive(true);
			dowod_oso.SetActive(false);
			}
			else
			{
				Debug.Log(" z 0 ");
			kartaZ.SetActive(true);
			dowod_osoZ.SetActive(false);		
			}
		}	
		else if(x==2)
		{
			Debug.Log(" iks 0 ");
			if(dodawanie_script.z==1)
			{
				Debug.Log(" z 1 ");
			dowod_oso.SetActive(true);
			karta.SetActive(false);
			}
			else
			{
				Debug.Log(" z 0 ");
			dowod_osoZ.SetActive(true);
			kartaZ.SetActive(false);		
			}
		}

	}
	public void chowaj()
	{
		if(on==true)
		{
			on = false;
		rzecz.SetActive(false);
		opis.SetActive(false);
		dupa.SetActive(false);
		zadowolony.SetActive(false);
		karta.SetActive(false);
		dowod_oso.SetActive(false);
		}
	}
	public void udalo_sie()
	{
				karta.SetActive(false);
				dowod_oso.SetActive(false);
				kartaZ.SetActive(false);
				dowod_osoZ.SetActive(false);
		opis.SetActive(false);
		dupa.SetActive(false);
		zadowolony.SetActive(true);
	}
	
	public void ok()
	{
		rzecz.SetActive(false);
		dodawanie_script.koncz();
	}
}
