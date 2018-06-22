using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {
	public Sprite back;
	public SpriteRenderer thisSprite;
	public bool bomb;
	public GameManager gameManager;


	void OnMouseDown()
	{
		if (!gameManager.endgame) 
		{
			thisSprite.sprite = back;
			if (bomb)
			{
				gameManager.endgame = true;
			}
		}

	}


}
