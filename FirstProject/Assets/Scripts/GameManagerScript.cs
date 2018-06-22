using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour{

	public int PairsCount = 0;
	public bool isPairFounded = false;
	public SpriteRenderer firstSprite = null;
	public SpriteRenderer secondSprite = null;
	public AlwaysOpened cashAlwaysOpened;

	public void check()
	{
		if (firstSprite != null && secondSprite != null && firstSprite.sprite == secondSprite.sprite && firstSprite!=secondSprite) 
		{
				PairsCount++;
				isPairFounded = true;
		}
	}
		
}
