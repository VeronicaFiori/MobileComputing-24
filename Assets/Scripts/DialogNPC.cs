using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNPC : Interactable
{

    [SerializeField] private TextAssetValue dialogValue;
    [SerializeField] private TextAsset myDialog;
    [SerializeField] private Notification branchingDialogNotification;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Parla()
    {
        if (playerInRange)
        {
           
                dialogValue.value = myDialog;
                branchingDialogNotification.Raise();
            
        }
            
     }
}
