using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Random = UnityEngine.Random;

public class Gacha : MonoBehaviour
{
    [SerializeField] List<GameObject> gdsa = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Roll()
    {
        int prob = Random.Range(1, 100);
        
        if (prob == 1)
        {
            int newProb = Random.Range(1, 3);
            if (newProb == 1)
            {
                print("Inverted KC");
            }
            else
            {
                {
                    print("Inverted Lucas");
                }
            }
        }
        else if (prob > 1 && prob <= 10)
        {
            int newProb = Random.Range(1, 3);
            if (newProb == 1)
            {
                {
                    print("KC");
                }
            }
            else
            {
                {
                    print("Adam");
                }
            }
        }
        else if (prob > 10 && prob <= 30)
        {
            int newProb = Random.Range(1, 5);
            if (newProb == 1)
            {
                {
                    print("Dean");
                }
            }
            else if (newProb == 2)
            {
                {
                    print("Logan");
                }
            }
            else if (newProb == 3)
            {
                {
                    print("Lucas");
                }
            }
            else
            {
                {
                    print("Jason");
                }
            }
        }
        else if (prob > 30 && prob <= 100)
        {
            int newProb = Random.Range(1, 4);
            if (newProb == 1)
            {
                {
                    print("Ruidger");
                }
            }
            else if (newProb == 2)
            {
                {
                    print("Lauren");
                }
            }
            else
            {
                {
                    print("Mikey");
                }
            }
        }
    }
}
