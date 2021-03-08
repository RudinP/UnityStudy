using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    private Renderer myRenderer; //myRenderer를 바깥에서는 수정 불가하도록
    public Color touchColor; //박스가 골 지점에 있을 때 색
    private Color originalColor; //박스가 골 지점 외에 있을 때 색
    public bool check=false; //박스가 원래는 골 지점 외에 있으므로 false로 둠, 골 지점에 있는 경우를 판단하기 위한 bool;
    void Start()
    {
        myRenderer = GetComponent<Renderer>(); //GetComponent<>();로 연결해ㅈㅁ
        originalColor = myRenderer.material.color; //오리지널 컬러를 저장해줌

    }

    


    void OntriggerEnter(Collider other) { //OntriggerEnter(Collider other)은 트리거 체크해둔 곳에 부딪혔을 때 확인
        if (other.tag == "Goal") myRenderer.material.color = touchColor; //그냥 트리거 체크해둔 모든 곳에 반응하면 안되니까 other.tag=="Goal"해줌.(골지점 tag이름이 Goal임)
    }
    void OnTriggerExit(Collider other) //OnTriggerExit은 해당 트리거 지점에 없을 때
    {
        myRenderer.material.color = originalColor; //myRenderer을 통해 Renderer 컴포넌트 안에 있는 material의 color에 
        check = false;
    }
    void OnTriggerStay(Collider other) //OnTriggerExit은 해당 트리거 지점에 계속 있을 때
    {
        if (other.tag == "Goal")
        {
            myRenderer.material.color = touchColor; //색 바꿔줌
            check = true;
        }
    }
}
