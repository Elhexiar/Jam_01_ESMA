using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MonsterManager : MonoBehaviour
{
    [SerializeField] public List<GameObject> monsterList;
    [SerializeField] private int drop;
    [SerializeField] private int dropcutoff;
    [SerializeField] public List<Sprite> spriteList;
    [SerializeField] public Sprite nextSprite;
    [SerializeField] public Image uiRef;

    [SerializeField] public float minimumSize;
    [SerializeField] public float maximumSize;

    // Start is called before the first frame update
    void Start()
    {
        drop = 0;
        nextSprite = spriteList[drop];
        uiRef.sprite = nextSprite;

        for (int i = 0; i < monsterList.Count; i++)
        {
            monsterList[i].transform.localScale = (Vector3.one * minimumSize) + (Vector3.one * i *((maximumSize - minimumSize) / monsterList.Count));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnMonster()
    {

        

        Instantiate(monsterList[drop],transform.position,transform.rotation);
        drop = Random.Range(0, dropcutoff);
        nextSprite = spriteList[drop];
        uiRef.sprite = nextSprite;

        Debug.Log("Spawn Monster");
    }
}
