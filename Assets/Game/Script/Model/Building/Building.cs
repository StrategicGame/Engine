using UnityEngine;
using System.Collections;

public class Building{
	public virtual BuildingData data{set; get;}
	public virtual int id{private set; get;}

	public Building(int id, BuildingTypeData type, System.DateTime startTime){
		data = new BuildingData(type, startTime);
		this.id = id;
	}


}
