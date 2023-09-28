using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject fireitem;
    float randoma = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            randoma = UnityEngine.Random.Range(-8.6f, 9f);
            Instantiate(fireitem, new Vector3(randoma, 2.5f, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(randoma);
    }
}
