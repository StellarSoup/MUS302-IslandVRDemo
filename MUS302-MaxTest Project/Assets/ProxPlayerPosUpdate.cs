using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ProxPlayerPosUpdate : MonoBehaviour {

    public Transform player;

    public bool glow;
	
	// Update is called once per frame
	void Update () {
        if (player != null)
        {
            // Pass the player location to the shader
            GetComponent<Renderer>().sharedMaterial.SetVector("_PlayerPosition", player.position);
            if (glow)
            {
                GetComponent<Renderer>().sharedMaterial.SetColor("_OutlineColour", new Vector4(1, 1, 1, 1));
            }
        }
    }
}
