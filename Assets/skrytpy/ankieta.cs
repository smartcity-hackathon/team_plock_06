using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ankieta : MonoBehaviour 
{ 		public dodawanie dodawanie_script;
		public tworze_obiekt tworze_obiekt_script;
		public 	List<string> nowe_opcje = new List<string>();
    public Dropdown opcje1;
	public Dropdown opcje2;
	public Dropdown opcje3;
	public Dropdown opcje4;
	public Dropdown opcje5;
	public Text cecha1;
	public Text cecha2;
	public Text cecha3;
	public Text cecha4;
	public Text cecha5;
	
	//przykladowe zdj
	public Texture Portfel;
	public Texture Pies;
	public Texture Kot;
	public Texture Bizuteria;
	public Texture s_elektroniczny;
    void Start()
    {

	
	/*
        m_Dropdown.ClearOptions();
		nowe_opcje.Add("ub");
		nowe_opcje.Add("cyc");
		nowe_opcje.Add("cyc");
		m_Dropdown.AddOptions(nowe_opcje);
	*/
        //Create a new option for the Dropdown menu which reads "Option 1" and add to messages List
        //m_NewData = new Dropdown.OptionData();
       // m_NewData.text = "Option 1";
       // m_Messages.Add(m_NewData);
		
		//m_Dropdown
		//portfel();
	}
	
 
	
	public void portfel()
	{
		
			Debug.Log(" portfel sie zaczyna");
//	List<string> nowe_opcje = new List<string>();
			dodawanie_script.zdjecie = Portfel;
			cecha1.text = "kolor: ";
			dodawanie_script.cecha1_tym = "kolor: ";
			opcje1.ClearOptions();
			nowe_opcje.Add("czerwony");
			nowe_opcje.Add("zielony");
			nowe_opcje.Add("niebieski");
			nowe_opcje.Add("fioletowy");
			nowe_opcje.Add("różowy");
			nowe_opcje.Add("pomarańczowy");
			nowe_opcje.Add("żółty");
			nowe_opcje.Add("brązowy");
			nowe_opcje.Add("srebrny");
			nowe_opcje.Add("czarny");
			nowe_opcje.Add("biały");
			opcje1.AddOptions(nowe_opcje);
			czysc();
			cecha2.text = "materiał: ";
			dodawanie_script.cecha2_tym = "materiał: ";
			opcje2.ClearOptions();
			nowe_opcje.Add("skóra");
			nowe_opcje.Add("inny");
			opcje2.AddOptions(nowe_opcje);
			czysc();
			cecha3.text = "Czy był dowód \n osobisty: ";
			dodawanie_script.cecha3_tym = "Czy był dowód \n osobisty: ";
			opcje3.ClearOptions();
			nowe_opcje.Add("tak");
			nowe_opcje.Add("nie");
			opcje3.AddOptions(nowe_opcje);
			czysc();
			cecha4.text = "Czy była karta \n płatnicza: ";
			dodawanie_script.cecha4_tym = "Czy była karta \n płatnicza: ";
			opcje4.ClearOptions();
			nowe_opcje.Add("tak");
			nowe_opcje.Add("nie");
			opcje4.AddOptions(nowe_opcje);
			czysc();
			cecha5.text = "Czy było prawo \n jazdy: ";
			dodawanie_script.cecha5_tym = "Czy było prawo \n jazdy: ";
			opcje5.ClearOptions();
			nowe_opcje.Add("tak");
			nowe_opcje.Add("nie");
			opcje5.AddOptions(nowe_opcje);
			czysc();
			
			
	}
	
	
	public void pies()
	{
		Debug.Log(" pies sie zaczyna");
//	List<string> nowe_opcje = new List<string>();
			dodawanie_script.zdjecie = Pies;
			cecha1.text = "umaszczenie: ";
			dodawanie_script.cecha1_tym = "umaszczenie: ";
			opcje1.ClearOptions();
			nowe_opcje.Add("jednolite");
			nowe_opcje.Add("łaciate");
			opcje1.AddOptions(nowe_opcje);
			czysc();
			cecha2.text = "kolor: ";
			dodawanie_script.cecha2_tym = "kolor: ";
			opcje2.ClearOptions();
			nowe_opcje.Add("czarny");
			nowe_opcje.Add("brązowy");
			nowe_opcje.Add("szary");
			nowe_opcje.Add("kremowy");
			nowe_opcje.Add("biały");
			opcje2.AddOptions(nowe_opcje);
			czysc();
			cecha3.text = "kolor: ";
			dodawanie_script.cecha3_tym = "kolor: ";
			opcje3.ClearOptions();
			nowe_opcje.Add("czarny");
			nowe_opcje.Add("brązowy");
			nowe_opcje.Add("szary");
			nowe_opcje.Add("kremowy");
			nowe_opcje.Add("biały");
			opcje3.AddOptions(nowe_opcje);
			czysc();
			cecha4.text = "wielkość: ";
			dodawanie_script.cecha4_tym = "wielkość: ";
			opcje4.ClearOptions();
			nowe_opcje.Add("mały");
			nowe_opcje.Add("duży");
			opcje4.AddOptions(nowe_opcje);
			czysc();
			cecha5.text = "Czy jest \n obroża? ";
			dodawanie_script.cecha5_tym = "Czy jest \n obroża?";
			opcje5.ClearOptions();
			nowe_opcje.Add("tak");
			nowe_opcje.Add("nie");
			opcje5.AddOptions(nowe_opcje);
			czysc();
			
			
	}
	
	
		public void kot()
	{
		Debug.Log(" kot sie zaczyna");
//	List<string> nowe_opcje = new List<string>();
			dodawanie_script.zdjecie = Kot;
			cecha1.text = "kolor futra: ";
			dodawanie_script.cecha1_tym = "kolor futra: ";
			opcje1.ClearOptions();
			nowe_opcje.Add("jednolite");
			nowe_opcje.Add("pręgowane");
			opcje1.AddOptions(nowe_opcje);
			czysc();
			cecha2.text = "kolor: ";
			dodawanie_script.cecha2_tym = "kolor: ";
			opcje2.ClearOptions();
			nowe_opcje.Add("czarny");
			nowe_opcje.Add("brązowy");
			nowe_opcje.Add("szary");
			nowe_opcje.Add("kremowy");
			nowe_opcje.Add("biały");
			opcje2.AddOptions(nowe_opcje);
			czysc();
			cecha3.text = "kolor: ";
			dodawanie_script.cecha3_tym = "kolor: ";
			opcje3.ClearOptions();
			nowe_opcje.Add("czarny");
			nowe_opcje.Add("brązowy");
			nowe_opcje.Add("szary");
			nowe_opcje.Add("kremowy");
			nowe_opcje.Add("biały");
			opcje3.AddOptions(nowe_opcje);
			czysc();
			cecha4.text = "wielkość: ";
			dodawanie_script.cecha4_tym = "wielkość: ";
			opcje4.ClearOptions();
			nowe_opcje.Add("mały");
			nowe_opcje.Add("duży");
			opcje4.AddOptions(nowe_opcje);
			czysc();
			cecha5.text = "Czy jest \n obroża? ";
			dodawanie_script.cecha5_tym = "Czy jest \n obroża?";
			opcje5.ClearOptions();
			nowe_opcje.Add("tak");
			nowe_opcje.Add("nie");
			opcje5.AddOptions(nowe_opcje);
			czysc();
			
			
	}
	
	public void bizuteria()
	{
		Debug.Log(" bizuteria sie zaczyna");
//	List<string> nowe_opcje = new List<string>();
			dodawanie_script.zdjecie = Bizuteria;
			cecha1.text = "co to: ";
			dodawanie_script.cecha1_tym = "co to: ";
			opcje1.ClearOptions();
			nowe_opcje.Add("pierścionki");
			nowe_opcje.Add("naszyjnik");
			nowe_opcje.Add("kolczyki");
			nowe_opcje.Add("bransoletka");
			opcje1.AddOptions(nowe_opcje);
			czysc();
			cecha2.text = "materiał: ";
			dodawanie_script.cecha2_tym = "materiał: ";
			opcje2.ClearOptions();
			nowe_opcje.Add("złoto");
			nowe_opcje.Add("srebro");
			nowe_opcje.Add("drewno");
			nowe_opcje.Add("koral");
			nowe_opcje.Add("inne");
			opcje2.AddOptions(nowe_opcje);
			czysc();
			cecha3.text = "kamień: ";
			dodawanie_script.cecha3_tym = "kamień: ";
			opcje3.ClearOptions();
			nowe_opcje.Add("brak");
			nowe_opcje.Add("czerwony");
			nowe_opcje.Add("niebieski");
			nowe_opcje.Add("biały");
			nowe_opcje.Add("zielony");
			nowe_opcje.Add("żółty");
			nowe_opcje.Add("różowy");
			nowe_opcje.Add("inny");
			opcje3.AddOptions(nowe_opcje);
			czysc();
			cecha4.text = "grawer: ";
			dodawanie_script.cecha4_tym = "grawer: ";
			opcje4.ClearOptions();
			nowe_opcje.Add("brak");
			nowe_opcje.Add("jest");
			opcje4.AddOptions(nowe_opcje);
			czysc();
			cecha5.text = "";
			dodawanie_script.cecha5_tym = "";
			opcje5.ClearOptions();
			nowe_opcje.Add("---");
			nowe_opcje.Add("---");
			opcje5.AddOptions(nowe_opcje);
			czysc();
			
			
	}
	
	public void elektro()
	{
		Debug.Log(" elektro sie zaczyna");
//	List<string> nowe_opcje = new List<string>();
			dodawanie_script.zdjecie = s_elektroniczny;
			cecha1.text = "co to: ";
			dodawanie_script.cecha1_tym = "co to: ";
			opcje1.ClearOptions();
			nowe_opcje.Add("telefon");
			nowe_opcje.Add("laptop");
			nowe_opcje.Add("słuchawki");
			nowe_opcje.Add("tablet");
			nowe_opcje.Add("inne");
			opcje1.AddOptions(nowe_opcje);
			czysc();
			cecha2.text = "marka: ";
			dodawanie_script.cecha2_tym = "marka: ";
			opcje2.ClearOptions();
			nowe_opcje.Add("samsung");
			nowe_opcje.Add("apple");
			nowe_opcje.Add("huawei");
			nowe_opcje.Add("Sony");
			nowe_opcje.Add("Panasonic");
			nowe_opcje.Add("inne");
			opcje2.AddOptions(nowe_opcje);
			czysc();
			cecha3.text = "kolor: ";
			dodawanie_script.cecha3_tym = "kolor: ";
			opcje3.ClearOptions();
			nowe_opcje.Add("czerwony");
			nowe_opcje.Add("niebieski");
			nowe_opcje.Add("biały");
			nowe_opcje.Add("zielony");
			nowe_opcje.Add("żółty");
			nowe_opcje.Add("różowy");
			nowe_opcje.Add("inny");
			opcje3.AddOptions(nowe_opcje);
			czysc();
			cecha4.text = "";
			dodawanie_script.cecha4_tym = "";
			opcje4.ClearOptions();
			opcje4.AddOptions(nowe_opcje);
			czysc();
			cecha5.text = "";
			dodawanie_script.cecha5_tym = "";
			opcje5.ClearOptions();
			opcje5.AddOptions(nowe_opcje);
			czysc();
			
			
	}
	void czysc()
	{
		nowe_opcje = new List<string>();
	}
	
	
	
	public void opis1()
	{
		
		}

}
