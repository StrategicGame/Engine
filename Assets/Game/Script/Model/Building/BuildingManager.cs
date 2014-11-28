using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BuildingManager: MonoBehaviour{

	public List<string> buildingDataFiles;

	public  Dictionary <BuildingKinds, BuildingTypeData> buildingTypeData{set; get;}
	public  Dictionary <int,Building> allBuildings{set; get;}

	public int HOME_TOWN_ID{private set; get;}

	void Start(){
		Init();
		loadBuildingDataType();
		createNewScene();
		

	}


	public  void Init(){
		buildingTypeData = new Dictionary<BuildingKinds, BuildingTypeData>();
		allBuildings = new Dictionary<int, Building>();
	}


	/*
	 * get type of Building and create that building
	 * then add this building to buildingid dictionary
	 * @return created building (else null)
	 */
	public  Building CreateBuilding(BuildingKinds kind, bool isFree = false){

		if(!buildingTypeData.ContainsKey(kind)){
			throw new System.Exception("Not Exists");
		}

		if (isFree){
			int id = IDGeneratror.GenerateID();
			Building building = new Building(id, buildingTypeData[kind], System.DateTime.Now);
			allBuildings.Add(id, building);
			
			return building;
		}
			return null;
		/*
		BuildingTypeData type = buildingTypeData[kind];

		ResourceManager.decreaseTownHallRepositories(type.resourceCosts[0].amount,type.resourceCosts[1].amount,type.resourceCosts[2].amount);
		int id = GameObjectID.getNewGameObjectID ();

		Building building = new Building ();

		allBuildings.Add (id, building);

		return;
*/
	}

	public bool canBuild(BuildingKinds kind){
		if(!buildingTypeData.ContainsKey(kind)){
			throw new System.Exception("Not Exists");
		}



		return true;
	}

	public void createNewScene(){
		Building homeTown = CreateBuilding (BuildingKinds.HOME_TOWN, true);
		if (homeTown == null)
			throw new System.Exception("Can't Build Home Town");

		HOME_TOWN_ID = homeTown.id;
	}


	private void loadBuildingDataType(){
		foreach (string dataFile in buildingDataFiles){
			loadBuildingTypeFromFile(dataFile);
		}
	}

	private void loadBuildingTypeFromFile(string dataFile){
		Loader<BuildingTypeData> loader = new Loader<BuildingTypeData>();

		List<BuildingTypeData> data = loader.Load(dataFile) ;

		foreach(BuildingTypeData type in data){
			buildingTypeData.Add(type.kind, type);
		}

		//buildingTypeData.Add(BuildingKinds.BUILDING_HOME_TOWN, new BuildingTypeData());
	}
	

	public  void onlyForDebugging(){
		//Debug.Log ("Man");
		//loadBuildingTypeFromFile(buildingDataFiles[0]);
		Debug.Log (buildingTypeData[BuildingKinds.HOME_TOWN].description);
	}

}
