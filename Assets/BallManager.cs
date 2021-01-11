using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject BallPrefab;

    [HideInInspector]
    public GameObject CurrentBall;

    public static BallManager Instance;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (CurrentBall == null)
        {
            CurrentBall = Instantiate(BallPrefab, transform.position, transform.rotation) as GameObject;
        }
    }
}
