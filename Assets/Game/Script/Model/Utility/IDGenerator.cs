using UnityEngine;
using System.Collections;

public class IDGeneratror{

	private static int id=0;


	/*
	 * get uniqe id for each building or soldier for specifying objects
	 * each unit has uniqe id
	 */
	public static int GenerateID(){
		int num = id;
		++id;
		return num;
	}


}
