using UnityEngine;
using System.Collections;

//class for storing one type of resources like gold, Exir , Gem


[System.Serializable]


public class ResourceBox {
	/********************* Write set and get for vars */
	
	//type of resource
	public ResourceDataType type;
	
	// the amount of resource box has.
	public int amount;
	
	//the capacity of box
	public int capacity;
	
	/**
 * Convenience constructor.
 */ 
	public	ResourceBox(ResourceKind kind, int amount) {
		this.type.kind = kind;
		this.amount = amount;
		
	}
	
	//adds some resources:
	//@param am : the amount should be added to this.amount
	//@return if can add (this.amount should be between 0 and capacity) return true else false
	public void addAmount(int am){
		if (amount <= 0) {
			throw new System.Exception("Invalid Param");
		} else {
			if(amount+am<capacity){
				amount+=am;
				return;
			}
			else{

			}
		}
		
	}
	
	//decrease the amount in box by am value
	public void subAmount(int am){
		if (amount < am) {
			throw new System.Exception("Not Enough Resources");
		} else {
			amount-=am;
			return;
		}

	}

	/*
	 * increase capacity
	 * @pram cap: new value of capacity
	 * if changing capacity is available sets value and returns true
	 * else returns false
	 */
	public void incCapacity(int cap){
		if (cap < capacity) {
			throw new System.Exception("invalid param");
		} else {
			this.capacity=cap;
			return;
		}
	}

}








