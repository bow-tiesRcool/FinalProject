using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JasonInFace : MonoBehaviour {

	public GameObject player;
	public GameObject itemObject;
	public bool pop = false;
    public float distFromPlayer;

    public SkinnedMeshRenderer[] meshRenderers;

    public GameObject canvas;

    IEnumerator Start()
    {
        Debug.Log("started");
        yield return new WaitForSeconds(0);
        player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(player);
    }

    public IEnumerator InFace()
	{
		pop = true;
        itemObject.transform.position = player.transform.position + Vector3.back + Vector3.down;
        player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        yield return new WaitForSeconds(2);
        canvas.SetActive(true);
        yield return new WaitForSeconds(8);
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        
	}

    public void GetInFace()
    {
        itemObject.transform.position = (itemObject.transform.position - player.transform.position).normalized * distFromPlayer;
        for (int i = 0; i < meshRenderers.Length; ++i)
        {
            meshRenderers[i].enabled = true;
        }
    }
}
