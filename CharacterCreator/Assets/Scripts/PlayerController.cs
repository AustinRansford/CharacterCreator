using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject ArmorShop;
    public GameObject WeaponShop;
    public SpriteRenderer ArmorRenderer; 
    public SpriteRenderer WeaponRenderer;
    
    // Start is called before the first frame update
    public void Start()
    {
        this.StartScreen.SetActive(true);
 this.WeaponShop.SetActive(false);
 this.ArmorShop.SetActive(false);
    }
    public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }
    public void SetWeapon(Sprite newWeapon){
        this.WeaponRenderer.sprite = newWeapon;
    }

    // Update is called once per frame
    public void ArmorShop1(){
 this.ArmorShop.SetActive(true);
 this.WeaponShop.SetActive(false);
   this.StartScreen.SetActive(false);


    }
    public void WeaponShop1(){
 this.ArmorShop.SetActive(false);
  this.WeaponShop.SetActive(true);
  this.StartScreen.SetActive(false);
    }
    void Update()
    {
        
    }
}
