using System.Collections.Generic;

[System.Serializable]
public class BuildingData {


	public virtual BuildingTypeData type{set; get;}
	
	/**
	 * State of the building.
	 */
	public virtual BuildingState state {get; set;}
	
	/**
	 * Current position of the building
	 */
	//public virtual GridPosition position {get; set;}

	/**
	 * Time the building started building
	 */
	public virtual System.DateTime startTime {get; set;}
	
	public virtual int health{set; get;}

	public virtual int upgradeLevel{set; get;}

	//public Point location{set; get;}
	public BuildingData(BuildingTypeData type, System.DateTime startTime){
		this.type  = type;
		this.state = BuildingState.PLACING;
		this.upgradeLevel = 0;
		this.health = type.MAX_HEALTHES[this.upgradeLevel];
	}

	public override string ToString ()
	{
		return string.Format ("BuildingData:  type="+state );/*+"  state="+state+"  position="+position+
		                      "  startTime="+startTime+"  health="+health+"  "+location.ToString());
		                      */
	}
}
