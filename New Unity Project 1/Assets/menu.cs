using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

	
	void Start () {
		
	}
	
	void Update () {
		
	}
   public void oyunubaslat()
    {
        Application.LoadLevel(1);
    }
    public void oyundancık()
    {
        Application.Quit();
    }
}
