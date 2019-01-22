using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float moveSpeed = 2;
    private SpriteRenderer mSpriteRenderer;
    //  左上右下
    public Sprite[] mSpriteArray;


    /**
     * Awake 生命周期函数 用于初始化变量
     */
    private void Awake(){
        mSpriteRenderer = GetComponent<SpriteRenderer>();

    }

    // 相当于Android中的onDraw
    void Update()
    {	
    	//	读取用户在水平方向的操作
    	float x = Input.GetAxisRaw("Horizontal");
    	//	使绑定物体移动
    	transform.Translate(Vector3.right*x*moveSpeed*Time.deltaTime,Space.World);
        if(x>0){
            mSpriteRenderer.sprite = mSpriteArray[2];
        }else if(x<0){
            mSpriteRenderer.sprite = mSpriteArray[0];
        }
    	//	读取用户在竖直方向的操作
    	float y = Input.GetAxisRaw("Vertical");
    	transform.Translate(Vector3.up*y*moveSpeed*Time.deltaTime,Space.World);
        if(y>0){
            mSpriteRenderer.sprite = mSpriteArray[1];
        }else if(y<0){
            mSpriteRenderer.sprite = mSpriteArray[3];
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
