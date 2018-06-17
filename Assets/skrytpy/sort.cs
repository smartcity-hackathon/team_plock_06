using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sort : MonoBehaviour {

	public Animator anim;
	public bool on = false;
	
	public void przycisk()
	{
		if(on== false)
		{
			on = true;
			open_set();
		}
		else 
		{
			on = false;
			close_set();
		}
	}
	
	
	 void open_set()
	{
		anim.SetBool("open",true);
	}
	 void close_set()
	{
		anim.SetBool("open",false);
	}
}
