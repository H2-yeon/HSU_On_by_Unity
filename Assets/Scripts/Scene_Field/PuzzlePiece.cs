﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PuzzlePiece : MonoBehaviour, IDragHandler,IEndDragHandler
{
    public int snapOffset = 30;
    public GameObject piecePos;
    public Puzzle puzzle;
    public int piece_no;


    bool CheckSnapPuzzle()
    {
        for (int i = 0; i < puzzle.puzzlePosSet.transform.childCount; i++)
        {
            
            //위치에 자식오브젝트가 있으면 이미 퍼즐조각이 놓여진 것입니다.
            if (puzzle.puzzlePosSet.transform.GetChild(i).childCount != 0)
            {
                continue;
            }
            else if (Vector2.Distance(puzzle.puzzlePosSet.transform.GetChild(i).position, transform.position) < snapOffset)
            {
                transform.SetParent(puzzle.puzzlePosSet.transform.GetChild(i).transform);
                transform.localPosition = Vector3.zero;
                return true;
            }
        }
        return false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
       

        if (Vector3.Distance(piecePos.transform.position, transform.position) < snapOffset)
        {
            transform.SetParent(piecePos.transform);
            transform.localPosition = Vector3.zero;
        }
        //일치하는 위치가 없을 경우 부모자식 관계를 해제합니다.
        if (!CheckSnapPuzzle())
        {
            transform.SetParent(puzzle.puzzlePieceSet.transform);
        }

        if (puzzle.IsClear())
        {
            Debug.Log("Clear");
          
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        piece_no = gameObject.name[gameObject.name.Length - 1] - '0';
    }

    
    
}