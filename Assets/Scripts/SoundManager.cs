using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
	
   public AudioSource audioSource;

<<<<<<< Updated upstream
   public AudioClip steps , solvepuzzle, opendoor, press , press2 ,Shelfmovm, stoneDoor;
=======
   public AudioClip steps , solvepuzzle, opendoor, press , press2 ,Shelfmovm,stoneDoor;
>>>>>>> Stashed changes


    private void Start()
	{
      audioSource = GetComponent<AudioSource>();
	}
    
	public void PlayPlayerStep()
	{
    audioSource.PlayOneShot(steps);
	}
	
    public void PlaySolvePuzzle()
	{
    audioSource.PlayOneShot(solvepuzzle);
	}
    public void PlayOpenDoor()
	{
    audioSource.PlayOneShot(opendoor);
	}
	public void PlayPreeskey1()
	{
		audioSource.PlayOneShot(press);
	}

	public void PlayPreeskey2()
	{
		audioSource.PlayOneShot(press2);
	}
	public void PlayShelfmovement()
	{
		audioSource.PlayOneShot(Shelfmovm);
	}
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
	public void PlayOpenStoneDoor()
	{
    audioSource.PlayOneShot(stoneDoor);
	}
}