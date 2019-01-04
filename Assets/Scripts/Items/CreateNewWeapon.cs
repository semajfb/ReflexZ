using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour {

    private BaseWeapon newWeapon;

    // Use this for initialization
    void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ToString());
    }

    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();
        newWeapon.ItemName = "W" + Random.Range(1, 101);
        newWeapon.ItemDescription = "This is a new weapon!";
        newWeapon.ItemID = Random.Range(1, 101);

        newWeapon.Vitality = Random.Range(1, 20);
        newWeapon.Strength = Random.Range(1, 20);
        newWeapon.Agility = Random.Range(1, 20);
        newWeapon.Intellect = Random.Range(1, 20);
        newWeapon.MagicalDefense = Random.Range(1, 20);
        newWeapon.PhysicalDefense = Random.Range(1, 20);

        ChooseWeaponType();

        newWeapon.SpellEffectID = Random.Range(1, 101);
    }


    private void ChooseWeaponType()
    {
        newWeapon.SetWeaponType((BaseWeapon.WeaponTypes) Random.Range(1, 10));
        newWeapon.SetItemTier((BaseStatItem.ItemTiers) Random.Range(1, 5));
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
