using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageProgressBar : MonoBehaviour
{
    //logic flow
    //1. 초기의 player와 clearArea 사이의 거리 측정
    //2. player가 움직인 z축 거리 측정
    //3. 0~1 사이의 수치로 변환
    private GameObject player, clearArea;
    private Slider stageProgressBar;
    private float init_pos, stage_length;
    public float current_distance;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        clearArea = GameObject.Find("ClearArea");
        init_pos = player.transform.position.z;

        stage_length = clearArea.transform.position.z - init_pos;

        stageProgressBar = this.GetComponent<Slider>();
        stageProgressBar.value = 0f;
    }

    void Update()
    {
        current_distance = (player.transform.position.z - init_pos) / stage_length * 100f;

        stageProgressBar.value = current_distance / 100f;
    }
}
