using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;
using System.Linq;

public class MainLvl1 : MonoBehaviour
{

    public List<Sprite> alp = new List<Sprite> () {};
    public List<Sprite> num = new List<Sprite> () {};
    public List<Image> item = new List<Image> () {};
    public List<Transform> itemTransform = new List<Transform> () {};

    // Start is called before the first frame update
    void Start()
    {
        int randomLvl =  UnityEngine.Random.Range(0, 2);
        if (randomLvl == 0)
            for (int i = 0; i < item.Count; i++)
            {
                int randomCount = UnityEngine.Random.Range(0, alp.Count);
                item[i].sprite = alp[randomCount];
                alp.RemoveAt(randomCount);
            }
        else
            for (int i = 0; i < item.Count; i++)
            {
                int randomCount = UnityEngine.Random.Range(0, num.Count);
                if (randomCount == 6 || randomCount == 7) 
                {
                    Quaternion pos = Quaternion.Euler(0, 0, -90);
                    itemTransform[i].rotation = pos;
                }
                item[i].sprite = num[randomCount];
                num.RemoveAt(randomCount);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
