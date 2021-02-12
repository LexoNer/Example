using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDinamic : MonoBehaviour
{
    public GameObject[] tab;
    int num = 0;
    Vector3 n;
    // Start is called before the first frame update
    void Start()
    {
        

        for(int x = 0; x < 5; ++x)
        {
            for(int z = 0; z < 5; ++z)
            {
                if (num == 0)
                {
                    num = 1;
                }
                else
                {
                    num = 0;
                }

                if (num==0)
                    Instantiate(tab[1], new Vector3(x, 0, z), Quaternion.identity);
                else
                    Instantiate(tab[0], new Vector3(x, 0, z), Quaternion.identity);
            }

        }

        for (int x = 0; x < 15; ++x)
        {
            for (int z = 0; z < 5; ++z)
            {
                if (num == 0)
                {
                    num = 1;
                }
                else
                {
                    num = 0;
                }

                if (num == 0)
                    Instantiate(tab[0], new Vector3(x-5, 0, 5+z), Quaternion.identity);
                else
                    Instantiate(tab[1], new Vector3(x-5, 0, 5+z), Quaternion.identity);
            }

        }

        for (int x = 0; x < 5; ++x)
        {
            for (int z = 0; z < 5; ++z)
            {
                if (num == 0)
                {
                    num = 1;
                }
                else
                {
                    num = 0;
                }

                if (num == 0)
                    Instantiate(tab[1], new Vector3(x, 0, 10+z), Quaternion.identity);
                else
                    Instantiate(tab[0], new Vector3(x, 0, 10+z), Quaternion.identity);
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
