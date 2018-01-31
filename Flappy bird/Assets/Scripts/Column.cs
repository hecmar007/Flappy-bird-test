using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour {

	#region Variables

	#endregion

    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.GetComponent<BirdController>() != null)
        {
            gameController.instance.BirdScored();
        }
    }
}
