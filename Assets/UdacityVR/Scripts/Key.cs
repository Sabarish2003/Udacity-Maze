using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoof;
    public GameObject door;
    Door doorScript;

    private bool keyCollect = false;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located        
        // Make sure the poof animates vertically
        Instantiate(keyPoof, this.transform.position, this.transform.rotation);
        // Call the Unlock() method on the Door
        doorScript = door.GetComponent<Door>();
        doorScript.Invoke("Unlock", 0);       
        
        // Set the Key Collected Variable to true
        this.keyCollect = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(this.gameObject);
    }

}
