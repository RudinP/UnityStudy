using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 move=new Vector3(-1,1,-1);
     
    void Start()
    {
        
        transform.position=move;//해당 좌표로 이동. 글로벌 기준이다. 
        transform.position+=move; //상대적으로 해당 벡터로 이동
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.Getkey(Keycode.Space))//누르고있는동안 초당 움직임
            Move();
        
    }
    void Move(){
        transform.Translate(move*Time.deltaTime,Space.World);//transform.Translate->바로 이동. 기본적으로는 local space 기반. Space.World는 글로벌. Space.Self는 로컬
        //좌표계는 Local, Global 스페이스가 있음.
    }
}
//hierarchy에서 자식부모관계: 부모가 없으면 Local==Global position. 부모가 있다면 local 이 되면 부모옵젝 기준의 좌표계.
//부모의 크기가 3배가 되면 자식들도 3배가 됨. position은 동일함(position은 자식은 부모에 대해 상대적이다.)
//이 Mover 스크립트를 자식에게만 주면, 자기 자신 기준으로만 평행이동함.(Space.World 안 쓰면 local 기준으로.)
//Transform 컴포넌트는 position이 로컬 기준임.
//transform.Position은 글로벌 기준이다
//transform.localPosition이면 로컬기준이다. (부모에 대한 상대적인 위치.)
//마찬가지로 transform.localScale. 
//transform.lossyScale은 부모로 인해 변형되지 않은 진짜 좌표(==글로벌)
