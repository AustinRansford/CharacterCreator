using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject ArmorShop;
    public GameObject WeaponShop;
    public GameObject Magicshop;
    public SpriteRenderer ArmorRenderer; 
    public SpriteRenderer WeaponRenderer;
    public ParticleSystem Ice;
    public ParticleSystem Fire;
    public ParticleSystem Poison;

    
    
    // Start is called before the first frame update
    public void Start()
    {
        this.StartScreen.SetActive(true);
 this.WeaponShop.SetActive(false);
 this.ArmorShop.SetActive(false);
  this.Magicshop.SetActive(false);
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
    this.Magicshop.SetActive(false);


    }
    public void WeaponShop1(){
 this.ArmorShop.SetActive(false);
  this.WeaponShop.SetActive(true);
  this.StartScreen.SetActive(false);
   this.Magicshop.SetActive(false);
    }
    public void MagicShop1(){
     this.ArmorShop.SetActive(false);
  this.WeaponShop.SetActive(false);
  this.StartScreen.SetActive(false);
  this.Magicshop.SetActive(true);
  }
  public void Icebutton(){
      this.Ice.gameObject.SetActive(true);
      this.Fire.gameObject.SetActive(false);
      this.Poison.gameObject.SetActive(false);
      
  }
  public void Firebutton(){
      this.Ice.gameObject.SetActive(false);
      this.Fire.gameObject.SetActive(true);
      this.Poison.gameObject.SetActive(false);
  }
  public void Poisonbutton(){
      this.Ice.gameObject.SetActive(false);
      this.Fire.gameObject.SetActive(false);
      this.Poison.gameObject.SetActive(true);
  }
    void Update()
    {
        
    }
}
