using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject igaguri = Instantiate(igaguriPrefab) as GameObject;
            //igaguri.GetComponent<igaguriController>().Shoot(new Vector3(0, 200, 2000));
            //これまでこういうの結構扱ったが、考え方的にはC言語とかの自作関数作成後のその関数呼び出しに近い

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // ScreenPointToRayでInputの座標へ向かうベクトルに沿って進むRayクラスを返す
            // つまり、光線を飛ばして、コライダがアタッチされたオブジェクトとのあたり判定を検知する。光がオブジェクトに遮られたらそれを検知
            Vector3 worldDir = ray.direction; // directionにすることでカメラから飛んでいく方向を指示する（画面奥へ向かって光線が飛ぶ）
            igaguri.GetComponent<igaguriController>().Shoot(worldDir.normalized * 2000);
        }
    }
}
