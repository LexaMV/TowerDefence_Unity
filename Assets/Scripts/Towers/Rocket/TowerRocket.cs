using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRocket : MonoBehaviour {

    private GameObject head;
	public GameObject roket;

	private GameObject creep;
	private float speed;
	bool povorot;
	// Use this for initialization
	void Start () {
		head =  gameObject.transform.Find("Head").gameObject;
		speed = 1.0f;
		povorot = false;
	}
	
    void OnTriggerEnter(Collider other){
		if(other.gameObject.transform.parent.name == "Creeps"){
			creep = other.gameObject;
			povorot = true;
        //head.gameObject.transform.LookAt(other.gameObject.transform);

        // Vector3 direction = other.gameObject.transform.position - head.gameObject.transform.position; 
        // float angle = Vector3.Angle(direction,head.gameObject.transform.forward);
        // Vector3 newDir = -Vector3.RotateTowards(head.gameObject.transform.forward, direction,angle,0.0f);
        // //head.gameObject.transform.rotation = Quaternion.LookRotation(newDir*speed);
		// head.gameObject.transform.Rotate(Vector3.up, angle,Space.World);
	}
	}

	void OnTriggerExit(Collider other){
		creep = null;
		povorot = false;
	}



	void Update () {
		if (povorot == false){
		head.transform.Rotate(Vector3.up, 1, Space.World);}

    else if(povorot == true){
    var newRotation = Quaternion.LookRotation(head.transform.position - creep.transform.position, Vector3.forward);
    newRotation.x = 0.0f;
    newRotation.z = 0.0f;
    head.transform.rotation = Quaternion.Slerp(head.transform.rotation, newRotation, Time.deltaTime * 8);






	
		//

		
	 }
}
}
