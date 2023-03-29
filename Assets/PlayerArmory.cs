using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmory : MonoBehaviour {
    [SerializeField] private Gun[] guns;
    private int gunIndex = 1;
    
    void Start(){
        TakeGunByIndex(gunIndex);
    }

    public void TakeGunByIndex(int curentGun){
        gunIndex = curentGun;
        for (int i = 0; i < guns.Length; i++){
            if (i == curentGun){
                guns[i].ActivateGun();
            }
            else{
                guns[i].DeActivateGun();
            }
        }
    }

    public void AddBullets(int indexGun, int countOfBullets){
        guns[indexGun].AddBullets(countOfBullets);
    }
}
