using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TownHall{

	public  Dictionary<string, ResourceBox> resources;		//for each resource holds one ResourcePack

	public void Init(){
		ResourceBox[] resBox = new ResourceBox[3];
		resBox[0].type.kind = ResourceKind.Gold;			//for saving gold
		resBox[0].amount = 0;
		resources.Add ("GOLD",resBox [0]);

		resBox[1].type.kind = ResourceKind.Exir;			//for saving exir
		resBox[1].amount = 0;
		resources.Add ("EXIR",resBox [1]);

		resBox[2].type.kind = ResourceKind.Gem;				//for saving gem
		resBox[2].amount = 0;
		resources.Add("GEM",resBox[2]);
	}

}
