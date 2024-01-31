using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite halfFullHeart;
    public Sprite emptyHeart;
    public FloatValue heartContainers;
    public FloatValue playerCurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        InitHearts();
     }

    public void InitHearts()
    {
        for(int i = 0; i < heartContainers.RuntimeValue; i++) 
        {
            if (i < hearts.Length)
            {
                hearts[i].gameObject.SetActive(true);
                hearts[i].sprite = fullHearts;

            }

        }
 
    }

    public void UpdateHearts()
    {
        InitHearts();
        float tempHealth = playerCurrentHealth.RuntimeValue / 2;
        for (int i = 0; i < heartContainers.RuntimeValue; i++)
        {
            if (i <= tempHealth - 1)
            {
                hearts[i].sprite = fullHearts;
            }
            else if (i >= tempHealth)
            {
                hearts[i].sprite = emptyHeart;

            }
            else
            {
                hearts[i].sprite = halfFullHeart;

            }
        }
    }
}
