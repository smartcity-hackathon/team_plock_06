using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dodawanie : MonoBehaviour {

	public tworze_obiekt tworze_obiekt_scrit;
	public bool otwarte = false;
	public GameObject Dodawanie;
	public GameObject[] buttons = new GameObject[5];
	public int poziom=0;
	public int zgub=-1;
	public Animator dodaj_anim;
	public Animator plus_anim;
	public wskazowki wskazowki_script;
	public GameObject ankieta_obj;
	public ankieta ankieta_script;
	public Text[] opcje = new Text[5];
	public Text[] cechy = new Text[5];
	public Text nazwa;
	public Text opis;

	
		public int z;
		public string glowny_tag_tym;
		public string poboczny_tag_tym;
		public string nazwa_ob_tym;
		public bool   taj_tym=false;
		public string cecha1_tym;
		public string opis1_tym;
		public string cecha2_tym;
		public string opis2_tym;
		public string cecha3_tym;
		public string opis3_tym;
		public string cecha4_tym;
		public string opis4_tym;
		public string cecha5_tym;
		public string opis5_tym;
		public string opis_caly;
		public Texture zdjecie;
		
		
		

		public void ok()
		{
			zapisz();
			Debug.Log("z: "+z);
			tworze_obiekt_scrit.spam(z,zdjecie,glowny_tag_tym,poboczny_tag_tym,nazwa_ob_tym,opis_caly,cecha1_tym, opis1_tym, cecha2_tym, opis2_tym, cecha3_tym, opis3_tym, cecha4_tym,opis4_tym, cecha5_tym, opis5_tym);
		}
	public void zacznij()
	{
		if(otwarte==false)
		{
			otwieraj();
			otwarte= true;
		}
		else
		{
			otwarte= false;
			koncz();
		}
	}
	
	
	void otwieraj()
	{
				for(int i=0;i<5;i++)buttons[i].SetActive(false);
				Dodawanie.SetActive(true);
		buttons[1].SetActive(true);
		buttons[1].GetComponentInChildren<Text>().text = "zgubiłem";
		buttons[3].SetActive(true);
		buttons[3].GetComponentInChildren<Text>().text = "znalazłem";
		plus_anim.SetBool("open",true);
		dodaj_anim.SetBool("open",true);
	}
	public void koncz()
	{
		ankieta_obj.SetActive(false);
		//glowny_tag_tym="";
		//poboczny_tag_tym="";
		//nazwa_ob_tym="";
		taj_tym=false;
		cecha1_tym="";
		opis1_tym="";
		cecha2_tym="";
		opis2_tym="";
		cecha3_tym="";
		opis3_tym="";
		cecha4_tym="";
		opis4_tym="";
		cecha5_tym="";
		opis5_tym="";
		poziom =0;
		zgub =0;
		plus_anim.SetBool("open",false);
		dodaj_anim.SetBool("open",false);

	}
	public void zapisz()
	{
		
		nazwa_ob_tym = nazwa.text+"";
		opis5_tym = opis.text+"";
		opis1_tym=opcje[0].text+ "";
		opis2_tym=opcje[1].text+ "";
		opis3_tym=opcje[2].text+ "";
		opis4_tym=opcje[3].text+ "";
		opis5_tym=opcje[4].text+ "";
		
		cecha1_tym=cechy[0].text+ "";
		cecha2_tym=cechy[1].text+ "";
		cecha3_tym=cechy[2].text+ "";
		cecha4_tym=cechy[3].text+ "";
		cecha5_tym=cechy[4].text+ "";
	
	}
	public void but1()
	{
		if(zgub ==1)
		{
			

		}
	}
	public void but2()
	{
		Debug.Log(" bu2");
		if(poziom ==0)
		{
			zgub =1;
			z=1;
			poziom= 1;
		buttons[1].SetActive(true);
		buttons[1].GetComponentInChildren<Text>().text = "zwierzę";
		buttons[2].SetActive(true);
		buttons[2].GetComponentInChildren<Text>().text = "dokument";
		buttons[3].SetActive(true);
		buttons[3].GetComponentInChildren<Text>().text = "rzecz";
		}	
		else 
		{
			if(poziom==1)
			{
				// zwierze
				poziom =2;
				glowny_tag_tym = "zwierze";
				buttons[1].SetActive(true);
				buttons[1].GetComponentInChildren<Text>().text = "pies";
				buttons[2].SetActive(true);
				buttons[2].GetComponentInChildren<Text>().text = "kot";
				buttons[3].SetActive(true);
				buttons[3].GetComponentInChildren<Text>().text = "inne";
			}
			else if(poziom==2)
			{
				poziom = 3;
				// pies !
				Debug.Log("pies");
				poboczny_tag_tym = "pies";
				ankieta_obj.SetActive(true);
				ankieta_script.pies();
				for(int i=0;i<5;i++) buttons[i].SetActive(false);
			}
			else if(poziom==6)
			{
				Debug.Log(" karta płatnicza "); 
				poboczny_tag_tym = " karta platnicza "; //dziab
				for(int i=0;i<5;i++) buttons[i].SetActive(false);
				wskazowki_script.wskaz(1);
			}
			else if(poziom==7)
			{
				Debug.Log(" biżuteria "); 
				poboczny_tag_tym = " biżuteria "; //u
				for(int i=0;i<5;i++) buttons[i].SetActive(false);
				ankieta_obj.SetActive(true);
				ankieta_script.bizuteria();
			}
		}
	}
	public void but3()
	{
			Debug.Log(" bu3");
		if(poziom ==0)
		{

		}
		else
		{
			
			if(poziom==1)
			{
			// dokumenty
			glowny_tag_tym = "dokument";
			poziom =6;
				glowny_tag_tym = "dokument";
				buttons[1].SetActive(true);
				buttons[1].GetComponentInChildren<Text>().text = "karta płatnicza";
				buttons[2].SetActive(true);
				buttons[2].GetComponentInChildren<Text>().text = "dowód osobisty";
				buttons[3].SetActive(true);
				buttons[3].GetComponentInChildren<Text>().text = "portfel";

			}
			else if(poziom==2)
			{
				Debug.Log("kot");
				poboczny_tag_tym = "kot";
				ankieta_obj.SetActive(true);
				ankieta_script.kot();
				for(int i=0;i<5;i++) buttons[i].SetActive(false);
			}
			else if(poziom==6)
			{
				Debug.Log("dowód osobisty"); 
				poboczny_tag_tym = "dowód osobisty";
				for(int i=0;i<5;i++) buttons[i].SetActive(false);
				wskazowki_script.wskaz(2);
			}
			else if(poziom==7)
			{
				Debug.Log(" sprzęt elektroniczny "); 
				poboczny_tag_tym = " sprzęt elektroniczny "; //u
				for(int i=0;i<5;i++) buttons[i].SetActive(false);
				ankieta_obj.SetActive(true);
				ankieta_script.elektro();
			}
		}
	}
	public void but4()
	{
					Debug.Log(" bu4");
		if(poziom ==0)
		{
			z=0;
			zgub =0;
			poziom= 1;
		buttons[1].SetActive(true);
		buttons[1].GetComponentInChildren<Text>().text = "zwierzę";
		buttons[2].SetActive(true);
		buttons[2].GetComponentInChildren<Text>().text = "dokument";
		buttons[3].SetActive(true);
		buttons[3].GetComponentInChildren<Text>().text = "rzecz";
		}
			else if(poziom==1)
			{
			// rzeczy
			glowny_tag_tym = "rzecz";
				poziom =7;
				glowny_tag_tym = "rzecz";
				buttons[1].SetActive(true);
				buttons[1].GetComponentInChildren<Text>().text = "biżuteria";
				buttons[2].SetActive(true);
				buttons[2].GetComponentInChildren<Text>().text = "sprzęt elektroniczny";
				buttons[2].SetActive(true);
				buttons[3].GetComponentInChildren<Text>().text = "inne";
				buttons[3].SetActive(true);
			}
			else if(poziom==2)
			{
				Debug.Log("inne");
				poziom = 5;
				// inne !
				poboczny_tag_tym = "inne";
			}
			else if(poziom==6)
			{
				Debug.Log("portfel"); 
				poboczny_tag_tym = "portfel";
				ankieta_obj.SetActive(true);
				ankieta_script.portfel();
				for(int i=0;i<5;i++) buttons[i].SetActive(false);
			}
		
	}
	
	public void but5()
	{
		
	}

	

	public void ankieta()
	{
	

	}
	

}
