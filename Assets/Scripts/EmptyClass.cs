using System;

public class Shotgun : Weapon
{
	private int apertura_ad_ombrello;
	// altre variabili...

	public Shotgun()
	{
		this.name_weapon = "Shotgun";
		this.rateo_fire = 3.0f;
		this.prefab_weapon = null; // Not available still
	}

	// sovrascrittura
	public virtual void fire(){
		// qua dice come sparare con lo shotgun
	}
}
