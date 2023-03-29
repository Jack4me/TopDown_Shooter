using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automate : Gun {
    [SerializeField] private int bullets = 30;
    [SerializeField] private PlayerArmory _armory;
    
    public override void Shot(){
        base.Shot();
        bullets -= 1;
        if (bullets == 0){
            _armory.TakeGunByIndex(0);
        }
    }

    public override void ActivateGun(){
        base.ActivateGun();
    }

    public override void DeActivateGun(){
        base.DeActivateGun();
    }

    public override void AddBullets(int addBullets){
        base.AddBullets(bullets);
        _armory.TakeGunByIndex(1);
        bullets += addBullets;
        
    }
}
