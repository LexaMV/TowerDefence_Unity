﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour {


      void OnTriggerEnter(Collider other){
		  if(other.gameObject.transform.parent.name == "Creeps"){
			  Debug.Log("Cool");
		  Destroy(other.gameObject);
	  }
	  }
}
