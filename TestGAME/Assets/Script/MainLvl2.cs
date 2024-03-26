using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Linq;

public class MainLvl2 : MonoBehaviour
{
     public List<Sprite> alp = new List<Sprite> () {};
    public List<Sprite> num = new List<Sprite> () {};
    public List<Sprite> alpCopy = new List<Sprite> () {};
    public List<Sprite> numCopy = new List<Sprite> () {};
    public List<Image> item = new List<Image> () {};
    public List<Transform> itemTransform = new List<Transform> () {};
    public List<string> alpStr = new List<string> () {};
    public List<string> numStr = new List<string> () {};
    public List<string> alpStrCopy = new List<string> () {};
    public List<string> numStrCopy = new List<string> () {};
    public string[] array = new string[6];

    public TMP_Text textFind;
    public int count = 0;

    public int[] indexnum = new int[2];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticCount.lvlCount == 1 && count == 0){
            count = 1;
            int randomLvl =  UnityEngine.Random.Range(0, 2);
            if (randomLvl == 0)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    int randomCount = UnityEngine.Random.Range(0, alp.Count);
                    item[i].sprite = alp[randomCount];
                    array[i] = alpStr[randomCount];
                    alp.RemoveAt(randomCount);
                    alpStr.RemoveAt(randomCount);
                }
                int randomFind = 0;
                int j = 0;
                while (j < 1)
                {
                    randomFind = UnityEngine.Random.Range(0, item.Count);
                    if (array[randomFind] != StaticCount.findLast)
                    {
                        break;
                    }
                }
                textFind.text = array[randomFind];
                StaticCount.TrueAns = randomFind;
                StaticCount.findLast = array[randomFind];
                alp.Clear();
                alpStr.Clear();
                for (int i = 0; i < alpStrCopy.Count; i++)
                {
                    alp.Add(alpCopy[i]);
                    alpStr.Add(alpStrCopy[i]);
                }
            }
            else
            {
                indexnum[0] = -1;
                indexnum[1] = -1;
                int h = 0;
                for (int i = 0; i < item.Count; i++)
                {
                    int randomCount = UnityEngine.Random.Range(0, num.Count);
                    if (num[randomCount].name == "SD_NC_Cookies_1_6" || num[randomCount].name == "SD_NC_Cookies_1_7") 
                    {
                        indexnum[h] = i;
                        Quaternion pos = Quaternion.Euler(0, 0, -90);
                        itemTransform[i].rotation = pos;
                        h++;
                    }
                    item[i].sprite = num[randomCount];
                    array[i] = numStr[randomCount];
                    num.RemoveAt(randomCount);
                    numStr.RemoveAt(randomCount);
                }
                int randomFind = 0;
                int j = 0;
                while (j < 1)
                {
                    randomFind = UnityEngine.Random.Range(0, item.Count);
                    if (array[randomFind] != StaticCount.findLast)
                    {
                        break;
                    }
                }
                textFind.text = array[randomFind];
                StaticCount.TrueAns = randomFind;
                StaticCount.findLast = array[randomFind];
                num.Clear();
                numStr.Clear();
                for (int i = 0; i < numStrCopy.Count; i++)
                {
                    num.Add(numCopy[i]);
                    numStr.Add(numStrCopy[i]);
                }
            }
        }
    }
}