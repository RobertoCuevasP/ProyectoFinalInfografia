using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    public GameObject[] changeCharacter;

    private int index = 0;

    void Start()
    {
        foreach(GameObject obj in changeCharacter)
        {
            obj.SetActive(false);
        }

        Select(index);
    }

    public void GoRight()
    {
        changeCharacter[index].SetActive(false);
        index++;
        if(index >= changeCharacter.Length)
        {
            index = 0;
        }

        Select(index);
    }

    public void GoLeft()
    {
        changeCharacter[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = changeCharacter.Length - 1;
        }

        Select(index);
    }

    public void Select(int i)
    {
        foreach(GameObject obj in changeCharacter)
        {
            obj.SetActive(false);
        }

        changeCharacter[i].SetActive(true);

    }
}
