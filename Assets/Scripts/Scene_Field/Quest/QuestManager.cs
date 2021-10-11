﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public int questId;
    //NPC1 Quiz
    public InputField NPC_1_Quiz_1_Answer;
    public Image right1;
    public Image Wrong1;

    public InputField question2;

    //NPC4 Quiz
    public InputField NPC_4_Quiz_1_Answer, NPC_4_Quiz_2_Answer, NPC_4_Quiz_3_Answer;
    public Image Right41;
    public Image Right42;
    public Image Right43;
    public Image Wrong41;
    public Image Wrong42;
    public Image Wrong43;
    //NPC4 Quiz end

    public Button M1;
    public Button M2;
    public Button M3;
    public Button M4;
    public Button M5;

    public Button H1;
    public Button H2;
    public Button H3;
    public Button H4;
    public Button H5;
    public Button Submit;
    

    public Image right4;
    public Image Wrong4;
    public Image CompleteStamp;

    Dictionary<int, QuestData> questList;

    
    void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
    }

    void Start()
    {
        M1.interactable = false;
        M2.interactable = false;
        M3.interactable = false;
        M4.interactable = false;
        M5.interactable = false;

        H1.interactable = true;
        H2.interactable = false;
        H3.interactable = false;
        H4.interactable = false;
        H5.interactable = false;
    }

    //NPC1 Quiz
    public void NPC_1_Quiz()
    {

            if (NPC_1_Quiz_1_Answer.text == "4268")
            {
                right1.gameObject.SetActive(true);
            }
            else
            {
                Wrong1.gameObject.SetActive(true);
                NPC_1_Quiz_1_Answer.text = "";
            }

    }

    //NPC4 Quiz
    public void NPC_4_Quiz_1()
    {

        if (NPC_4_Quiz_1_Answer.text == "2")
        {
            Right41.gameObject.SetActive(true);
        }
        else
        {
            Wrong41.gameObject.SetActive(true);
            NPC_4_Quiz_1_Answer.text = "";
        }

    }
    public void NPC_4_Quiz_2()
    {

        if (NPC_4_Quiz_2_Answer.text == "1")
        {
            Right42.gameObject.SetActive(true);
        }
        else
        {
            Wrong42.gameObject.SetActive(true);
            NPC_4_Quiz_2_Answer.text = "";
        }

    }
    public void NPC_4_Quiz_3()
    {

        if (NPC_4_Quiz_3_Answer.text == "4")
        {
            Right43.gameObject.SetActive(true);
        }
        else
        {
            Wrong43.gameObject.SetActive(true);
            NPC_4_Quiz_3_Answer.text = "";
        }

    }
    //NPC4 Quiz end


    public void Quiz3Button()
    {
        if (question2.text == "박성재")
        {
            right4.gameObject.SetActive(true);
        }
        else
        {
            Wrong4.gameObject.SetActive(true);
        }
    }

    public void Mission1QuestOpen()
	{
        M1.interactable = true;

	}

    public void Mission2QuestOpen()
	{
        
        M2.interactable = true;
	}

    public void Mission3QuestOpen()
    {
       
        M3.interactable = true;
    }

    public void Mission4QuestOpen()
    {
        
        M4.interactable = true;
    }

    public void Mission5QuestOpen()
    {
        
        M5.interactable = true;
    }
    public void Hidden1QuestOpen()
    {
        H1.interactable = true;
    }
    public void Complete()
	{
        CompleteStamp.gameObject.SetActive(true);
	}

  

   

    void GenerateData()
	{
        //questList.Add(10, new QuestData("첫 번째 퀘스트", new int[1] { }));
	}
    
    public int GetQuestTalkIndex(int id)
	{
        return questId;
	}
    // Start is called before the first frame update
}
