using System.Collections.Generic;

[System.Serializable]

/**
 * Data for the type of a building. Public variables are used for simplicity of serialization
 * but should not be modified directly.
 */ 
public class BuildingTypeData {

	public virtual BuildingKinds  kind {get; set;}
	
	public virtual string name {get; set;}						// Human readable name of the building.

	public virtual string description {get; set;}				// A human readable description of the building.
	
	public virtual  List<int> MAX_HEALTHES{get; set;}  //max-health for every upgrade

	public virtual List<string> spriteNames{set; get;}
	
	public virtual int required_level {get; set;}		// Level of town hall required to build.

	public virtual List<ResourcePack> resourceCosts{get; set;}	//resourceCosts[0]:GOLD - [1]:EXIR - [2]:GEM for building 
	public virtual List<int> upgradeCostCoff{set; get;}

	public virtual List<int> buildTime {get; set;}					// How long in seconds it takes to build this building.


	public override string ToString ()
	{
		return string.Format ("BuildingTypeData:  kind="+kind); /*+"  name="+name+"  description="+description+
		                      "  MAX_HEALTH="+MAX_HEALTH+"  resquired_level="+required_level+
		                      "  goldCost="+resourceCosts[0]+"  exirCost="+resourceCosts[1]+"  gemCost="+resourceCosts[2]+
		                      "  buildTime="+buildTime);*/
	}


	
}