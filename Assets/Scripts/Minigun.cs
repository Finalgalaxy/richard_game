using System;

public class Minigun : Weapon
{
	public Minigun()
	{
		this.name_weapon = "Minigun";
		this.rateo_fire = 0.02f;
		this.prefab_weapon = null; // Not available still
	}

	// sovrascrittura
	public override void fire(){
		// qua dice come sparare col minigun
	}
}
