using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropingDoor : MonoBehaviour
{
    [SerializeField] private TMP_Text txt_DoorCost;
    
    [SerializeField] private PlayerStats playerStat;
    [SerializeField] private int DoorCost = 5;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip; 

     private Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        txt_DoorCost.text = "X " + DoorCost.ToString();
        this.anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && playerStat.EnemiesCount >= DoorCost)
        {
            this.source.PlayOneShot(clip);
            playerStat.EnemiesCount -= this.DoorCost;
            anim.SetBool("isOpen",true);
            Destroy(gameObject, 2f);

        }
    }
   
    
    

}
