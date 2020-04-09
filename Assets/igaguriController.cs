using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igaguriController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other) //衝突検知のためにOnCollisionEnterメソッドを追加
    {
        GetComponent<Rigidbody>().isKinematic = true; //isKinematicをtrueにすることでイガグリに働く力を無効にする
        GetComponent<ParticleSystem>().Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Shoot(new Vector3(0, 200, 2000));   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
