using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Player : MonoBehaviour {
	private PlayerInventoryDisplay playerInventoryDisplay;
	private List<Pickup> inventory = new List<Pickup> ();

	// Use this for initialization
	void Start () {
		playerInventoryDisplay = GetComponent<PlayerInventoryDisplay> ();
		playerInventoryDisplay.OnChangeInventory (inventory);

	}

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("Pickup")){
			Pickup item = hit.GetComponent<Pickup> ();
			inventory.Add (item);
			playerInventoryDisplay.OnChangeInventory (inventory);
			Destroy (hit.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
