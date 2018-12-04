using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    private AudioSource audioSource;
    [SerializeField]
    private AudioClip[] levelMusicChangerArray=new AudioClip[4];

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        OnLevelWasLoaded(0);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnLevelWasLoaded(int index)
    {
        //Debug.Log("play clip" + levelMusicChangerArray[index]);
        if(levelMusicChangerArray==null)
        {
            Debug.Log("array is null");
        }
        else if(audioSource==null)
        {
            Debug.Log("audio source is null");
        }
        else if (audioSource.clip==null)
        {
            Debug.Log("audiosource clip is null");
        }
        audioSource.clip = levelMusicChangerArray[index];
        audioSource.Play();
        audioSource.loop = true;
    }
    public void ChangeVolume(float value)
    {
        audioSource.volume = value;
    }
}
