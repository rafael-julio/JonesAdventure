using System.Collections;
using UnityEngine;

public class SoundEffectScript : MonoBehaviour {

public static SoundEffectScript Instance;

public AudioClip jumpingSound;
public AudioClip enemySound;

void Awake()
{
	if (Instance != null)
	{
		Debug.LogError("Existem múltiplas instâncias do script SoundEffectScript.");
	}

	Instance = this;
}

public void MakeJumpingSound()
{
		MakeSound (jumpingSound);
}

public void MakeEnemySound()
{
	MakeSound (enemySound);
}

private void MakeSound(AudioClip originalClip)
{
	AudioSource.PlayClipAtPoint (originalClip, transform.position);
}
}