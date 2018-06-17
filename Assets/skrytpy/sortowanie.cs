using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sortowanie : MonoBehaviour {
	
	public GameObject[] zgubione = new GameObject[20];
	public GameObject[] znalezione = new GameObject[20];
	public GameObject[] tablica = new GameObject[20];
	public int zg=0, zn=0, k=0;
	public GameObject ostatni;
	
	public void znalazl(GameObject obj)
	{
		znalezione[k] = obj;
		zn++;
		k = zn;
		for(int i=0;i<k;i++)tablica[i] =zgubione[i];
	}
	public void zgubil(GameObject obj)
	{
		/*
		zgubione[k] = obj;
		zg++;
		k = zg;
		for(int i=0;i<k;i++)tablica[i] =znalezione[i];
		*/
	}
	
	public void sortuj_pop()
	{
		
		if(k>1)
		{
			ostatni = tablica[k-1];
		
		for(int i=0;i<k;i++)
		{
			for(int j=0;j<k;j++)
			{
				if(ile(tablica[i])<ile(tablica[j]))
				{
					zamien(tablica[i], tablica[j]);
				}
			}
		}
		 
		}
		
		
	//	zamien(tablica[0], tablica[1]);
	}
	
	
	public void zamien(GameObject obj1, GameObject obj2)
	{
		Vector3 tym1 = obj1.GetComponent<RectTransform>().position;
		Vector3 tym2 = obj2.GetComponent<RectTransform>().position;
		obj1.GetComponent<RectTransform>().position = tym2;
		obj2.GetComponent<RectTransform>().position = tym1;
	}
	public int ile(GameObject sprawd)
	{
		int wynik =0;
		if(ostatni.GetComponent<objekt>().z ==sprawd.GetComponent<objekt>().z) return (-1);
		if(ostatni.GetComponent<objekt>().poboczny_tag !=sprawd.GetComponent<objekt>().poboczny_tag) return (-1);
		if(ostatni.GetComponent<objekt>().z !=sprawd.GetComponent<objekt>().z)
		{
			if(ostatni.GetComponent<objekt>().glowny_tag ==sprawd.GetComponent<objekt>().glowny_tag) wynik++;
			if(ostatni.GetComponent<objekt>().opis1 ==sprawd.GetComponent<objekt>().opis1) wynik++;
			if(ostatni.GetComponent<objekt>().opis2 ==sprawd.GetComponent<objekt>().opis2) wynik++;
			if(ostatni.GetComponent<objekt>().opis3 ==sprawd.GetComponent<objekt>().opis3) wynik++;
			if(ostatni.GetComponent<objekt>().opis4 ==sprawd.GetComponent<objekt>().opis4) wynik++;
			if(ostatni.GetComponent<objekt>().opis5 ==sprawd.GetComponent<objekt>().opis5) wynik++;
			return (wynik);
		}
		else 
		{
			return (-1);
		}
	}
}
