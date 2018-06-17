using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class objekt : MonoBehaviour {


		public Texture zdj;
		public int z=0;
		public string glowny_tag;
		public string poboczny_tag;
		public string nazwa_ob;
		public bool   taj=false;
		public string cecha1;
		public string opis1;
		public string cecha2;
		public string opis2;
		public string cecha3;
		public string opis3;
		public string cecha4;
		public string opis4;
		public string cecha5;
		public string opis5;
		public string ogolny_opis;
		
		public  Text nazwa;
		public RawImage tekstura;
		public Text opis;
		public GameObject info;

		
		public void przypisz()
		{
			nazwa.text = nazwa_ob;
			opis.text = poboczny_tag + "\n" + cecha1 + ": " + opis1+ "\n"+ cecha2 + ": " + opis2;
			Debug.Log("afaf");
			tekstura.texture = zdj;
		}
		
		public void wyswietl()
		{

			//info = GameObject.FindGameObjectWithTag("info");
			info.GetComponent<info>().n1 =glowny_tag;
			info.GetComponent<info>().n2 =poboczny_tag;
			info.GetComponent<info>().n3 =nazwa_ob;
			info.GetComponent<info>().opis =cecha1 + "; "+ opis1 + "\n"  +cecha2 + "; "+ opis2 + "\n"  +cecha3+ "; "+ opis3 + "\n"  + 
														   cecha4 + "; "+ opis4 + "\n"  + cecha5 + "; "+ opis5 + "\n"  +   ogolny_opis;
						info.GetComponent<info>().wyswietl();	
			info.GetComponent<info>().zdjecie = zdj;						
		}
}
