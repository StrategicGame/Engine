using UnityEngine;
using System.Collections;

public class Point {

	public static Point[][] table;
	public const int CellSize = 10;

	public float x;
	public float y;

	public int xTable;			//value of X axis in table
	public int yTable;			//value of Y axis in table

	public int width;		//length of object in X axis
	public int height;		//length of object in Y axis

	public Point(int xTable,int yTable,int width=0,int height=0){
		this.xTable = xTable;
		this.yTable = yTable;
		this.width = width;
		this.height = height;

		/*
		 * hanooz kamel nist
		 * bayad x va y ro be vasileye cellSize meghdardehi konim.
		 */
	}

	public static Point operator +(Point first,Point second){

		Point result = new Point (first.xTable + second.xTable, first.yTable + second.yTable);
		return result;
	}

	public static Point operator -(Point first,Point second){
		Point result = new Point (first.xTable - second.xTable, first.yTable - second.yTable);
		return result;
	}

	public static bool operator ==(Point first,Point second){
		if (first.x == second.x && first.y == second.y) {
			return true;
		}
		return false;
	}

	public static bool operator !=(Point first,Point second){
		return !(first==second);
	}

	public override string ToString ()
	{
		return string.Format ("Point: x="+x+"  y="+y+"  xTable="+xTable+"  yTable="+yTable+"  witdh="+width+"  height="+height);
	}
}
