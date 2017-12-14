using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyController
{
	public bool running;
	public bool stop;
	public float timeTillNext;
	public bool disappear;
}


public class JasonAnimationController : MonoBehaviour {
    Animator anim;
    
    float walk = .5f;
    float run = 1f;
    float idle = 0f;
	float speed;
    float turnLeft = -1f;
    float turnRight = 1f;
	public EnemyController[] setOfInstructions;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

	IEnumerator Controller()
	{
		for (int i = 0; i < setOfInstructions.Length; i++)
		{
			if (setOfInstructions[i].running)
			{
				speed = run;
			}
			else
			{
				speed = walk;
			}
			if (setOfInstructions[i].stop)
			{
				speed = idle;
			}
			if (setOfInstructions[i].disappear)
			{
				gameObject.SetActive(false);
			}

			anim.SetFloat("Side", 0);
			anim.SetFloat("Forward", speed);
			yield return new WaitForSeconds(setOfInstructions[i].timeTillNext);
		}
	}
}
