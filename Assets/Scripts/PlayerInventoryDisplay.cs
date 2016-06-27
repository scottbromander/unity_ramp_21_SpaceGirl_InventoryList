using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerInventoryDisplay : MonoBehaviour {
	public Text inventoryText;

	public void OnChangeInventory(List<Pickup> inventory){
		inventory.Sort (
			delegate(Pickup p1, Pickup p2) {
				return p1.description.CompareTo(p2.description);
			}
		);

		inventoryText.text = " ";

		string newInventoryText = "Carrying: ";
		int numItems = inventory.Count;
		for (var i = 0; i < numItems; i++) {
			string description = inventory [i].description;
			newInventoryText += " [" + description + "] ";
		}

		if (numItems < 1)
			newInventoryText = "(Empty Inventory)";

		inventoryText.text = newInventoryText;
	}
}
