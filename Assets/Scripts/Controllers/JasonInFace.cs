using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JasonInFace : MonoBehaviour {

	public GameObject player;
	public GameObject itemObject;
	public bool pop = false;
    public float distFromPlayer;

    public SkinnedMeshRenderer[] meshRenderers;



	public void InFace()
	{
		pop = true;
		itemObject.transform.position = player.transform.position + Vector3.back + Vector3.down;
        for(int i = 0; i < meshRenderers.Length; ++i)
        {
            meshRenderers[i].enabled = false;
        }
	}

    public void GetInFace()
    {
        itemObject.transform.position = player.transform.forward.normalized * distFromPlayer;
        for (int i = 0; i < meshRenderers.Length; ++i)
        {
            meshRenderers[i].enabled = true;
        }
    }
}
