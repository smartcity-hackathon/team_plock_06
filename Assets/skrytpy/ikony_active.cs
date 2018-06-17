using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ikony_active : MonoBehaviour {

	public Sprite icon1;
	public Sprite icona_1;
	public Sprite icon2;
	public Sprite icona_2;
	public Sprite icon3;
	public Sprite icona_3;
	public Sprite icon4;
	public Sprite icona_4;
	public Sprite icon5;
	public Sprite icona_5;
	public Sprite icon6;
	public Sprite icona_6;
	
	public Color czarny;
	public Color bialy;
	public Image loop_z;
	public Image home;
	public Image account;
	public Image settings;
	public Image plus;
	public Image sort;
	
	bool bool1 = false;
	
	void Start()
	{
		dom();
	}
	public void wylacz()
	{
		Debug.Log(" false");
			bool1 = false;
			loop_z.sprite = icon1;
			loop_z.color = czarny;
			
			Debug.Log(" false");
			bool2 = false;
			home.sprite = icon2;
			home.color = czarny;
			
			Debug.Log(" false");
			bool3 = false;
			settings.sprite = icon3;
			settings.color = czarny;
			
			Debug.Log(" false");
			bool4 = false;
			plus.sprite = icon4;
			plus.color = czarny;
			
			Debug.Log(" false");
			bool5 = false;
			account.sprite = icon5;
			account.color = czarny;
			
			
		
	}
	public void loop()
	{
		wylacz();
		Debug.Log(" rozp");
		if(bool1==false)
		{
			Debug.Log(" true");
			bool1 = true;
			loop_z.sprite = icona_1;
			loop_z.color = bialy;
		}
		else
		{
			Debug.Log(" false");
			bool1 = false;
			loop_z.sprite = icon1;
			loop_z.color = czarny;
		}
	}
	
	bool bool2 = false;
	public void dom()
	{
		wylacz();
		Debug.Log(" rozp");
		if(bool2==false)
		{
			//Debug.Log(" true");
			bool2 = true;
			home.sprite = icona_2;
			home.color = bialy;
		}
		else
		{
			Debug.Log(" false");
			bool2 = false;
			home.sprite = icon2;
			home.color = czarny;
		}
	}
	
		bool bool3 = false;
	public void ustawienia()
	{
		wylacz();
		Debug.Log(" rozp");
		if(bool3==false)
		{
			//Debug.Log(" true");
			bool3 = true;
			settings.sprite = icona_3;
			settings.color = bialy;
		}
		else
		{
			Debug.Log(" false");
			bool3 = false;
			settings.sprite = icon3;
			settings.color = czarny;
		}
	}


	
				bool bool4 = false;
	public void dodac()
	{
		wylacz();
		Debug.Log(" rozp");
		if(bool4==false)
		{
			//Debug.Log(" true");
			bool4 = true;
			plus.sprite = icona_4;
			plus.color = bialy;
		}
		else
		{
			Debug.Log(" false");
			bool4 = false;
			plus.sprite = icon4;
			plus.color = czarny;
		}
	}
	
	bool bool5 = false;
	public void konto()
	{
		wylacz();
		Debug.Log(" rozp");
		if(bool5==false)
		{
			//Debug.Log(" true");
			bool5 = true;
			account.sprite = icona_5;
			account.color = bialy;
		}
		else
		{
			Debug.Log(" false");
			bool5 = false;
			account.sprite = icon5;
			account.color = czarny;
		}
	}
		
}
