using UnityEngine;
using System.Collections;

public class ViewManager : MonoBehaviour {

	public GameObject BuildingPrefab;


	public GameObject CreateHomeView(BuildingKinds kind){
		GameObject buildingObj = (GameObject)Instantiate(BuildingPrefab);
		//buildingObj.GetComponent
		return buildingObj;
	}
	
	// Use this for initialization
	public void Start () {



	}
	
	// Update is called once per frame
	public void Update () {
		if (Input.GetAxis("Horizontal") > 0){
//			CreateHomeView();
		}
	}


}
