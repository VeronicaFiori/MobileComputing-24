using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarTextManager : MonoBehaviour
{

    public Inventory playerInventory;
    public TextMeshProUGUI starDisplay;

    public void UpdateStarCount()
    {
      starDisplay.text= "" + playerInventory.stars;
    }
}
