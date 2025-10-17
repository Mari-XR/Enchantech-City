using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwap : MonoBehaviour
{
    [SerializeField] GameObject characterInitial;
    [SerializeField] GameObject characterNew;

    [SerializeField] ParticleSystem[] particles;

    [SerializeField] float delayTime;
    float trackingTime;
    bool playing = false;
    // Start is called before the first frame update
    void Start()
    {
        characterNew.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            trackingTime -= Time.deltaTime;

            if (trackingTime <= 0.0f)
            {
                characterInitial.SetActive(false);
                characterNew.SetActive(true);
                playing = false;
            }
        }
    }

    public void ActivateSwap ()
    {
        foreach (ParticleSystem p in particles)
        {
            p.Play();
        }
        trackingTime = delayTime;
        playing = true;
    }
}
