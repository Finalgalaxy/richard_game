using UnityEngine;
using System;

public abstract class Weapon
{
	public String name_weapon;
	public float rateo_fire;
	protected Transform prefab_weapon;

	public override void fire(){
		// To override
	}
}


