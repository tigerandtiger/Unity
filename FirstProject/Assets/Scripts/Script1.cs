using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour {
	
	public Sprite Face;
	public Sprite Back;
	public SpriteRenderer thisSprite;
	public GameManagerScript gameManager;
	public AlwaysOpened AlwaysOpened;





	void OnMouseDown ()
	{
		if (AlwaysOpened == null)
			Debug.Log ("PZDEC");
		
		if (!AlwaysOpened.alwaysOpened) 
		{
			thisSprite.sprite = Back;
			if (gameManager.firstSprite == null) 
			{
				gameManager.firstSprite = thisSprite;
				gameManager.cashAlwaysOpened = AlwaysOpened;
			} 
			else
			{
				gameManager.secondSprite = thisSprite;
				gameManager.check ();
				CheckPairsFounded ();
			}


		}
	}

	void CheckPairsFounded()
	{
		if (gameManager.isPairFounded) {
			AlwaysOpened.alwaysOpened = true;
			gameManager.cashAlwaysOpened.alwaysOpened = true;
			gameManager.firstSprite = null;
			gameManager.secondSprite = null;
			gameManager.isPairFounded = false;

		} 
		else
		{
			thisSprite.sprite = Face;
			gameManager.firstSprite.sprite = Face;
			gameManager.firstSprite = null;
			gameManager.secondSprite = null;
		}
	}
		
}
