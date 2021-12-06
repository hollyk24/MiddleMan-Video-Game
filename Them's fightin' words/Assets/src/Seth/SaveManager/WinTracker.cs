using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinTracker : MonoBehaviour
{
    public class fightEntry {
        public string fightName;
        public int WinStatus = 0;

        public fightEntry(string fN, int wS){
            fightName = fN;
            WinStatus = wS;
        }

        public void printEntry(){
            Debug.Log(fightName+" "+WinStatus.ToString());
        }
    }
    public List<fightEntry> WinList;
    // public (string fightName, int WinStatus) sansWin = ("sansWin", 0);
    // public (string fightName, int WinStatus) cliffWin = ("cliffWin", 0);
    // public (string fightName, int WinStatus) riverWin = ("riverWin", 0);
    // public (string fightName, int WinStatus) beachWin = ("beachWin", 0);
    // public (string fightName, int WinStatus) bigHouseWin = ("bigHouseWin", 0);
    // public (string fightName, int WinStatus) smallHouseWin = ("smallHouseWin", 0);
    void Start()
    {

        WinList = new List<fightEntry>() {
            new fightEntry("sansWin",0),
            new fightEntry("cliffWin", 0),
            new fightEntry("riverWin", 0),
            new fightEntry("beachWin", 0),
            new fightEntry("bigHouseWin", 0),
            new fightEntry("smallHouseWin", 0)
        };
    }
    public void setWin(bool wonFight)
    {
        for(int i = 0; i < WinList.Count; i++)
        {
            if (WinList[i].WinStatus == -1)
            {
                if (wonFight)
                {
                    WinList[i].WinStatus = 1;
                }
                else { WinList[i].WinStatus = 0; }
            }
            WinList[i].printEntry();
        }
    }
    public void startFight(string str){
        for(int i = 0; i < WinList.Count; i++)
        {
            if (WinList[i].fightName == str)
            {
                    WinList[i].WinStatus = -1;
            }
        }
    }

    public bool checkWins(){
        bool wonGame = true;
        foreach(fightEntry fE in WinList){
            if(fE.WinStatus != 1){
                wonGame = false;
            }
        }
        return wonGame;
    }
    public void printList() {
        foreach(fightEntry fE in WinList){
            fE.printEntry();
        }
    }
}
