using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMake : MonoBehaviour {
    //int mapSize = 21;  //マップのサイズ  奇数のみ
    int[,] maze;   //マップ生成用
    int cnt = 0;   //迷路の壁を生成した数

    [SerializeField]
    int mapSize;  //ほるマップのサイズ

    [SerializeField]
    GameObject wallObject;   //壁オブジェクトを設定

    [SerializeField]
    GameObject groundObject;   //地面オブジェクトを設定

    [SerializeField]
    GameObject GoalObject;   //ゴールオブジェクトを設定

	// Use this for initialization
	void Start () {
        //マップの生成終了条件を算出
        int endNum = ((mapSize + 1) / 2) * ((mapSize + 1) / 2) - 1;

        maze = new int[mapSize + 2, mapSize + 2];

        while(endNum > cnt)
        {
            int x = Random.Range(0, (mapSize + 1) / 2) * 2;
            int y = Random.Range(0, (mapSize + 1) / 2) * 2;
            if (cnt == 0) maze [x + 1, y + 1] = 1;  //初回だけあらかじめ穴を開けておく
            if (maze[x + 1, y + 1] == 1) WallDig(x, y, 0);
        }
        Output();

        Instantiate(GoalObject, new Vector3(mapSize, 0, mapSize), Quaternion.identity);
    }
	

    void WallDig(int x, int y, int oldVec){
        int[] vx = { 0, 2, 0, -2 };
        int[] vy = { -2, 0, 2, 0 };

        bool retFlg = false;

        int r = Random.Range(0, 4);


        //マップの端は掘る事が出来ない
        if (r == 0 && y <= 0) retFlg = true;
        if (r == 1 && (x + 2) >= mapSize) retFlg = true;
        if (r == 2 && (y + 2) >= mapSize) retFlg = true;
        if (r == 3 && x <= 0) retFlg = true;


        //問題がある時はもう一度やり直す
        if (retFlg){
            WallDig(x, y, oldVec);
            return;
        }


        //壁を掘れそうならほる
        if (maze [x+1 + vx [r],y+1 + vy [r]] == 0){
            maze [x+1 + vx[r], y+1 + vy[r]] = 1;
            maze [x+1 + vx[r] / 2, y + 1 + vy[r] / 2] = 1;
            cnt++;

            //再帰ループ
            WallDig(x + vx[r], y + vy[r], r);
        }
    }
     
    void Output(){
        GameObject obj = new GameObject();
        obj.name = "Mize";
        for (int x = 0; x < mapSize + 2; x++){
            for (int y = 0; y < mapSize + 2; y++){
                if(maze [x,y] == 0){
                    Instantiate(wallObject, new Vector3(x, 0, y), Quaternion.identity).transform.parent = obj.transform;
                }else{
                    Instantiate(groundObject, new Vector3(x, 0, y), Quaternion.identity).transform.parent = obj.transform;
                }
            }
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
