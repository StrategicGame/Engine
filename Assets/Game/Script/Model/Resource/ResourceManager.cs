using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


class ResourceManager: MonoBehaviour{
	
	// collection of resource types
	// a pair of (name, resource type) for example: (gold, ResourceDataType(Kind.Gold, ...))
	protected static Dictionary <string, ResourceDataType> resourceDataTypes=new Dictionary<string, ResourceDataType>();
	
	// collection of resource boxes exists in scene
	// a pair of (id, resource box) for example: ("", ResourceBox(Kind.Gold))
	protected static Dictionary <string, ResourceBox> resourceRepositories = new Dictionary<string, ResourceBox>();
	
	//instansiate resourceDataTypes and add data to it
	private static void loadResourceDataTypes(){
		/*********************
		add 5 resourceDataType one for every Resource kind
		*/
	}
	
	//loads the first resource boxes we have on scene: like total golds, total exirs
	//instansiate
	private static void loadFirstRepoistoies(){
		/*********************
		add resource boxes that user has them at start of the game
		*/
	}
	
	// insert box to repository
	//@return true if inserted successfully, false cannot insert (if id was used before) 
	public static bool insertResourceBox(string id, ResourceBox resBox){
		/*if (!resourceRepositories.ContainsKey (id)) {
			resourceRepositories.Add (id, resBox);
			return true;
		} else*/ {
			return false;
		}
	}
	
	// remove box from repository
	public static void removeResourceBox(string id){
		/*
		if (resourceRepositories.ContainsKey (id)) {
			resourceRepositories.Remove(id);
		}*/

	}


	/*
	 * get a resourceBox and add amount of that ResourceBox to townHall resourceBox
	 * and change that resourceBox amount to zero.
	 */
	public static void addResourceToTownHall(string id,ResourceBox resourceBox){

		/*
		int amount = resourceRepositories [id].amount;

		if (resourceBox.type.kind == ResourceKind.Gold) {
			TownHall.resources ["GOLD"].addAmount (amount);
		} else if (resourceBox.type.kind == ResourceKind.Exir) {
			TownHall.resources ["EXIR"].addAmount (amount);
		} else if (resourceBox.type.kind == ResourceKind.Gem) {
			TownHall.resources["GEM"].addAmount(amount);
		}

		resourceBox.subAmount (resourceBox.amount);
*/
	}


	//adds some amount of resource to a specific box
	//@if id does not exist throw InvalidParam
	public static void addResource(string id, ResourcePack resource){
		/*
		if (!(resourceRepositories.ContainsKey (id))) {
			throw new InvalidParam();
		}
		resourceRepositories [id].addAmount (resource.amount);
		*/
	}
	
	//subtracts some amount of resource from a specific box
	//@return false: if id is not defined or box type is not same as resource type or box has not enough value
	public static void decreaseResource(string id, ResourcePack resource){
/*
		if (!resourceRepositories.ContainsKey (id)) {
			throw new InvalidParam ();
		} else if (resourceRepositories [id].amount < resource.amount) {
			throw new InvalidParam();
		}

		resourceRepositories [id].subAmount (resource.amount);
	*/
	}

	/*
	 * @param : gold amount, exir amount, gem amount
	 * decrease gold amount from TownHall repositories
	 * decrease exir amount from TownHall repositories
	 * decrease gem amount from TownHall repositories
	 * throws exception if does not exist enough value
	 */
	public static void decreaseTownHallRepositories(int gold,int exir,int gem){
/*
		if (gold > TownHall.resources ["GOLD"].amount) {
			throw new NotEnoughResources ();
		} else if (exir > TownHall.resources ["EXIR"].amount) {
			throw new NotEnoughResources ();
		} else if (gem > TownHall.resources ["GEM"].amount) {
			throw new NotEnoughResources();
		}

		TownHall.resources ["GOLD"].subAmount (gold);
		TownHall.resources ["EXIR"].subAmount (exir);
		TownHall.resources ["GEM"].subAmount (gem);
*/
}


	//empty a resource box
	//false if id is not defined
	public static void emptyResourceBox(string id){
	/*
		if (!resourceRepositories.ContainsKey (id)) {
			throw new NotExists();
		}

		resourceRepositories [id].subAmount (resourceRepositories [id].amount);
	*/
	}
	
	//call for loaders
	public static void awake(){
	}
	
	/**
	 * Return true if there are enough resources to build the given building.
	 */ 
	public static bool canBuild(BuildingTypeData building) {
		//*********************check only for total resource boxes
		return false;		//hanooz kamel nashode
	}
	
	//************** At the end make the class singletone
}