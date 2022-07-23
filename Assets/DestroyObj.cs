using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public float deleteTime = 2.0f;

    //start is called before the first frame update
    void Start(){
        Destroy(gameObject, deleteTime);
    }

    //Update is called once per frame
    void Update(){
        //Destroy(this.gameObject, deleteTime);
    }
}
